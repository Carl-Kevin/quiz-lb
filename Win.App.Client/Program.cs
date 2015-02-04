using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;

namespace Win.App.Client
{
    static class Program
    {

    

        /// <summary>
        /// The main entry point for the application.
        /// CHeck this URL for some sample and details
        /// https://code.msdn.microsoft.com/Using-SignalR-in-WinForms-f1ec847b
        /// https://github.com/SignalR/SignalR/wiki
        /// http://www.asp.net/signalr
        /// </summary>
        [STAThread]
        static void Main()
        {
          

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }








    }
}
