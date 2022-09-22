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
                Content = "Who plotted to blow up the House of Lords?",
                Answers = new List<string>() { "Guy Fieri", "Guy Fawkes", "Mr Walnut" },
                CorrectAnswer = "Guy Fawkes"
            };
            Question q2 = new()
            {
                Content = "What was candy corn originally called?",
                Answers = new List<string>() { "Chicken Feed", "Dog Eggs", "Goat Seed", "Mr Walnut" },
                CorrectAnswer = "Chicken Feed"
            };
            Question q3 = new()
            {
                Content = "What was the most jack o'lanterns on display at once?",
                Answers = new List<string>() { "30,581", "4", "8 billion" },
                CorrectAnswer = "80,581"
            };
            Question q4 = new()
            {
                Content = "When is Halloween?",
                Answers = new List<string>() { "Easter", "Every year", "Boctober" },
                CorrectAnswer = "Every year"
            };
            Questions.AddRange(new List<Question>{ q1, q2, q3, q4 });
        }
    }
}
