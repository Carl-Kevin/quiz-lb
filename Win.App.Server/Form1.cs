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
            DataGridView.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private QuestionManager _questionManager;
        public QuestionManager QuestionManager
        {
            get
            {
                if (_questionManager == null)
                {
                    _questionManager = new QuestionManager();
                }

                return _questionManager;
            }
        }



        private ScoreManager _scoreManager;
        public ScoreManager ScoreManager
        {
            get
            {
                if (_scoreManager == null)
                {
                    _scoreManager = new ScoreManager();
                }

                return _scoreManager;
            }
            set { _scoreManager = value; }
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
            EasyDataGrid.DataSource = QuestionManager.GetQuizesByDifficulty(1);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabControl = sender as TabControl;
            if (tabControl == null) return;
            var selectedIndex = tabControl.SelectedIndex + 1;
            switch (selectedIndex)
            {
                case 1:
                    EasyDataGrid.DataSource = QuestionManager.GetQuizesByDifficulty(selectedIndex);
                    break;
                case 2:
                    AverageDataGrid.DataSource = QuestionManager.GetQuizesByDifficulty(selectedIndex);
                    break;
                case 3:
                    //TODO: Bind the other difficulty level grid here
                    break;
            }

        }

       
        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid == null) return;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var quiz = grid.Rows[e.RowIndex].DataBoundItem as Quiz;
                HubContext.Clients.All.DisplayQuestion(quiz);
            }

        }


    }
}
