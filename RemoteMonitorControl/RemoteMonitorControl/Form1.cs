using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZeroconfService;
using System.Collections;

namespace RemoteMonitorControl
{
    public partial class Form1 : Form
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
				return service.Name;
			}
		}

        public Form1()
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
			ServiceListEntry item = new ServiceListEntry(service);

			servicesList.Items.Add(item);

            service.DidResolveService += new NetService.ServiceResolved(service_DidResolveService);
            service.ResolveWithTimeout(10);
        }

        void service_DidResolveService(NetService service)
        {
			foreach (ServiceListEntry item in servicesList.Items)
			{
				if (item.Service == service)
				{
					item.Resolved = true;
					break;
				}
			}
		}
    }
}