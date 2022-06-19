using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLog
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReadFile obj = new ReadFile();
            obj.Readfrom();
        }
    }
}
