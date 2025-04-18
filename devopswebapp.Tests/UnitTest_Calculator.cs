using System;
using Xunit;
using devopswebapp.Models;

namespace devopswebapp.Tests
{
    public class UnitTest_Calculator
    {
        private double valueOne = 10;        
        private double valueTwo = 6;
        private double knownTotal = 16;
        public UnitTest_Calculator()
        {}
        
        [Fact]
        public void TestCalculator()
        {
            Calculation calc = new Calculation();
            var totalValue = calc.AddTwoValues(valueOne, valueTwo);
            Assert.Equal(totalValue, knownTotal);
        }
    }
}
