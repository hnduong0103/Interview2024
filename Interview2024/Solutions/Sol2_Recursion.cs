using Interview2024.InputClasses;

namespace Interview2024.Solutions
{
    public class Sol2_Recursion : ISolutionCandleProblem
    {
        private int leftover = 0;
        public int GetTotalBurnTime(CandleProblemInput input)
        {
            int numberOfCandles = input.NumberOfCandles;
            int combineRate = input.CombineRate;
            if (numberOfCandles == 0)
            {
                return 0;
            }

            int totalBurnTime = numberOfCandles;
            leftover += numberOfCandles;

            numberOfCandles = leftover / combineRate;
            leftover = leftover % combineRate;

            return totalBurnTime + GetTotalBurnTime(new CandleProblemInput(numberOfCandles, combineRate));
        }
    }
}
