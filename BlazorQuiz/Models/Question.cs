namespace BlazorQuiz.Models
{
    public class Question
    {
        public string Content { get; set; } = string.Empty;
        public IEnumerable<string> Answers { get; set; } = new List<string>();
        public string CorrectAnswer { get; set; } = string.Empty;
    }
}
