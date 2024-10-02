using Interview2024.InputClasses;
using Interview2024.Solutions;

namespace CombineCandleProblemTests
{
    public class Sol2_CombineCandleProblemTestCases
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var input = new CandleProblemInput(5, 2);
            var solver = new Sol2_Recursion();
            int value = solver.GetTotalBurnTime(input);
            Assert.That(value, Is.EqualTo(9));
        }

        [Test]
        public void Test2()
        {
            var input = new CandleProblemInput(9, 3);
            var solver = new Sol2_Recursion();
            int value = solver.GetTotalBurnTime(input);
            Assert.That(value, Is.EqualTo(13));
        }

        [Test]
        public void Test3()
        {
            var input = new CandleProblemInput(32, 4);
            var solver = new Sol2_Recursion();
            int value = solver.GetTotalBurnTime(input);
            Assert.That(value, Is.EqualTo(42));
        }

    }
}