using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlipCart obj = new FlipCart();
            Console.WriteLine("Enter the User Details:");
            obj.User_Module();
            Console.WriteLine("      ");
            Console.WriteLine();

            Console.WriteLine("Enter the Category Details:");
            obj.Category_Module();
            Console.WriteLine("      ");
            Console.WriteLine();
            Console.WriteLine("Enter the Product Details:");
            obj.Product_Module();
            Console.WriteLine("      ");

            Console.WriteLine();
            Console.WriteLine("Enter the PURCHASE AND Sales Details:");
            obj.Purchase_and_Sales_Module();
            Console.WriteLine("Please press Any key to exit");



            Console.ReadKey();
        }
    }
}
     
