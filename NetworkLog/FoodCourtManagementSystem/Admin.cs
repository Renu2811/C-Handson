using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FoodCourtManagementSystem
{
   public class Admin
    {
        public string UserName { get; set; }
        public int Password { get; set; }
        public void WriteFile()
        {
            FileStream fileStreamobj = new FileStream(@"D:\C#handson\AdminLogin.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriterobj = new StreamWriter(fileStreamobj);
            Console.WriteLine("Enter the username: ");
            string UserName = Console.ReadLine();
            streamWriterobj.WriteLine(UserName);

            Console.WriteLine("Enter the Password: ");
            int Password = Convert.ToInt32(Console.ReadLine());
            streamWriterobj.WriteLine(Password);

            streamWriterobj.Close();
            fileStreamobj.Close();
            int Pass = Password;
            if (Password == Pass)
            {
                bool close = true;
                while (close)
                {
                    Console.WriteLine("\nMenu\n" + "1.Manage Food Category\n" + "2.Manage Food Items\n" + "3.Manage Sales\n" + "4.FoodReport");
                    Console.WriteLine("Choose your option: ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        ManageFoodCategory();
                    }
                    else if (option == 2)
                    {
                        ManageFoodItems();
                    }
                    else if (option == 3)
                    {
                        ManageSales();
                    }
                    else if (option == 4)
                    {
                        FoodReport();
                    }
                    else if (option == 5)
                    {
                        Console.WriteLine("close");
                        close = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option..\n");
                    }
                    Console.ReadLine();
                }
            }


        }

        public void ManageFoodCategory()
        {
            ManageFoodCategory categoryobj = new ManageFoodCategory();
            categoryobj.AddNewFoodCategory();
            categoryobj.EditExistFoodCategory();
            categoryobj.ViewDetailsOfFoodCategory();
            categoryobj.ListOfFoodCategory();
        }

        public void ManageFoodItems()
        {
            ManageFoodItems itemsobj = new ManageFoodItems();
            itemsobj.AddNewFoodItem();
            itemsobj.EditExistFoodItems();
            itemsobj.ViewDetailsOfFoodItems();
            itemsobj.ListOfFoodItems();

        }

        public void ManageSales()
        {
            ManageSales salesobj = new ManageSales();
            salesobj.AddNewSales();
            salesobj.EditExistSales();
            salesobj.ViewDetailsOfSales();
            salesobj.ListOfFoodSales();
            
        }

        public void FoodReport()
        {
            FoodReport reportobj = new FoodReport();
            reportobj.FoodItemsReport();
            reportobj.FoodSalesReport();
            reportobj.FoodCategoryReport();
        }

        
    }
}
