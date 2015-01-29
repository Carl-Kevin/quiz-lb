namespace App.Model
{
    public class Quiz
    {
        public string Question { get; set; }
        public Choice Answer1 { get; set; }
        public Choice Answer2 { get; set; }
        public Choice Answer3 { get; set; }
        public Choice Answer4 { get; set; }
        public string Time { get; set; }
        public Choice C_Answer { get; set; }
    }
}