namespace TestProject1
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public int Add(int FirstNumber, int SecondNumber)
        {
            if (FirstNumber < 0 || SecondNumber < 0)
                throw new ArgumentException("Ca doit etre positif mon pti gars");
            return FirstNumber + SecondNumber;
        }

        public int Sub(int FirstNumber, int SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }

        public int Multiply(int FirstNumber, int SecondNumber)
        {
            if (FirstNumber == 0 || SecondNumber == 0)
                throw new ArgumentException("Nombre égal a zéro");
            return FirstNumber * SecondNumber;
        }

        public int Divide(int FirstNumber, int SecondNumber)
        {
            if (SecondNumber == 0)
                throw new DivisionByZeroException();
            return FirstNumber / SecondNumber;
        }
    }
}