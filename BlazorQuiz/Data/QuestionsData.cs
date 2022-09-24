using BlazorQuiz.Models;

namespace BlazorQuiz.Data
{
    public class QuestionsData
    {
        public static Tuple<string, List<Question>> GetQuestionSet(QuestionSet questionSet)
        {
            return questionSet switch
            {
                _ => HalloweenQuestionSet()
            };
        }

        public enum QuestionSet
        {
            Halloween
        }

        private static Tuple<string, List<Question>> HalloweenQuestionSet()
        {
            return Tuple.Create("🎃 Halloween quiz", new List<Question>()
            {
                new()
                {
                    Content = "Who plotted to blow up the House of Lords?",
                    Answers = new List<string>() { "Guy Fieri", "Guy Fawkes", "Mr Walnut" },
                    CorrectAnswer = "Guy Fawkes"
                },
                new()
                {
                    Content = "What was candy corn originally called?",
                    Answers = new List<string>() { "Chicken Feed", "Dog Eggs", "Goat Seed", "Mr Walnut" },
                    CorrectAnswer = "Chicken Feed"
                },
                new()
                {
                    Content = "What was the most jack o'lanterns on display at once?",
                    Answers = new List<string>() { "30,581", "4", "8 billion" },
                    CorrectAnswer = "80,581"
                },
                new()
                {
                    Content = "When is Halloween?",
                    Answers = new List<string>() { "Easter", "Every year", "Boctober" },
                    CorrectAnswer = "Every year"
                }
            });
        }
    };
}
