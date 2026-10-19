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
            var seafood = ProductList.Where(p => p.Category == "Seafood");
            foreach (var p in seafood)
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");


        }
    }
}
