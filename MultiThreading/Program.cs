using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class Program
    {
        static void Main(string[] args)
        {

            TaskParallelExecution taskParallelExecution = new TaskParallelExecution();


            //taskParallelExecutions.DisplayCars();

            //creating threads

            Thread t1 = new Thread(taskParallelExecution.ShowBuyerReport);
            Thread t2 = new Thread(taskParallelExecution.ShowDealerReport);

            //stating threads
            t1.Start();
            t2.Start();
            Console.ReadKey();

        }
    }
}

   
