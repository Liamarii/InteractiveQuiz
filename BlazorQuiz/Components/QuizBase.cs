using BlazorQuiz.Data;
using BlazorQuiz.Models;
using Microsoft.AspNetCore.Components;
using static BlazorQuiz.Data.QuestionsData;

namespace BlazorQuiz.Pages
{
    public class QuizBase : ComponentBase
    {
        public List<Question> Questions { get; private set; } = new List<Question>();
        public string? Title { get; private set; }
        public int QuestionIndex { get; private set; } = 0;

        public bool SetSelected { get; set; } = false;

        private int _score = 0;

        public void SetHalloweenQuestionSet(string questionSet)
        {
            Tuple<string, List<Question>>? questions = GetQuestionSet(questionSet: QuestionSet.Halloween);
            Title = questions.Item1;
            Questions = questions.Item2;
        }

        public void SetChristmasQuestionSet(string questionSet)
        {
            Tuple<string, List<Question>>? questions = GetQuestionSet(questionSet: QuestionSet.Christmas);
            Title = questions.Item1;
            Questions = questions.Item2;
        }
        public void SetMiscellaneosQuestionSet(string questionSet)
        {
            Tuple<string, List<Question>>? questions = GetQuestionSet(questionSet: QuestionSet.Miscellaneous);
            Title = questions.Item1;
            Questions = questions.Item2;
        }

        public void Restart()
        {
            _score = 0;
            QuestionIndex = 0;
            Questions = new List<Question>();
        }

        public string ResultResponse()
        {
            if (_score == Questions.Count)
            {
                return "Perfect score!";
            }
            if (_score > Questions.Count / 2)
            {
                return $"You got {_score} of {Questions.Count} right";
            }
            return $"Your small brain only scored {_score}";
        }

        public void SelectOption(string option)
        {
            if (option == Questions[QuestionIndex].CorrectAnswer)
            {
                _score++;
            }
            QuestionIndex++;
        }
    }
}
