using System;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(50, PercentCalc(10, 5));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.NotEqual(50, PercentCalc(10, 5));
        }

        decimal PercentCalc(int count, int serviced)
        {
            if (count > 0)
            {
                decimal Perc = (serviced * 100) / count;
                return Perc;
            }
            else
            {
                return 0;
            }
        }
    }
}
