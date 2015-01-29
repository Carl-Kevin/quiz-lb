using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;
using App.Model;
using Microsoft.AspNet.SignalR.Client;
using System.Threading.Tasks;

namespace Win.App.Client
{
    public partial class Form1 : Form
    {
        string timeCont;

        private string _userName;
        public string UserName
        {
            get
            {
                if (_userName == null)
                {
                    _userName = ConfigurationManager.AppSettings["UserName"];
                }

                return _userName;
            }

        }




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.QuizHubProxy.On<Quiz>("DisplayQuestion", (quiz) => this.Invoke((Action)(() => DisplayQuestion(quiz))));
            CorrectLabel.Visible = false;
        }

        public void DisplayQuestion(Quiz obj)
        {
            QuestionLabel.Text = obj.Question;
            radioButton1.Text = obj.Answer1.Value;
            radioButton2.Text = obj.Answer2.Value;
            radioButton3.Text = obj.Answer3.Value;
            radioButton4.Text = obj.Answer4.Value;
            timeCont = obj.Time;
            CorrectLabel.Text = obj.C_Answer.Value;

            //On the display of question set the timer on
            SetTimer(true);
        }

        #region Setup Timer

        private int _timeleft;

        private Timer _questionTimer;
        public Timer QuestionTimer
        {
            get
            {
                if (_questionTimer == null)
                {
                    var container = this.Container;
                    if (container != null)
                        _questionTimer = new Timer(container);
                    else
                        _questionTimer = new Timer();

                }
                return _questionTimer;
            }
            set { _questionTimer = value; }
        }

        private void SetTimer(bool isTimerOn)
        {
            QuestionTimer.Interval = 1000;
            QuestionTimer.Tick -= Timer1OnTick;
            QuestionTimer.Tick += Timer1OnTick;

            if (isTimerOn)
            {
                QuestionTimer.Enabled = true;
                QuestionTimer.Start();
                //set the time left as default value
                _timeleft = Convert.ToInt32(timeCont);
            }
            else
            {
                QuestionTimer.Enabled = false;
                QuestionTimer.Stop();
            }

        }

        private void Timer1OnTick(object sender, EventArgs eventArgs)
        {
            //because the time can happen so fast, 
            //some hardware that are slow cannot determine if this already happen
            //so we made and ultimate catch that if is less than or equal to zero let the time stop
            //if we catch it only to zero, it will happen once, where as of we use less than it "might" happen several times
            if (_timeleft <= 0)
            {

                QuestionTimer.Stop();
                _timeleft = 0;
                TimerLabel.Text = string.Format("Time Left: {0}", _timeleft);
                //TODO: if the timer stops then do something on the questions
            }
            else
            {
                TimerLabel.Text = string.Format("Time Left: {0}", _timeleft);
                _timeleft = _timeleft - 1;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            var quiz = new Quiz()
            {
                Question = QuestionLabel.Text,
                C_Answer = new Choice() { Value = CorrectLabel.Text },
            };


            if (radioButton1.Checked)
            {
                quiz.Answer1 = new Choice() { Value = radioButton1.Text };
            }
            else if (radioButton2.Checked)
            {
                quiz.Answer2 = new Choice() { Value = radioButton2.Text };

            }
            else if (radioButton3.Checked)
            {
                quiz.Answer3 = new Choice() { Value = radioButton3.Text };

            }
            else if (radioButton4.Checked)
            {
                quiz.Answer4 = new Choice() { Value = radioButton4.Text };

            }


            Program.QuizHubProxy.Invoke("QuestionAnswered", quiz, UserName);

        }

    }
}
