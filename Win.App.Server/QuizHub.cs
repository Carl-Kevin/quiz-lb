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
            Choice answer = null;
            Choice answer1 = null;

            if (quiz.Answer1 != null) answer = quiz.Answer1;
            if (quiz.Answer2 != null) answer = quiz.Answer2;
            if (quiz.Answer3 != null) answer = quiz.Answer3;
            if (quiz.Answer4 != null) answer = quiz.Answer4;
            if (quiz.CorrectAnswer != null) answer1 = quiz.CorrectAnswer;

            if (answer.Value == answer1.Value)
            {
                Program.MainForm.CorrectPoint++;
                //Take note: the correct point should be set to correct person
                //this is a simultaneous operation and person1 and person2 might send the answer 
                //almost the same time and the server should handle it
                //Program.MainForm.label1.Text = Program.MainForm.CorrectPoint.ToString();
                Program.MainForm.dataGridView1.Rows[0].Cells[1].Value = Program.MainForm.CorrectPoint.ToString();
            }


            var message = string.Format("{0} from {1} correct: {2}", answer.Value, userName, answer1.Value);
            Program.MainForm.WriteToLog(message);
            
            
        }
        
        
    }
}