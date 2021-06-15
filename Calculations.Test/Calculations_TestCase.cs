using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Test
{ 
    public class CalculatorFixture 
    {
        public Calculator Calc => new Calculator();      
    }

    public class Calculations_TestCase : IClassFixture<CalculatorFixture>, IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream _memoryStream;

        public Calculations_TestCase(ITestOutputHelper testOutputHelper,CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            _memoryStream = new MemoryStream();

            _testOutputHelper.WriteLine("Constructor");
        }

        [Fact]
        [Trait("Category", "Sum")]
        public void AddGivenTwoIntValues_ReturnInt()
        {
            _testOutputHelper.WriteLine("AddGivenTwoIntValues_ReturnInt");
            //var calc = new Calculator();
            var calc = _calculatorFixture.Calc;
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        [Trait("Category", "Okan")]
        public void AddGivenTwoIntValues_ReturnDouble()
        {
            _testOutputHelper.WriteLine("AddGivenTwoIntValues_ReturnDouble starting at {0}",DateTime.Now);
            //var calc = new Calculator();
            var calc = _calculatorFixture.Calc;
            _testOutputHelper.WriteLine("calc atanmasý yapýldý starting at {0}", DateTime.Now);
            var result = calc.Add_double(1.53, 2.55);
            _testOutputHelper.WriteLine("result donusu saglandi at {0}", DateTime.Now);
            Assert.Equal(4.08, result,1);
            _testOutputHelper.WriteLine("test sonlandi {0}", DateTime.Now);
        }

        [Fact]
        [Trait("Category", "Sum")]
        public void Subtraction_TestCase()
        {
            _testOutputHelper.WriteLine("Subtraction_TestCase");
            //var calc = new Calculator();
            //var result = calc.Subtraction(3, 2);
            var result = _calculatorFixture.Calc.Subtraction(3, 2);
            Assert.Equal(1, result);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboNumber_TestCase()
        {
            _testOutputHelper.WriteLine("FiboNumber_TestCase");
            //var calc= new Calculator();
            //Assert.All(calc.FiboNumbers, n => Assert.NotEqual(21, n));
            //Assert.All(calc.FiboNumbers, n => Assert.Equal(13, n));
            //Assert.Contains(13, calc.FiboNumbers);
            Assert.Contains(13, _calculatorFixture.Calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category","Fibo")]
        public void FiboNumber_CheckCollection_TestCase()
        {
            _testOutputHelper.WriteLine("FiboNumber_CheckCollection_TestCase.Test starting at {0}", DateTime.Now);           
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8,13 };
            _testOutputHelper.WriteLine("FiboNumber_CheckCollection_TestCase");
            //var calc = new Calculator();
            var calc = _calculatorFixture.Calc;
            //Assert.All(calc.FiboNumbers, n => Assert.NotEqual(21, n));
            //Assert.All(calc.FiboNumbers, n => Assert.Equal(13, n));
            //Assert.Contains(13, calc.FiboNumbers);
            Assert.Equal(expectedCollection, calc.FiboNumbers);
        }

        public void Dispose()
        {
            _memoryStream.Close();
        }
    }
}
