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

        public static IHubProxy QuizHubProxy;

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
            StartConnection();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }



        public static async Task StartConnection()
        {

            var ipAddress = ConfigurationManager.AppSettings["ServerIpAddress"];
            var portNumber = ConfigurationManager.AppSettings["ServerPort"];
            string userName = ConfigurationManager.AppSettings["UserName"];
            var querystringData = new Dictionary<string, string> { { "user_name", userName } };

            var url = string.Format("http://{0}:{1}", ipAddress, portNumber);

            var hubConnection = new HubConnection(url, querystringData);
            QuizHubProxy = hubConnection.CreateHubProxy("QuizHub");

            await hubConnection.Start();


        }





    }
}
