using NUnit.Framework;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Additional_MustReturnCorrectValue() 
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(2, 2) == 4);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(1, 5) == -4);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(5, 0) == 0);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(5, 1) == 5);
        }
    }
}