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

        public Form1()
        {
            InitializeComponent();

            nsBrowser.InvokeableObject = this;
            nsBrowser.DidFindService += new NetServiceBrowser.ServiceFound(nsBrowser_DidFindService);
            nsBrowser.DidRemoveService += new NetServiceBrowser.ServiceRemoved(nsBrowser_DidRemoveService);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void nsBrowser_DidRemoveService(NetServiceBrowser browser, NetService service, bool moreComing)
        {
            servicesList.BeginUpdate();

            foreach (ListViewItem item in servicesList.Items)
            {
                if (item.Tag == service)
                    servicesList.Items.Remove(item);
            }

            servicesList.EndUpdate();
        }

        void nsBrowser_DidFindService(NetServiceBrowser browser, NetService service, bool moreComing)
        {
            ListViewItem item = new ListViewItem(service.Name);
            item.Tag = service;

            servicesList.Items.Add(item);
            service.DidResolveService += new NetService.ServiceResolved(service_DidResolveService);
            service.ResolveWithTimeout(10);
        }

        void service_DidResolveService(NetService service)
        {
            MessageBox.Show(service.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nsBrowser.SearchForService("_monitor_control._tcp", "");
        }
    }
}