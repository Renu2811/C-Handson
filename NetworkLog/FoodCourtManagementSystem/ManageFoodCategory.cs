using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoodCourtManagementSystem
{
    public class ManageFoodCategory
    {
        public string category { get; set; }
        
        public void AddNewFoodCategory()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\foodcategory.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            streamWriterobj.WriteLine("Enter the food Category:");
            category = Console.ReadLine();
            streamWriterobj.Close();
            fileStreamobj.Close();
            
          
        }

        public void EditExistFoodCategory()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\foodcategory.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            streamWriterobj.WriteLine("Editing the food category:");
             category = Console.ReadLine();
            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            fileStreamobj.Close();
        }

        public void ViewDetailsOfFoodCategory()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\foodcategory.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("Details of Food Category");
            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            fileStreamobj.Close();

        }

        public void ListOfFoodCategory()
        {

            FileStream fileStreamobj = new FileStream(@"D:\C#handson\foodcategory.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderobj = new StreamReader(fileStreamobj);
            Console.WriteLine("List of Food Category");
            while (streamReaderobj.Peek() > 0)
            {
                Console.WriteLine(streamReaderobj.ReadLine());

            }
            streamReaderobj.Close();
            fileStreamobj.Close();

        }
    }
}
