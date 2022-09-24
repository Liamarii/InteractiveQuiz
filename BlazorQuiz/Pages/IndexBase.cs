using BlazorQuiz.Models;
using Microsoft.AspNetCore.Components;
using static BlazorQuiz.Data.QuestionsData;

namespace BlazorQuiz.Pages
{
    public class IndexBase : ComponentBase
    {
        public List<Question> Questions { get; private init; }
        
        public string Title {get; private init; }
        
        public int QuestionIndex { get; private set; } = 0;
        
        private int _score = 0;

        public IndexBase()
        {
            Tuple<string, List<Question>>? questionSet = GetQuestionSet(QuestionSet.Halloween);
            Title = questionSet.Item1;
            Questions = questionSet.Item2;
        }

        public void Restart()
        {
            _score = 0;
            QuestionIndex = 0;
        }

        public string ResultResponse()
        {
            if(_score == Questions.Count)
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
            if(option == Questions[QuestionIndex].CorrectAnswer)
            {
                _score++;
            }
            QuestionIndex++;
        }
    }
}
