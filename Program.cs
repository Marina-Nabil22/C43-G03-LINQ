using Session.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using System.Xml.Linq;
using static Session.ListGenerator;
using static System.Net.Mime.MediaTypeNames;

namespace Session
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit
            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Where((X, I) => X.Length < I);
            //foreach ( var X in Result)
            //{
            //    Console.WriteLine(X);
            //} 
            #endregion
            #endregion

            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 
            //var Result = ProductList.First(P=>P.UnitsInStock==0);
            //Console.WriteLine(Result);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(Result?.ProductName ?? "Not Found");
            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int [] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Res=Arr.Where(P=>P >5).ElementAt(1);
            //Console.WriteLine(Res);

            #endregion



            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Res=Arr.Count(I => I % 2 == 1);
            //Console.WriteLine(Res);
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var res = from c in CustomerList
            //          select new
            //          {
            //              CustomerId=c.CustomerID,
            //              CustomerName = c.CustomerName,
            //              OrderCount = c.Orders.Count()
            //          };


            //foreach (var r in res)
            //{
            //    Console.WriteLine(r);
            //}
            #endregion

            #region 3. Return a list of categories and how many products each has
            //var res = from P in ProductList
            //          group P by P.Category into categoryGroup
            //          select new
            //          {
            //              CategoryName = categoryGroup.Key,
            //              ProductsCount = categoryGroup.Count()
            //          };
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res= Arr.Sum();
            //Console.WriteLine(res);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            // string[] words = File.ReadAllLines("dictionary_english.txt");

            //var res = words.Sum(X => X.Length);
            //Console.WriteLine(res);
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Res= words.Min(w => w.Length);
            //Console.WriteLine(Res);
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Res = words.Max(w => w.Length);
            //Console.WriteLine(Res);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Res = words.Average(w => w.Length);
            //Console.WriteLine(Res);
            #endregion

            #endregion

            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            //var Result = ProductList.OrderBy(P => P.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(A => A, new CustomCompare());
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var Result = ProductList.OrderByDescending(P => P.UnitsInStock);
            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result = Arr.OrderBy(x => x.Length).ThenBy(x=>x);
            //foreach(var x in Result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(x => x.Length).ThenBy(x=>x,new CustomCompare());
            //foreach(var x in Result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Res=Arr.OrderBy(x => x.Length).ThenByDescending(x=>x ,new CustomCompare());
            //foreach(var x in Res)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Res = Arr.Where(x => x[1] =='i').Reverse();
            //foreach (var x in Res)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion



            #endregion

            #region LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products.
            //var Res = ProductList.Select(P => P.ProductName);
            //foreach(var item in Res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var LowerRes = words.Select(x => new
            //{
            //    Lowercase = x.ToLower(),
            //});
            //var UpperRes = words.Select(x => new
            //{
            //   Uppercase = x.ToUpper(),
            //});
            //foreach (var word in LowerRes)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.WriteLine("=======================================");
            //foreach (var word in UpperRes)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var Res = ProductList.Select(P => new
            //{
            //    P.ProductID,
            //    P.ProductName,
            //    Price=P.UnitPrice

            //});
            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Res=Arr.Select((x,i) => new
            //{
            //    x,
            //    V = x == i
            //});
            //foreach (var i in Res)
            //{
            //    Console.WriteLine($"{i.x} : {i.V}");

            // }
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Res = from a in numbersA
            //          from b in numbersB
            //          where a < b
            //          select new { a, b };

            //foreach (var x in Res)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region 6. Select all orders where the order total is less than 500.00.
            //var Res = CustomerList.SelectMany(C => C.Orders).Where(C => C.Total<500);

            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.
            //var Res = CustomerList.SelectMany(C => C.Orders).Where(C => C.OrderDate.Year >= 1998);

            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion








            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Get the total units in stock for each product category.
            //var Result = ProductList.GroupBy(P => P.Category).Select(P => new
            //{
            //    P.Key,
            //    TotalUnits = P.Sum(P => P.UnitsInStock)
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Get the cheapest price among each category's products
            //var Result = ProductList.GroupBy(a => a.Category).Select(a => new
            //{
            //    a.Key,
            //    CheapestPrice = a.Min(a => a.UnitPrice)


            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion

            #region 3. Get the products with the cheapest price in each category (Use Let)
            //var Result = from P in ProductList
            //             group P by P.Category
            //             into A
            //             let cheapest = A.Where(P => P.UnitPrice == A.Min(A=> A.UnitPrice))
            //             from C in cheapest
            //             select C;

            //foreach (var result in Result)
            //{
            //    Console.WriteLine(result);
            //}
            #endregion

            #region 4. Get the most expensive price among each category's products.

            //var Result = ProductList.GroupBy(P => P.Category).Select(P => new
            //{
            //    Category= P.Key,
            //    MostExpensive = P.Max(a => a.UnitPrice)


            //});
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion


            #region 5. Get the products with the most expensive price in each category.
            //var Result = ProductList.GroupBy(P => P.Category).SelectMany(P => P.Where(a => a.UnitPrice == P.Max(a => a.UnitPrice)));

            //foreach (var item in Result)
            //{

            //    Console.WriteLine(item);

            //}
            #endregion

            #region 6. Get the average price of each category's products.
            //var Result = ProductList.GroupBy(P => P.Category).Select(P => new
            //{
            //    Category= P.Key,
            //    AveragePrice = P.Average(a => a.UnitPrice),
            //});

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion





            #endregion

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List
            //var Result = ProductList.Select(P => P.Category).Distinct();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var Result = ProductList.Select(P => P.ProductName[0]).Union(CustomerList.Select(C=> C.CustomerName[0]));


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            //var Result = ProductList.Select(P => P.ProductName[0]).Intersect(CustomerList.Select(C => C.CustomerName[0]));

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result = ProductList.Select(P => P.ProductName[0]).Except(CustomerList.Select(C => C.CustomerName[0]));

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var Result = ProductList.Select(P => P.ProductName.TakeLast(3).ToArray()).Concat(CustomerList.Select(C => C.CustomerName.TakeLast(3).ToArray()));

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #endregion


            #region LINQ - Partitioning Operators
            #region 1. Get the first 3 orders from customers in Washington

            //var Result = CustomerList.Where(C=>C.Region== "WA").SelectMany(a => a.Orders).Take(3);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);

            //}
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.
            //var Result = CustomerList.Where(P => P.Region == "WA").SelectMany(P=> P.Orders).Skip(2);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((N, I) => N > I);


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(N => N% 3 != 0);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region 5.Get the elements of the array starting from the first element less than its position.
            // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile((N, I) => N > I);


            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #endregion

            #region LINQ - Quantifiers
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Result = words.Any(a => a.Contains("ei"));
            //Console.WriteLine(Result);
            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var Result = ProductList.GroupBy(P => P.Category).Where(P=> P.Any(p => p.UnitsInStock == 0)).Select(p => p);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var R in item)
            //    {
            //        Console.WriteLine(R);
            //    }
            //}
            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var Result = ProductList.GroupBy(P=> P.Category).Where(P => P.All(p => p.UnitsInStock > 0)).Select(p => p);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var R in item)
            //    {
            //        Console.WriteLine(R);
            //    }
            //}
            #endregion




            #endregion


            #region LINQ – Grouping Operators
            #region 1.	Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var Result = numbers.GroupBy(a => a % 5);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Numbers With a remainder of {item.Key} when divided by 5:");
            //    foreach (var R in item)
            //    {
            //        Console.WriteLine(R);
            //    }
            //}
            #endregion



            #region 2.Uses group by to partition a list of words by their first letter.Use dictionary_english.txt for Input
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var Result = words.GroupBy(a => a[0]);
            //foreach (var item in Result)
            //{
            //   // Console.WriteLine(item.Key);
            //    foreach (var R in item)
            //    {
            //        Console.WriteLine(R);
            //    }
            //}

            #endregion

            #region 3.Consider this Array as an Input
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var Result = Arr.GroupBy(X => new string(X.Trim().OrderBy(c => c).ToArray()));

            //foreach (var item in Result)
            //{
            //    foreach (var R in item)
            //    {
            //        Console.WriteLine(R);
            //    }
            //    Console.WriteLine("....");
            //}


            #endregion
            #endregion
        }
    }
}