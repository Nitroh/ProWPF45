using System;

namespace EightBall
{
    public class AnswerGenerator
    {
        private static readonly string[] Answers =
        {
            "Ask Again later",
            "Can Not Predict Now",
            "Without a Doubt",
            "Is Decidely So",
            "Concentrate and Ask Again",
            "My Sources Say No",
            "Yes, Definitely",
            "Don't Count On It",
            "Signs Point to Yes",
            "Better Not Tell You Now",
            "Outlook Not So Good",
            "Most Likely",
            "Very Doubtful",
            "As I See It, Yes",
            "My Reply is No",
            "It Is Certain",
            "Yes","You May Rely On It",
            "Outlook Good",
            "Reply Hazy Try Again"
        };

        public string GetRandomAnswer(string question)
        {
            return Answers[new Random().Next(0, Answers.Length)];
        }
    }
}