namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 01 - What is the LINQ
            List<int> Numbers = new List<int>(10) {1,2,3,4,5,6,7,9};
            List<int> OddNumbers = Numbers.Where(N=> N % 2 != 0).ToList();
            foreach (var item in OddNumbers)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
