using System.ComponentModel.DataAnnotations;

namespace Interview2024.InputClasses
{
    public class CandleProblemInput
    {
        public CandleProblemInput(int numberOfCandles, int combineRate) 
        {
            NumberOfCandles = numberOfCandles;
            CombineRate = combineRate;
        }

        [Range(ProblemConfig.MIN_NUM, ProblemConfig.MAX_NUM, ErrorMessage = "Number of candles is out of range.")]
        public int NumberOfCandles { get; set; }

        [Range(ProblemConfig.MIN_NUM, ProblemConfig.MAX_NUM, ErrorMessage = "Rate is out of range.")]
        public int CombineRate { get; set; }
    }
}
