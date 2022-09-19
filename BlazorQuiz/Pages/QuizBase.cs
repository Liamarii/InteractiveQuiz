using BlazorQuiz.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorQuiz.Pages
{
    public class QuizBase : ComponentBase
    {
        public List<Question> Questions { get; set; } = new List<Question>();

        protected override Task OnInitializedAsync()
        {
            LoadQuestions();
            return base.OnInitializedAsync();
        }

        private void LoadQuestions()
        {
            Question q1 = new()
            {
                Content = "They don't think it be like it be..",
                Answers = new List<string>() { "But do?", "So I do", "But it do" },
                Answer = "But it do"
            };
            Question q2 = new()
            {
                Content = "I push my fingers..",
                Answers = new List<string>() { "Into a grapefruit", "Into my eyes", "Into my pocket" },
                Answer = "Into my eyes"
            };
            Question q3 = new()
            {
                Content = "Where is the elephants foot?",
                Answers = new List<string>() { "On the elephants leg", "Russia", "Africa" },
                Answer = "Russia"
            };
            Questions.AddRange(new List<Question>{ q1, q2, q3 });

        }
    }
}
