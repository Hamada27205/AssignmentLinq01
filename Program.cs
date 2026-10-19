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
            Console.WriteLine("--- Q3 ---");
            var byPrice = ProductList.OrderBy(p => p.UnitPrice);
            foreach (var p in byPrice)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

        }
    }
}
