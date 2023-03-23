using System;

namespace SyntaxSuger2
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer = 88.9;
            string response;
            if (answer < 47)
            {
                response = answer + " is less than forty-seven";
            }
            else
            {
                response = answer + " greater than or equal to forty-seven";
            }
            Console.WriteLine(response);



            var answer2 = 6;
            var response2 = (answer2 < 9) ? $"{answer2} is less than forty-seven" : $"{answer2} is greater than forty-seven";

            Console.WriteLine(response2);


            var i = 1;
            var positiveMessage = (i > 0) ? "You are positive !" : "You are not positive. Hmm...";
            Console.WriteLine(positiveMessage);

            var j = 1;
            var positiveMessage2 = (j > 0) ? $" {j} is greater than 0  !" : $" {j} is less than 0.";
            Console.WriteLine(positiveMessage2);

          


        }
    }
}
