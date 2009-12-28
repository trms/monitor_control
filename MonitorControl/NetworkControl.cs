using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ZeroconfService;

namespace TRMS.CarouselMonitorControl
{
	public abstract class NetworkControl
	{
		private static NetService m_mdnsService = null;
		private static readonly string m_serviceName = "_monitor_control._tcp";
		private static readonly string m_serviceDomain = String.Empty;
		private static readonly int m_port = 26908;
		private static Socket m_listener = null;
		private static Dictionary<string, Client> m_clients = new Dictionary<string, Client>();
		private static bool m_listening = false;

		private class Client
		{
			public byte[] Buffer = new byte[1024];
			public Socket Socket = null;
		}

		public static void StartServer()
		{
			if (m_listening)
				return;
			StartListening();
			RegisterBonjour();
			m_listening = true;
		}

		public static void StopServer()
		{
			if (m_listening == false)
				return;
			UnregisterBonjour();
			StopListening();
			m_listening = false;
		}


		private static void RegisterBonjour()
		{
			m_mdnsService = new NetService(m_serviceDomain, m_serviceName, Environment.MachineName, m_port);
			m_mdnsService.Publish();
		}

		private static void UnregisterBonjour()
		{
			if(m_mdnsService != null)
				m_mdnsService.Stop();
		}

		private static void StartListening()
		{
			if (m_listener != null)
				return;

			m_listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint ep = new IPEndPoint(IPAddress.Any, m_port);
			m_listener.Bind(ep);
			m_listener.Listen(5);
			m_listener.BeginAccept(new AsyncCallback(AcceptConnection), m_listener);
		}

		private static void StopListening()
		{
			if (m_listener == null)
				return;

			lock (m_clients)
			{
				foreach (Client c in m_clients.Values)
					c.Socket.Close();
				m_clients.Clear();
				m_listener.Close();
				m_listener = null;
			}
		}

		private static void WaitForData(Client client)
		{
			try
			{
				if (client.Socket.Connected)
					client.Socket.BeginReceive(client.Buffer, 0, client.Buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveData), client);
			}
			catch (SocketException)
			{
				string key = client.Socket.RemoteEndPoint.ToString();
				lock (m_clients)
				{
					m_clients.Remove(key);
					client.Socket.Close();
				}
			}
		}

		private static void ReceiveData(IAsyncResult iar)
		{
			Client client = (Client)iar.AsyncState;
			string key = null;
			try
			{
				key = client.Socket.RemoteEndPoint.ToString();
				int count = client.Socket.EndReceive(iar);
				if (count == 0)
				{
					lock (m_clients)
					{
						m_clients.Remove(key);
						client.Socket.Close();
					}
					return;
				}
				string data = System.Text.Encoding.ASCII.GetString(client.Buffer, 0, count).Trim();
				if (String.IsNullOrEmpty(data) == false)
				{
					if (data.Contains("+"))
						PowerManagement.PowerOn();
					else if (data.Contains("-"))
						PowerManagement.PowerOff();
				}
					
				// call WaitForData to wait for the next thing to arrive
				WaitForData(client);
			}
			catch (ObjectDisposedException) { }
			catch (SocketException)
			{
				if (key != null)
				{
					lock (m_clients)
					{
						m_clients.Remove(key);
						client.Socket.Close();
					}
				}
			}
		}

		private static void AcceptConnection(IAsyncResult iar)
		{
			try
			{
				Socket s = (Socket)iar.AsyncState;
				Socket clientSocket = s.EndAccept(iar);

				// begin receiving chain
				Client c = new Client();
				c.Socket = clientSocket;
				lock (m_clients)
					m_clients.Add(clientSocket.RemoteEndPoint.ToString(), c);
				WaitForData(c);

				// attempt to accept another connection
				s.BeginAccept(new AsyncCallback(AcceptConnection), s);
			}
			catch (ObjectDisposedException) { }
		}
	}
}
