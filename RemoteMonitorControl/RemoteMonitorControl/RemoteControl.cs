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
        NetServiceBrowser nsBrowser = new NetServiceBrowser();
		
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

            nsBrowser.InvokeableObject = this;
            nsBrowser.DidFindService += new NetServiceBrowser.ServiceFound(nsBrowser_DidFindService);
            nsBrowser.DidRemoveService += new NetServiceBrowser.ServiceRemoved(nsBrowser_DidRemoveService);
			nsBrowser.SearchForService("_monitor_control._tcp", String.Empty);
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
			OnButton.Enabled = OffButton.Enabled = (servicesList.SelectedIndices.Count > 0);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			OnButton.Enabled = OffButton.Enabled = (servicesList.SelectedIndices.Count > 0);
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
			foreach (ServiceListEntry item in servicesList.SelectedItems)
			{
				// find any ipv4 addresses in the item
				foreach (IPEndPoint address in item.Service.Addresses)
				{
					if (address.AddressFamily == AddressFamily.InterNetwork)
					{
						try
						{
							label1.Text = String.Format("Connecting to {0}:{1}", address.Address, address.Port);
							Application.DoEvents();
							System.Threading.Thread.Sleep(100);
							Socket socket = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
							socket.Connect(address);
							label1.Text = String.Format("Sending command to {0}:{1}", address.Address, address.Port);
							Application.DoEvents();
							System.Threading.Thread.Sleep(100);
							socket.Send(System.Text.Encoding.ASCII.GetBytes(command));
							socket.Close();
							label1.Text = String.Format("Closed connection to {0}:{1}", address.Address, address.Port);
							Application.DoEvents();
							System.Threading.Thread.Sleep(100);
						}
						catch (Exception ex)
						{
							label1.Text = ex.Message;
						}
						Application.DoEvents();
					}
				}
			}
			label1.Text = String.Empty;
		}
    }
}