using System;
using System.Windows.Forms;
using App.Model;
using Microsoft.AspNet.SignalR;

namespace Win.App.Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SetupQuiz();
        }

         
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


        public void UpdateAndReloadScore(string  userName, int pointsAdded)
        {
            ScoreManager.UpdateScore(userName, pointsAdded);
            ContestantScoreDataGrid.DataSource = ScoreManager.GetContestantScores();
        }

        private void SetupQuiz()
        {
            EasyDataGrid.DataSource = QuestionManager.GetQuizesByDifficulty(1);
            ContestantScoreDataGrid.DataSource = ScoreManager.GetContestantScores();
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
