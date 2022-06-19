using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Person
    {
        //7.    linq statement for people with last name that starts with the letter D
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public Person(string fname, string lname, int age)
        {
            Fname = fname;
            Lname = lname;
            Age = age;

        }

    }
    public class LastName
    {
        public void LastNameWithD()
        {
            var people = new List<Person>()
            {
             new Person("Bill", "Smith", 41),
             new Person("Sarah", "Jones", 22),
             new Person("Stacy","Baker", 21),
             new Person("Vivianne","Dexter", 19 ),
             new Person("Bob","Smith", 49 ),
             new Person("Brett","Baker", 51 ),
             new Person("Mark","Parker", 19),
             new Person("Alice","Thompson", 18),
             new Person("Evelyn","Thompson", 58 ),
             new Person("Mort","Martin", 58),
             new Person("Eugene","DeLauter", 84 ),
             new Person("Gail","Dawson", 19 ),

            };
            Console.WriteLine("Enter the leter to find the names from the list: ");
            string letter = Console.ReadLine();
            var result = (from n in people
                          where n.Lname.StartsWith(letter)
                          select n.Lname).ToList();
            foreach (var lname in result)
            {
                Console.WriteLine(lname);
            }
        }
        //8.Number of people whose last name starts with the letter D
        public void NoOfPeople()
        {
            var people = new List<Person>()
                {
                 new Person("Bill", "Smith", 41),
                 new Person("Sarah", "Jones", 22),
                 new Person("Stacy","Baker", 21),
                 new Person("Vivianne","Dexter", 19 ),
                 new Person("Bob","Smith", 49 ),
                 new Person("Brett","Baker", 51 ),
                 new Person("Mark","Parker", 19),
                 new Person("Alice","Thompson", 18),
                 new Person("Evelyn","Thompson", 58 ),
                 new Person("Mort","Martin", 58),
                 new Person("Eugene","DeLauter", 84 ),
                 new Person("Gail","Dawson", 19 ),

                };
            Console.WriteLine("Enter the leter to find the Number of people " +
                "whose last name starts with the letter: ");
            string letter = Console.ReadLine();
            var result = (from n in people
                          where n.Lname.StartsWith(letter)
                          select n.Lname).ToList();
            foreach (var lname in result)

                Console.WriteLine(result.Count());

        }


        //9.	Write linq statement for first Person Older Than 40 In Descending Alphabetical Order By First Name

        public void DescFirstName()
        {
            var people = new List<Person>()
        {
            new Person("Bill", "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","DeLauter", 84 ),
            new Person("Gail","Dawson", 19 ),

        };

            var resdescName = (from peopleItem in people
                               where peopleItem.Age > 40
                               orderby peopleItem.Fname descending
                               select peopleItem.Fname).ToList();


            foreach (var resultitem in resdescName)
            {
                Console.Write($"{resultitem}, ");
            }
        }

        //10.	Find the words in the collection that start with the letter 'L'

        public static void FindWordsStartsWithL()
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var outputList = (from froutList in fruits
                              where froutList.StartsWith("L")
                              select froutList).ToList();
            Console.WriteLine("words in the collection that start with the letter 'L'");
            foreach (var resultitem in outputList)
            {
                Console.Write($"{resultitem}, ");
            }
            Console.WriteLine("");

        }

        //11.	Which of the following numbers are multiples of 4 or 6

        public static void Multiple4Or6()
        {
            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var res = (from item in mixedNumbers
                       where item % 4 == 0 || item % 6 == 0
                       select item).ToList();

            Console.WriteLine("The following numbers are multiples of 4 or 6:");
            foreach (var resultitem in res)
            {
                Console.Write($"{resultitem} , ");
            }
            Console.ReadLine();

        }
    }




}



