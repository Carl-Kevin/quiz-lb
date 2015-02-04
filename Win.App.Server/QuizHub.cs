using System;
using System.Threading.Tasks;
using App.Model;
using Microsoft.AspNet.SignalR;


namespace Win.App.Server
{
    public class QuizHub : Hub
    {
        int _points = 0;

        public override Task OnConnected()
        {
            var userName = Context.QueryString["user_name"];

            var message = string.Format("Connected user : {0}", userName);
            Program.MainForm.WriteToLog(message);
            Program.MainForm.dataGridView1.Rows.Add(userName.ToString());
            return base.OnConnected();
        }



        public void QuestionAnswered(Quiz quiz, string userName)
        {

            var answer = string.Empty;
            var correctAnswer = string.Empty;
            if (!string.IsNullOrEmpty(quiz.Option1)) answer = quiz.Option1;
            if (!string.IsNullOrEmpty(quiz.Option2)) answer = quiz.Option2;
            if (!string.IsNullOrEmpty(quiz.Option3)) answer = quiz.Option3;
            if (!string.IsNullOrEmpty(quiz.Option4)) answer = quiz.Option4;

            if (!string.IsNullOrEmpty(quiz.AnswerKey)) correctAnswer = quiz.AnswerKey;

            if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Program.MainForm.CorrectPoint++;
                //Take note: the correct point should be set to correct person
                //this is a simultaneous operation and person1 and person2 might send the answer 
                //almost the same time and the server should handle it
                //Program.MainForm.label1.Text = Program.MainForm.CorrectPoint.ToString();
                Program.MainForm.dataGridView1.Rows[0].Cells[1].Value = Program.MainForm.CorrectPoint.ToString();
            }


            var message = string.Format("{0} from {1} correct: {2}", answer, userName, correctAnswer);
            Program.MainForm.WriteToLog(message);


        }


    }
}