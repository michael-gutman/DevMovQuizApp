using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devMovQuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            string attempt;
            string[] questions = 
                {
                "Q1) Carl Lewis holds the record for most individual gold medals at the Olympics.",
                "Q2) The Academy Awards are annually the most-watched, single telecast in the United States.",
                "Q3) Russia has the largest area of any country in the world.",
                "Q4) The 'funny bone' is really a bone.",
                "Q5) The Enlightenment was an intellectual movement that celebrated religious faith over reason."
                };
            string[] answers = { "false", "false", "true", "false", "false" };
            for (int i =0; i<5; i++)
            {
                Console.WriteLine(questions[i]);
                attempt = Console.ReadLine();
                if (attempt.Equals(answers[i], StringComparison.InvariantCultureIgnoreCase))
                {

                } else
                {

                }
            };
        }
    }
}
