using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Model;
using Microsoft.Owin.Hosting;

namespace Win.App.Server
{
    static class Program
    {

        internal static Form1 MainForm { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// https://code.msdn.microsoft.com/Using-SignalR-in-WinForms-f1ec847b
        /// http://converter.telerik.com/
        /// </summary>
        [STAThread]
        static void Main()
        {


            var ipAddress = ConfigurationManager.AppSettings["ServerIpAddress"];
            var portNumber = ConfigurationManager.AppSettings["ServerPort"];

            var url = string.Format("http://{0}:{1}", ipAddress, portNumber);

            WebApp.Start<Startup>(url);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new Form1();

            Application.Run(MainForm);


        }
    }
}
