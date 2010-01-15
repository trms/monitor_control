using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using ZeroconfService;

namespace RemoteMonitorControl
{
    public partial class RemoteControl : Form
    {
        NetServiceBrowser nsBrowser = null;
		private readonly int m_port = 26908;
		private readonly int m_messageTime = 100;
		private readonly int m_errorTime = 2500;
		
		private class ServiceListEntry
		{
			private NetService service;
			public bool Resolved = false;

			public NetService Service
			{
				get { return service; }
			}

			public ServiceListEntry(NetService s)
			{
				service = s;
			}

			public override string ToString()
			{
				if (Resolved == false)
					return String.Empty;
				return service.Name;
			}
		}

        public RemoteControl()
        {
            InitializeComponent();

            try
            {
                nsBrowser = new NetServiceBrowser();
                nsBrowser.InvokeableObject = this;
                nsBrowser.DidFindService += new NetServiceBrowser.ServiceFound(nsBrowser_DidFindService);
                nsBrowser.DidRemoveService += new NetServiceBrowser.ServiceRemoved(nsBrowser_DidRemoveService);
                nsBrowser.SearchForService("_monitor_control._tcp", String.Empty);
            }
            catch
            {
                MessageBox.Show("Bonjour is not installed");
            }
		}

        void nsBrowser_DidRemoveService(NetServiceBrowser browser, NetService service, bool moreComing)
        {
            servicesList.BeginUpdate();

			foreach (ServiceListEntry item in servicesList.Items)
            {
				if (item.Service == service)
				{
					servicesList.Items.Remove(item);
					break;
				}
            }

            servicesList.EndUpdate();
        }

        void nsBrowser_DidFindService(NetServiceBrowser browser, NetService service, bool moreComing)
        {
            service.DidResolveService += new NetService.ServiceResolved(service_DidResolveService);
            service.ResolveWithTimeout(10);
        }

        void service_DidResolveService(NetService service)
        {
			ServiceListEntry item = new ServiceListEntry(service);
			item.Resolved = true;
			servicesList.Items.Add(item);
		}

		private void servicesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			radioList.Checked = true;
			UpdateOnOff();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UpdateOnOff();
		}

		private void UpdateOnOff()
		{
			OnButton.Enabled = OffButton.Enabled = (radioHost.Checked || (servicesList.SelectedIndices.Count > 0));
		}

		private void OnButton_Click(object sender, EventArgs e)
		{
			SendToMonitors("+");
		}

		private void OffButton_Click(object sender, EventArgs e)
		{
			SendToMonitors("-");
		}

		private void SendToMonitors(string command)
		{
			this.Enabled = false;
			this.Cursor = Cursors.WaitCursor;
			if (radioList.Checked)
			{
				foreach (ServiceListEntry item in servicesList.SelectedItems)
				{
					// find any ipv4 addresses in the item
					foreach (IPEndPoint address in item.Service.Addresses)
					{
						if (address.AddressFamily == AddressFamily.InterNetwork)
							SendToMonitor(command, address);
					}
				}
			}
			else if (radioHost.Checked)
			{
				try
				{
					string host = textBox1.Text;
					IPHostEntry hostEntry = null;
					List<IPAddress> addresses = new List<IPAddress>();
					if (host.Substring(0, 1).IndexOfAny("0123456789".ToCharArray()) != -1)
                        addresses.Add(IPAddress.Parse(host));
					else
					{
						hostEntry = Dns.GetHostEntry(host);
						if (hostEntry.AddressList.Length > 0)
                            addresses.AddRange(hostEntry.AddressList);
						else
						{
							toolStripStatusLabel1.Text = "Can't resolve host";
							Application.DoEvents();
							System.Threading.Thread.Sleep(m_errorTime);
						}
					}

					// create socket and connect to host
					foreach(IPAddress address in addresses)
					{
						IPEndPoint ipe = new IPEndPoint(address, m_port);
                        if (address.AddressFamily == AddressFamily.InterNetwork)
                            SendToMonitor(command, ipe);
					}
				}
				catch (Exception ex)
				{
					toolStripStatusLabel1.Text = ex.Message;
					Application.DoEvents();
					System.Threading.Thread.Sleep(m_errorTime);
				}
			}
			toolStripStatusLabel1.Text = String.Empty;
			this.Enabled = true;
			this.Cursor = Cursors.Default;
		}

		private void SendToMonitor(string command, IPEndPoint address)
		{
			try
			{
				toolStripStatusLabel1.Text = String.Format("Connecting to {0}:{1}", address.Address, address.Port);
				Application.DoEvents();
				System.Threading.Thread.Sleep(m_messageTime);
				Socket socket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
				socket.Connect(address);
				toolStripStatusLabel1.Text = String.Format("Sending command to {0}:{1}", address.Address, address.Port);
				Application.DoEvents();
				System.Threading.Thread.Sleep(m_messageTime);
				socket.Send(System.Text.Encoding.ASCII.GetBytes(command));
				socket.Close();
				toolStripStatusLabel1.Text = String.Format("Closed connection to {0}:{1}", address.Address, address.Port);
				Application.DoEvents();
				System.Threading.Thread.Sleep(m_messageTime);
			}
			catch (Exception ex)
			{
				toolStripStatusLabel1.Text = ex.Message;
				Application.DoEvents();
				System.Threading.Thread.Sleep(m_errorTime);
			}
			Application.DoEvents();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			radioHost.Checked = true;
			UpdateOnOff();
		}

		private void radioHost_CheckedChanged(object sender, EventArgs e)
		{
			UpdateOnOff();
		}

		private void radioList_CheckedChanged(object sender, EventArgs e)
		{
			UpdateOnOff();
		}
    }
}