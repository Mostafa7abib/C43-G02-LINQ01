using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region Q1 -  Find all products that are out of stock.
            //Fluent Syntax
            var OutOfStock = ProductList.Where(P => P.UnitsInStock == 0);
            //Query Syntax
            OutOfStock = from P in ProductList
                         where P.UnitsInStock == 0
                         select P;
            foreach(var item in OutOfStock)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion
        }
    }
}
