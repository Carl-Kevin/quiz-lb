using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using App.Model;
using Microsoft.AspNet.SignalR;
using Win.App.Server.DataSource;

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
            //DataGridView.CheckForIllegalCrossThreadCalls = false;
            SetupQuiz();
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


        private void SetupQuiz()
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabControl = sender as TabControl;
            if (tabControl == null) return;
            var selectedIndex = tabControl.SelectedIndex + 1;
            switch (selectedIndex)
            {
                case 1:
                    EasyDataGrid.DataSource = ReloadData(selectedIndex);
                    break;
                case 2:
                    AverageDataGrid.DataSource = ReloadData(selectedIndex);
                    break;
                case 3:
                    //TODO: Bind the other difficulty level grid here
                    break;
            }

        }

        private List<Quiz> ReloadData(int difficultyLevel)
        {
            List<Quiz> result;
            using (var context = new QuizBeeEntities())
            {
                result = context.Quizes.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
            }

            return result;
        }


    }
}
