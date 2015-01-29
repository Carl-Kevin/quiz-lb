using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR;

namespace Win.App.Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridView.CheckForIllegalCrossThreadCalls = false;
        }


        

        public int CorrectPoint { get; set; }
 
	

        private IHubContext _hubContext;
        public IHubContext HubContext
        {
            get
            {
                if (_hubContext == null)
                {
                    _hubContext = GlobalHost.ConnectionManager.GetHubContext<QuizHub>();
                }

                return _hubContext;
            }
        }

        private QuestionFactory _questionFactory;
        public QuestionFactory QuestionFactory
        {
            get
            {
                if (_questionFactory == null)
                {
                    _questionFactory = new QuestionFactory();
                }

                return _questionFactory;
            }
        }


        public void WriteToLog(string logMessage)
        {
            if (listView1.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    WriteToLog(logMessage)
                ));
                return;
            }
            listView1.Items.Add(logMessage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var quiz = QuestionFactory.GetRandomItem();
            var quiz = QuestionFactory.GetNextItem();
            HubContext.Clients.All.DisplayQuestion(quiz);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            var quiz = QuestionFactory.GetPreviousItem();
            HubContext.Clients.All.DisplayQuestion(quiz);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var quiz = QuestionFactory.GetNextItem();
            HubContext.Clients.All.DisplayQuestion(quiz);
        }



    }
}
