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
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ////Fluent Syntax //valid here only
            //var NameShorterThanValue = Arr.Where((P, I) => P.Length < I);
            //foreach(var item in NameShorterThanValue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ - Ordering Operators
            #region Q1- Sort a list of products by name
            ////Fluent Syntax
            //var SortByName = ProductList.OrderBy(P => P.ProductName);
            ////Query Syntax
            //SortByName = from P in ProductList
            //             orderby P.ProductName
            //             select P;
            //foreach(var item in SortByName)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region  Q2- Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ////Fluent Syntax
            //var CaseInsensitiveSort = Arr.OrderBy(P => P, StringComparer.OrdinalIgnoreCase);
            ////Query Syntax
            //CaseInsensitiveSort = from P in Arr
            //                      orderby StringComparer.OrdinalIgnoreCase
            //                      select P;
            //foreach (var item in CaseInsensitiveSort)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3- Sort a list of products by units in stock from highest to lowest.
            ////Fluent Syntax
            //var SortByUnitsInStock = ProductList.OrderByDescending(P => P.UnitsInStock);
            ////Query Syntax
            //SortByUnitsInStock = from P in ProductList
            //                     orderby P.UnitsInStock descending
            //                     select P;
            //foreach (var item in SortByUnitsInStock)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q4- Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ////Fluent Syntax
            //var SortByLengthAndName = Arr.OrderBy(P => P.Length).ThenBy(P => P);
            ////Query Syntax
            //SortByLengthAndName = from P in Arr
            //                      orderby P.Length, P
            //                      select P;
            //foreach (var item in SortByLengthAndName)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q5- Sort first by word length and then by a case-insensitive sort of the words in an array.
            ////Fluent Syntax
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var SortByLengthAndName = words.OrderBy(P => P.Length).ThenBy(P=>P);
            ////Query Syntax
            //SortByLengthAndName = from P in words
            //                      orderby P.Length, P
            //                      select P;
            //foreach (var item in SortByLengthAndName)
            //{
            //    Console.WriteLine(item);
            //}   
            #endregion
            #region Q6- Sort a list of products, first by category, and then by unit price, from highest to lowest.
            ////Fluent Syntax
            //var SortByCategoryAndPrice = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            ////Query Syntax
            //SortByCategoryAndPrice = from P in ProductList
            //                         orderby P.Category, P.UnitPrice descending
            //                         select P;
            //foreach (var item in SortByCategoryAndPrice)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q7-  Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ////Fluent Syntax
            //var SortByLengthAndNameDes = Arr.OrderBy(P => P.Length).ThenByDescending(P => P);
            ////Query Syntax
            //SortByLengthAndNameDes = from P in Arr
            //                         orderby P.Length, P descending
            //                         select P;
            //foreach(var item in SortByLengthAndNameDes)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q8- Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ////Fluent Syntax
            //var SecondLetterI = Arr.Where(P => P[1] == 'i').Reverse();
            ////Query Syntax
            //SecondLetterI = (from P in Arr
            //                where P[1] == 'i'
            //                select P).Reverse();
            //foreach (var item in SecondLetterI)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region LINQ – Transformation Operators
            #region Q1- Return a sequence of just the names of a list of products.
            ////Fluent Syntax
            //var NamesOfProducts = ProductList.Select(P => P.ProductName);
            ////Query Syntax
            //NamesOfProducts = from P in ProductList
            //                  select P.ProductName;
            //foreach(var item in NamesOfProducts)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2- Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //Fluent Syntax
            var UpperAndLower = words.Select(P => new { Upper = P.ToUpper(), Lower = P.ToLower() });
            //Query Syntax
            UpperAndLower = from P in words
                            select new { Upper = P.ToUpper(), Lower = P.ToLower() };
            foreach (var item in UpperAndLower)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion
        }
    }
}
