using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoodCourtManagementSystem
{
    public class ManageSales :ManageFoodItems
    {
        public string name { get; set; }

        public int price { get; set; }
        public string date { get; set; }
        public int sold { get; set; }
        public void AddNewSales()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\foodsales.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            streamWriterobj.WriteLine("Enter the name of food Item:");
             name = Console.ReadLine();
            streamWriterobj.WriteLine("Enter the price of food Item:");
             price = Convert.ToInt32(Console.ReadLine());
            streamWriterobj.WriteLine("Enter the date:");
             date = DateTime.Now.ToString();
            streamWriterobj.WriteLine("Enter the number  of times the  food Item sold:");
             sold = Convert.ToInt32(Console.ReadLine());

            streamWriterobj.Close();
            fileStreamobj.Close();

        }

        public void EditExistSales()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\foodsales.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            streamWriterobj.WriteLine("Editing the date:");
            string date = DateTime.Now.ToString();
            streamWriterobj.WriteLine("Editing the number of times  food item sold:");
            int sold = Convert.ToInt32(Console.ReadLine());

            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            streamWriterobj.Close();
            fileStreamobj.Close();
        }

        public void ViewDetailsOfSales()
        {

            FileStream fileStreamobj = new FileStream(@"D:\C#handson\foodsales.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Details of Food Items Sales:");
            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            fileStreamobj.Close();
        }


        public void ListOfFoodSales()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\foodsales.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("List of all Food Items sales:");
            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            fileStreamobj.Close();
        }
    }
}
