using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbBill;

namespace DLLFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            EBbill e = new EBbill();
            e.CustomerData(230, "latha", 43);
            e.CustomerData(231, "pavan", 7);
            e.CustomerData(232, "karthik", 27);
            e.CustomerData(233, "Manoj", 74);
            e.CustomerData(234, "tanusri", 41);
            e.CustomerData(235, "Bhavani", 64);
            e.CustomerData(236, "Gowri", 15);
            e.CustomerData(237, "Mahesh", 32);
            e.CustomerData(238, "lakshmi", 35);
        TOP:
            Console.WriteLine("choose the option: \n 1 for Customer detalis \n 2 for show EBbill \n 3 for all bill report\n");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("Enter customer id to view details");
                        int id = Convert.ToInt32(Console.ReadLine());
                        e.ShowCustomerDetails(id);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter customer id to view details");
                        int id = Convert.ToInt32(Console.ReadLine());
                        e.ShowCustomerDetails(id);
                        break;
                    }
                case 3:
                    {
                        e.ShowEbBillReport();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("choose correct option");
                        goto TOP;
                    }
            }
            Console.Read();

        }
    }
}

        
