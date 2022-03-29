using Calculator;
using Xunit;

namespace CalculatorUnitTests
{
    public class MathOperationsUnitTest
    {
        private readonly MathOperations _mathOperations;
        private double _value1 = 0;
        private double _value2 = 0;
        private double _expected = 0;

        public MathOperationsUnitTest()
        {
            _mathOperations = new MathOperations();
        }

        [Fact]
        public void A00_Add_Numbers_Success()
        {
            //Arrange
            _value1 = 2;
            _value2 = 3;
            _expected = 5;
            //Act
            double result = _mathOperations.Sum(_value1, _value2);

            //Assert
            Assert.Equal(_expected, result);

        }

        [Fact]
        public void A01_Subtract_Numbers_Success()
        {
            //Arrange
            _value1 = 5;
            _value2 = 3;
            _expected = 2;
            //Act
            double result = _mathOperations.Subtract(_value1, _value2);

            //Assert
            Assert.Equal(_expected, result);

        }
        [Fact]
        public void A02_Multiply_Numbers_Success()
        {
            //Arrange
            _value1 = 2;
            _value2 = 3;
            _expected = 6;
            //Act
            double result = _mathOperations.Multiply(_value1, _value2);

            //Assert
            Assert.Equal(_expected, result);

        }
        [Fact]
        public void A03_Divide_Numbers_Success()
        {
            //Arrange
            _value1 = 6;
            _value2 = 3;
            _expected = 2;
            //Act
            double result = _mathOperations.Divide(_value1, _value2);

            //Assert
            Assert.Equal(_expected, result);

        }

    }
}