namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        private Calculator _calculator;
        
        public UnitTest1()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        [DataRow(10,20,30)]
        public void AddTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            Assert.AreEqual(_calculator.Add(firstNumber, secondNumber), result);
        }


        [TestMethod]
        [DataRow(30, 20, 10)]
        public void SubTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            Assert.AreEqual(_calculator.Sub(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(2, 5, 10)]
        public void MuliplicationTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            Assert.AreEqual(_calculator.Multiply(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(10, 2, 5)]
        public void DivisionTwoElements_ShouldReturnRightResult(int firstNumber, int secondNumber, int result)
        {
            Assert.AreEqual(_calculator.Divide(firstNumber, secondNumber), result);
        }

        [TestMethod]
        [DataRow(-3, 2)]
        public void AdditionTwoElementsButOneNegative_ShouldReturnRightResult(int firstNumber, int secondNumber)
        {
            Assert.ThrowsException<ArgumentException>(() => _calculator.Add(firstNumber, secondNumber));
        }

        [TestMethod]
        [DataRow(4, 0)]
        public void DivideTwoElementsByZero_ShouldReturnRightResult(int firstNumber, int secondNumber)
        {
            Assert.ThrowsException<DivisionByZeroException>(() => _calculator.Divide(firstNumber, secondNumber));
        }

        [TestMethod]
        [DataRow(4, 0)]
        public void MultiplyTwoElementsByZero_ShouldReturnRightResult(int firstNumber, int secondNumber)
        {
            Assert.ThrowsException<ArgumentException>(() => _calculator.Multiply(firstNumber, secondNumber));
        }
    }
}