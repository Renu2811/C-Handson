using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace EbBill
{
    public class EBbill
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public int noOfUnits { get; set; }
        public int unitsPerCost { get; set; } = 10;
        public int total { get; set; }

        List<EBbill> ebill = new List<EBbill>();

        private EBbill(int customerID, string customerName, int noOfUnits)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.noOfUnits = noOfUnits;
            tBill();
        }
        public EBbill() { }

        public void CustomerData(int iD, String name, int units)
        {
            EBbill bill = new EBbill(iD, name, units);
            ebill.Add(bill);
        }
        private void tBill()
        {
            total = unitsPerCost * noOfUnits;
        }
        public void ShowCustomerDetails(int customerID)
        {
            foreach (var data in ebill)
            {
                if (data.customerID == customerID)
                    Console.WriteLine("CustomerID :" + data.customerID + "\tCustomerName :" + data.customerName + "\tUsage in Units :" + data.noOfUnits);
            }
        }
        public void ShowEbBill(int customerID)
        {
            foreach (var data in ebill)
            {
                if (data.customerID == customerID)
                    Console.WriteLine("CustomerID :" + data.customerID + "\tCustomerName :" + data.customerName + "\tUsage in Units :" + data.noOfUnits + "\tTotalBill :" + data.total);
            }
        }
        public void ShowEbBillReport()
        {
            foreach (var data in ebill)
            {
                Console.WriteLine("CustomerID :" + data.customerID + "\tCustomerName :" + data.customerName + "\tUsage in Units :" + data.noOfUnits + "\tTotalBill :" + data.total);
            }

        }

    }
}
    
