using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FoodCourtManagementSystem
{
    public  class ManageFoodItems : ManageFoodCategory
    {

       
        public int price { get; set; }
        public string name { get; set; }

        public void AddNewFoodItem()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\fooditems.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            Console.WriteLine("Enter the name of food item:");
             name = Console.ReadLine();
            streamWriterobj.WriteLine(name);
            Console.WriteLine("Enter the price of food Item:");
            price = Convert.ToInt32(Console.ReadLine());
            streamWriterobj.WriteLine(price);
            streamWriterobj.Close();
            fileStreamobj.Close();


        }

        public void EditExistFoodItems()
        { 
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\fooditems.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Editing the name of food items:");
             name = Console.ReadLine();
            streamWriterobj
            streamWriterobj.WriteLine("Editing the price of  food items:");
             price =Convert.ToInt32( Console.ReadLine());
            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            streamWriterobj.Close();
            fileStreamobj.Close();
        }

        public void ViewDetailsOfFoodItems()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\fooditems.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Details of Food Items:");
            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            fileStreamobj.Close();

        }
    
        public void ListOfFoodItems()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\fooditems.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("List of all Food Items:");
            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            fileStreamobj.Close();
        }
    
    }
}

  

