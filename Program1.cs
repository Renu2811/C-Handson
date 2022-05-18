using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    public class Program1
    {

        //creating object and calling the methods
        static void Main(string[] args)
        {
            User user = new User();
            user.GetUserDetails(25,"Renu");



            UserDetails obj = new UserDetails("Madhumitha", 26);
            obj.GetUser();
            Console.ReadLine();
         
            
        }
    }
 
}
        
