using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerialAndDeserialize
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SerialAndDeserialize serialAndDeserialize = new SerialAndDeserialize();
            //serialAndDeserialize.Deserialize();

            //JsonSerialAndDeserialize jsonSerialAndDeserialize = new JsonSerialAndDeserialize();
            //jsonSerialAndDeserialize.JsonSerialize();

            JsonSerialAndDeserialize jsonSerialAndDeserialize = new JsonSerialAndDeserialize();
            jsonSerialAndDeserialize.JsonDeserialize();
        }
    }
}
