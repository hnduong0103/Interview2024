using Interview2024.InputClasses;
using Interview2024.Solutions;
using System.ComponentModel.DataAnnotations;

namespace Interview2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem: A candle finishes burning would leave a leftover. k leftovers can be combined to make a new candle");
            Console.WriteLine("You first have n candles. How many candles can you burn in total?");
            Console.WriteLine("Example: (n, k) -> (5, 2) = 9");
            Console.Write("Enter Num of Candles n = ");
            int numOfCandles = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate of combine k = ");
            int combineRate = Convert.ToInt32(Console.ReadLine());

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
                var solver = new Sol2_Recursion();
                Console.Write($"Total candles that you can burn: {solver.GetTotalBurnTime(input)}");
            }
        }
    }
}
