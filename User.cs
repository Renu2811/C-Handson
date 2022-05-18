using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{

    //creating method for getting user id and name
    public  class User
    {
        public int id = 0;
        public string name = string.Empty;
      
        public void GetUserDetails(int uid, string uname)
        {
            id = uid;
            name = uname;
            Console.WriteLine("Id: {0},Name: {1}", id, name);

            
        }

        
    }
}
