using LINQ.DataSources;

namespace AssignmentLinq01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ProductList = Source.ProductList;
            var CustomerList = Source.CustomerList;

            // Q1
            //var seafood = ProductList.Where(p => p.Category == "Seafood");
            //foreach (var p in seafood)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            // Q2
            //Console.WriteLine("--- Q2 ---");
            //var names = ProductList.Select(p => p.ProductName);
            //foreach (var n in names)
            //    Console.WriteLine(n);
            //Q3
            //Console.WriteLine("--- Q3 ---");
            //var byPrice = ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var p in byPrice)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            // Q4
            //Console.WriteLine("--- Q4 ---");
            //var between = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var p in between)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

            //Console.WriteLine("--- Q5 ---");
            //var inStockCondiments = ProductList
            //    .Where(p => p.UnitsInStock > 0 && p.Category == "Spices & Condiments");
            //foreach (var p in inStockCondiments)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");

            //Console.WriteLine("--- Q6 ---");
            //var status = ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});
            //foreach (var s in status)
            //    Console.WriteLine($"{s.Name} - {s.Price} - {s.StockStatus}");

            //Console.WriteLine("--- Q7 ---");
            //var numbered = ProductList.Select((p, index) => $"{index + 1}. {p.ProductName}");
            //foreach (var item in numbered)
            //    Console.WriteLine(item);

            //Console.WriteLine("--- Q8 ---");
            //var sorted = ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);
            //foreach (var p in sorted)
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");

   
            //Console.WriteLine("--- Q9 ---");
            //var beverages = ProductList
            //    .Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock);
            //foreach (var p in beverages)
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");

            //Console.WriteLine("--- Q10 ---");
            //var orders1997 =
            //    from c in CustomerList
            //    from o in c.Orders
            //    where o.OrderDate.Year >= 1997
            //    select new { c.CustomerID, o.OrderDate };
            //foreach (var o in orders1997)
            //    Console.WriteLine($"{o.CustomerID} - {o.OrderDate:yyyy-MM-dd}");

            //Console.WriteLine("--- Q11 ---");
            //var withPosition = ProductList.Select((p, i) => new { Position = i + 1, p.ProductName });
            //foreach (var x in withPosition)
            //    Console.WriteLine($"{x.Position} - {x.ProductName}");

           
            //Console.WriteLine("--- Q12 ---");
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = Arr
            //    .OrderBy(w => w.Length)
            //    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var w in sortedWords)
            //    Console.WriteLine(w);

 
            //Console.WriteLine("--- Q13 ---");
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var reversedI = digits
            //    .Where(d => d[1] == 'i')
            //    .Reverse();
            //foreach (var d in reversedI)
            //    Console.WriteLine(d);

        }
    }
}
