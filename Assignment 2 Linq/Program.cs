using Demo.Data;
using System.Collections.Generic;
namespace Assignment_2_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators
            //var result = ListGenerator.ProductList?.FirstOrDefault();
            //result = ListGenerator.ProductList?.FirstOrDefault(p => p.UnitPrice > 1000);
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result02 = Arr.Where(n=>n>5).Skip(1).FirstOrDefault();
            #endregion
            #region Aggregate Operators
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine(result);
            //var result02 = ListGenerator.CustomerList.Select(c => new
            //{
            //    c.CustomerID,
            //    c.CustomerName,
            //    c.Fax,
            //    c.Address,
            //    c.City,
            //    c.Region,
            //    c.PostalCode,
            //    c.Country,
            //    OrdersCount = c.Orders.Count()
            //});
            //foreach (var item in result02) Console.WriteLine(item);
            //var result03 = ListGenerator.ProductList.GroupBy(c=>c.Category).Select(c =>new
            //{
            //   category = c.Key ,
            //    ProductNumbers = c.Count()
            //});
            //foreach (var item in result03) Console.WriteLine(item);
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var sum = Arr.Sum();
            //Console.WriteLine(sum);
            //string[] arr = File.ReadAllLines("dictionary_english.txt");
            //var result04 = arr.Sum(w=>w.Length);
            //Console.WriteLine(result04);
            //var result05 = arr.Min(w=>w.Length);
            //Console.WriteLine(result05);
            //var result06 = arr.Max(w => w.Length);
            //Console.WriteLine(result06);
            //var result07 = arr.Average(w => w.Length);
            //Console.WriteLine(result06);
            //var result08 = ListGenerator.ProductList?.GroupBy(c => c.Category).Select(u => new
            //{
            //    Category = u.Key,
            //    TotalStock = u.Sum(p => p.UnitsInStock)
            //});
            //var result09 = ListGenerator.ProductList?.GroupBy(c => c.Category).Select(u => new
            //{
            //    Category = u.Key,
            //    TotalStock = u.Min(p => p.UnitPrice)
            //});
            //var result10 = from p in ListGenerator.ProductList
            //               group p by p.Category into g
            //               let minPrice = g.Min(p => p.UnitPrice)
            //               from p in g
            //               where p.UnitPrice == minPrice
            //               select new { p.Category, p.ProductName, p.UnitPrice };
            //foreach (var item in result10) Console.WriteLine(item);
            //var result11 = ListGenerator.ProductList?.GroupBy(p => p.Category).Select(c => new
            //{
            //    catrgory=c.Key,
            //    MaxPrice = c.Max(p => p.UnitPrice)
            //});
            //foreach (var item in result11) Console.WriteLine(item);
            //var result12 = from p in ListGenerator.ProductList
            //                            group p by p.Category into g
            //                            let maxPrice = g.Max(p => p.UnitPrice)
            //                            from p in g
            //                            where p.UnitPrice == maxPrice
            //                            select new { p.Category, p.ProductName, p.UnitPrice };
            //foreach (var item in result12) Console.WriteLine(item);
            //var result13 = ListGenerator.ProductList?.GroupBy(c => c.Category).Select(p => new
            //{
            //    Category = p.Key,
            //    AveragePrice = p.Average(p => p.UnitPrice)
            //});
            //foreach (var item in result13) Console.WriteLine(item);
            #endregion;
            #region Set Operators
            //var result01 = ListGenerator.ProductList?.Select(c => c.Category).Distinct();
            //foreach (var item in result01 ?? Enumerable.Empty<string>()) Console.WriteLine(item);
            //var product = ListGenerator.ProductList?.Select(p => p.ProductName?[0]);
            //var customer = ListGenerator.CustomerList?.Select(c => c.CustomerName?[0]);
            //var result02 = product.Union(customer);
            //foreach (var item in result02) Console.WriteLine(item);
            //var result03 = product.Intersect(customer);
            //foreach (var item in result03) Console.WriteLine(item);
            //var result04 = product.Except(customer);
            //foreach (var item in result04) Console.WriteLine(item);
            //var result05 = ListGenerator.ProductList?.Select(p => p.ProductName?.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3): p.ProductName)
            //    .Concat(ListGenerator.CustomerList.Select(c => c.CustomerName?.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3): c.CustomerName));
            //foreach (var item in result05) Console.WriteLine(item);

            #endregion
            #region Partitioning Operators
            //var result01 = ListGenerator.CustomerList?.Where(c => c.City == "Washington").SelectMany(o => o.Orders).Take(3);
            //foreach (var item in result01) Console.WriteLine(item);
            //var result02 = ListGenerator.CustomerList?.Where(c => c.City == "Washington").SelectMany(o => o.Orders).Skip(2);
            //foreach (var item in result02) Console.WriteLine(item);
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result03 = numbers.TakeWhile((n, i) => n >= i);
            //foreach (var item in result03) Console.WriteLine(item);
            //var result04 = numbers.SkipWhile(n => n % 3 != 0);
            //foreach (var item in result04) Console.WriteLine(item);
            //var result05 = numbers.TakeWhile((n, i) => n >= i);
            //foreach (var item in result05) Console.WriteLine(item);
            #endregion
            #region Quantifiers
            //string[] arr = File.ReadAllLines("dictionary_english.txt");
            //bool result01 = arr.Any(w => w.Contains("ei"));
            //Console.WriteLine(result01);
            //var result02 = from p in ListGenerator.ProductList
            //                group p by p.Category into g
            //                where g.Any(p => p.UnitsInStock == 0)
            //                select new { Category = g.Key, Products = g };
            //foreach (var item in result02)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    foreach (var p in item.Products)
            //        Console.WriteLine($"   {p.ProductName} (Stock: {p.UnitsInStock})");
            //}
            //var result03= from p in ListGenerator.ProductList
            //              group p by p.Category into g
            //              where g.All(p=>p.UnitsInStock > 0)
            //              select new { Category = g.Key, Products = g };
            //foreach (var item in result03)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    foreach (var p in item.Products)
            //        Console.WriteLine($"   {p.ProductName} (Stock: {p.UnitsInStock})");
            //}
            #endregion
            #region Grouping Operators
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result01 = from n in numbers
            //                   group n by n % 5 into g
            //                   orderby g.Key
            //                   select g;
            //foreach (var item in result01)
            //{
            //    Console.WriteLine($"Numbers with remainder of {item.Key} when divided by 5:");
            //    foreach (var num in item)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
            //string[] arr = File.ReadAllLines("dictionary_english.txt");
            //var result02 = arr.GroupBy(a => a[0]).OrderBy(a => a.Key);
            //foreach (var item in result02)
            //{
            //    Console.WriteLine($"Words starting with '{item.Key}':");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //    Console.WriteLine();
            //}
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };
            //var result03 = Arr.Select(w => w.Trim()).GroupBy(w => String.Concat(w.OrderBy(c => c)));
            //foreach (var group in result03)
            //{
            //    foreach (var item in group)
            //        Console.WriteLine(item);
            //    Console.WriteLine("....");
            //}
            #endregion
        }
    }
}
