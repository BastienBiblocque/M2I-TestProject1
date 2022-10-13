namespace TestProject1
{
    [Serializable]
    internal class DivisionByZeroException : Exception
    {
        public DivisionByZeroException()
        : base(String.Format("Divise par zero"))
        {

        }
    }
}
