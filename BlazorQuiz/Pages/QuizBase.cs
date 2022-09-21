using BlazorQuiz.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorQuiz.Pages
{
    public class QuizBase : ComponentBase
    {
        public List<Question> Questions { get; private set; } = new List<Question>();
        public int QuestionIndex { get; private set;} = 0;
        public int Score { get; private set; } = 0;

        protected override Task OnInitializedAsync()
        {
            LoadQuestions();
            return base.OnInitializedAsync();
        }

        public void Replay()
        {
            Score = 0;
            QuestionIndex = 0;
        }

        public void OptionSelected(string option)
        {
            if(option == Questions[QuestionIndex].CorrectAnswer)
            {
                Score++;
            }
            QuestionIndex++;
        }

        private void LoadQuestions()
        {
            Question q1 = new()
            {
                Content = "They don't think it be like it be..",
                Answers = new List<string>() { "For you", "So I do", "But it do" },
                CorrectAnswer = "But it do"
            };
            Question q2 = new()
            {
                Content = "I push my fingers..",
                Answers = new List<string>() { "Into a grapefruit", "Into my eyes", "Into my pocket" },
                CorrectAnswer = "Into my eyes"
            };
            Question q3 = new()
            {
                Content = "Where is the elephants foot?",
                Answers = new List<string>() { "On the elephants leg", "Ukraine", "Africa" },
                CorrectAnswer = "Ukraine"
            };
            Question q4 = new()
            {
                Content = "What is 10 plus 10",
                Answers = new List<string>() { "20", "1010", "Can't be done" },
                CorrectAnswer = "20"
            };
            Questions.AddRange(new List<Question>{ q1, q2, q3, q4 });
        }
    }
}
