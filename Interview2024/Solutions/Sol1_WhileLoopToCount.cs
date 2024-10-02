using Interview2024.InputClasses;

namespace Interview2024.Solutions
{
    public class Sol1_WhileLoopToCount : ISolutionCandleProblem
    {
        public int GetTotalBurnTime(CandleProblemInput input)
        {
            int numberOfCandles = input.NumberOfCandles;
            int combineRate = input.CombineRate;
            int totalBurnTime = 0;
            int leftover = 0;

            while (numberOfCandles > 0)
            {
                totalBurnTime += numberOfCandles;
                leftover += numberOfCandles;

                numberOfCandles = leftover / combineRate;
                leftover = leftover % combineRate; 
            }

            return totalBurnTime;
        }
    }
}
