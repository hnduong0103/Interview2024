using Interview2024.InputClasses;
using Interview2024.Solutions;
using System.ComponentModel.DataAnnotations;

namespace Interview2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instruction
            Console.WriteLine("Problem: A candle finishes burning would leave a leftover. k leftovers can be combined to make a new candle");
            Console.WriteLine("You first have n candles. How many candles can you burn in total?");
            Console.WriteLine("Example: (n, k) -> (5, 2) = 9");

            //Get input
            Console.Write("Enter Num of Candles n = ");
            int numOfCandles;
            int combineRate;
            while (!int.TryParse(Console.ReadLine(), out numOfCandles))
            {
                Console.WriteLine("Input must be integer");
                Console.Write("Retry enter Num of Candles n = ");
            }
           
            Console.Write("Enter Rate of combine k = ");
            while (!int.TryParse(Console.ReadLine(), out combineRate))
            {
                Console.WriteLine("Input must be integer");
                Console.Write("Retry enter Combine rate n = ");
            }

            //Validate
            var input = new CandleProblemInput(numOfCandles, combineRate);
            var context = new ValidationContext(input, null, null);
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(input, context, validationResults, true);
            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    Console.WriteLine($"{validationResult.ErrorMessage} Proper range between {ProblemConfig.MIN_NUM} and {ProblemConfig.MAX_NUM}");
                }
            }
            else
            {
                //Compute and print
                var solver = new Sol2_Recursion();
                Console.Write($"Total candles that you can burn: {solver.GetTotalBurnTime(input)}");
            }
        }
    }
}
