using BlazorQuiz.Models;

namespace BlazorQuiz.Data
{
    public static class QuestionsData
    {
        public static Tuple<string, List<Question>> GetQuestionSet(QuestionSet questionSet)
        {
            return questionSet switch
            {
                QuestionSet.Halloween => HalloweenQuestionSet(),
                QuestionSet.Christmas => ChristmasQuestionSet(),
                QuestionSet.Miscellaneous => MiscellaneousQuestionSet(),
                _ => throw new NotImplementedException()
            };
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
                    CorrectAnswer = "30,581"
                },
                new()
                {
                    Content = "When is Halloween?",
                    Answers = new List<string>() { "Easter", "Every year", "Boctober" },
                    CorrectAnswer = "Every year"
                }
            });
        }

        private static Tuple<string, List<Question>> ChristmasQuestionSet()
        {
            return Tuple.Create("🎅 Christmas quiz", new List<Question>()
            {
                new()
                {
                    Content = "Which is not a reindeer name?",
                    Answers = new List<string>() { "Prancer", "Vixen", "Donner","Comet","Ross Kemp" },
                    CorrectAnswer = "Ross Kemp"
                }
            });
        }

        private static Tuple<string, List<Question>> MiscellaneousQuestionSet()
        {
            return Tuple.Create("‍🥨 Miscellaneous quiz", new List<Question>()
            {
                new()
                {
                    Content = "Where is the elephant foot?",
                    Answers = new List<string>() { "Africa", "On the elephant", "Ukraine" },
                    CorrectAnswer = "Ukraine"
                },
                new()
                {
                    Content = "Where do the most rainbows occur?",
                    Answers = new List<string>() { "Hawaii", "Florida", "Norway" },
                    CorrectAnswer = "Hawaii"
                }
            });
        }
    };

    public enum QuestionSet
    {
        Halloween,
        Christmas,
        Miscellaneous
    }
}
