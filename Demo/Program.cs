namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 01 - What is the LINQ
            //List<int> Numbers = new List<int>(10) {1,2,3,4,5,6,7,9};
            //List<int> OddNumbers = Numbers.Where(N=> N % 2 != 0).ToList();
            //foreach (var item in OddNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Video 02 - LINQ Syntax
            #region Fluent Syntax
            //1- Call "LINQ Operator" As Static Method Through "Enumerable" Class
            List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 9 };
            List<int> OddNumbers = Enumerable.Where(Numbers, N => N % 2 == 1).ToList();
            foreach (var item in OddNumbers)
            {
                Console.WriteLine(item);
            }
            //2- Call "LINQ Operator" As Extension Method   
            List<int> OddNumbers2 = Numbers.Where(N => N % 2 == 1).ToList();
            foreach (var item in OddNumbers2)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Query Syntax
            var OddNumbers3 = from N in Numbers
                             where N % 2 == 1
                             select N;
            foreach (var item in OddNumbers3)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion
        }
    }
}
