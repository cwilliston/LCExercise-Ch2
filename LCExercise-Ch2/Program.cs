using System;

namespace LCExercise_Ch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gas;
            string input;
            double mpg;


            Console.WriteLine("What is the number of the miles driven?");
            input = Console.ReadLine();
            miles = double.Parse(input);
            Console.WriteLine("What is the amount of gas used?");
            input = Console.ReadLine();
            gas = double.Parse(input);
            mpg = miles / gas;
            Console.WriteLine("Your miles per gallon is " + mpg);


            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string aliceInput;
            
            Console.WriteLine(alice);
            Console.WriteLine("What term would you like to search for?");
            aliceInput = Console.ReadLine();
            aliceInput = aliceInput.ToLower().Trim();
            string aliceLower = alice.ToLower();


            if (aliceLower.IndexOf(aliceInput, 0) != -1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
