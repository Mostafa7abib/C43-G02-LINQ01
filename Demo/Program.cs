using static Demo.ListGenerator;
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
            ////1- Call "LINQ Operator" As Static Method Through "Enumerable" Class
            //List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 9 };
            //List<int> OddNumbers = Enumerable.Where(Numbers, N => N % 2 == 1).ToList();
            //foreach (var item in OddNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            ////2- Call "LINQ Operator" As Extension Method   
            //List<int> OddNumbers2 = Numbers.Where(N => N % 2 == 1).ToList();
            //foreach (var item in OddNumbers2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Query Syntax
            //var OddNumbers3 = from N in Numbers
            //                 where N % 2 == 1
            //                 select N;
            //foreach (var item in OddNumbers3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region Video 03 - LINQ Execution Ways
            #region Deferred Execution
            //// 1- Deferred Way 
            //List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 9 };
            //var Result = Numbers.Where(N => N % 2 == 1);
            //Numbers.AddRange(new int[] { 10, 11, 12, 13, 14, 15 });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Immediate Execution
            //// 2- Immediate Way
            //List<int> Numbers2 = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 9 };
            //var Result2 = Numbers2.Where(N => N % 2 == 1).ToList();
            //Numbers2.AddRange(new int[] { 10, 11, 12, 13, 14, 15 });
            //foreach (var item in Result2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region Video 04 - Data Setup
            //Console.WriteLine(ProductList[0]);
            #endregion

            #region Video 05 - Filteration [Restriction] Operators - Where
            #region Ex 01 - Get Element Out of Stock
            //1- Fluent Syntax
            var Result = ProductList.Where(P => P.UnitsInStock == 0);
            //2- Query Syntax
            Result = from P in ProductList
                     where P.UnitsInStock == 0                     
                     select P;
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region EX 02 - Get Elements in Stock && Category is Meat/Poultry
            //1- Fluent Syntax
            var Result2 = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");
            //2- Query Syntax
            Result2 = from P in ProductList
                      where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
                      select P;
            foreach (var item in Result2)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Ex 03 - Get Element out of stock in First 10 Elements
            //Indexed Where
            //1- Fluent Syntax - valid in it only
            var Result3 = ProductList.Where((P, I) => I < 10 && P.UnitsInStock == 0);
            foreach (var item in Result3)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion
        }
    }
}
