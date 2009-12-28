using System;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using ZeroconfService;
using System.Net;

namespace TRMS.CarouselMonitorControl
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Register with bonjour
            NetService service = new NetService("", "_monitor_control._tcp", Environment.MachineName, 26908);
            service.Publish();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CarouselMonitorControl());

            service.Stop();
        }
    }
}