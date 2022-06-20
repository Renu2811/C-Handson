using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void message(string msg);
    public  class DelegateClass
    {
        public void Hello(string msg)
        {
            Console.WriteLine(msg);
        }
        public void Hii(string msg)
        {
            Console.WriteLine(msg);
        }
        public void Gm(string msg)
        {
            Console.WriteLine(msg);
        }


    }
}


  
