using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoodCourtManagementSystem
{
    public  class FoodReport:ManageFoodItems

    {
        public void FoodItemsReport()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\fooditems.txt", FileMode.Open, FileAccess.Read);
            Console.WriteLine("Report of Food items:");
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            fileStreamobj.Close();

        }
        public void FoodSalesReport()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\foodsales.txt", FileMode.Open, FileAccess.Read);
            Console.WriteLine("Report of Food Sales:");
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            fileStreamobj.Close();


        }

        public void FoodCategoryReport()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\foodcategory.txt", FileMode.Open, FileAccess.Read);
            Console.WriteLine("Report of Food Category:");
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            fileStreamobj.Close();

        }
    }
}
