using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region Q1 -  Find all products that are out of stock.
            ////Fluent Syntax
            //var OutOfStock = ProductList.Where(P => P.UnitsInStock == 0);
            ////Query Syntax
            //OutOfStock = from P in ProductList
            //             where P.UnitsInStock == 0
            //             select P;
            //foreach(var item in OutOfStock)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2 - Find all products that are in stock and cost more than 3.00 per unit.
            ////Fluent Syntax
            //var InStockAndCostMoreThan3 = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00m);
            ////Query Syntax
            //InStockAndCostMoreThan3 = from P in ProductList
            //                          where P.UnitsInStock > 0 && P.UnitPrice > 3.00m
            //                          select P;
            //foreach(var item in InStockAndCostMoreThan3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3 - Returns digits whose name is shorter than their value.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //Fluent Syntax //valid here only
            var NameShorterThanValue = Arr.Where((P, I) => P.Length < I);
            foreach(var item in NameShorterThanValue)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion
        }
    }
}
