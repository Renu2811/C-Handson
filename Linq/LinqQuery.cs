using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Linq
{
    public class LinqQuery
    {      /*1.	Write a program in C# Sharp to find the positive numbers from a list of numbers using two where conditions in LINQ Query.
                Input: 
                int[] n1 = {1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14};*/

        public static void PositiveNoLinq()
        {
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var output = (from n1Item in n1
                          where n1Item >= 0
                          select n1Item).ToList();

            foreach (var n2Item in output)
            {
                Console.Write(n2Item + " ");
            }
            Console.WriteLine();
        }



        /*  2.	Write a program in C# Sharp to display the number and frequency of number from given array.
                Input: 
                int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };  */

        public static void NumAndFrequency()
        {     

            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var displayArr = (from arr1Item in arr1
                              select arr1Item).ToList();

            Console.WriteLine("The numbers in the array  are :");

            foreach (var displayArrItem in displayArr)
            {
                Console.Write($"{displayArrItem} ");
            }
            Console.WriteLine();
            Console.WriteLine("Numbers and the frequency are :");

            var result = (from arr1Item in arr1
                          group arr1Item by arr1Item).ToList();

            foreach (var resultItems in result)
            {
                var number = (from resultSubItem in resultItems
                              select resultSubItem).FirstOrDefault();

                Console.WriteLine($"Number {number} appears {resultItems.Count()} times.");

            }

        }

        /* 3.	Write a program in C# Sharp to display the characters and frequency of character from giving string
                   Input the string: apple
                   Expected Output:
                   The frequency of the characters are :
                   Character a: 1 times */

        public static void CharAndFrequency(string myString)
        {
           
            char[] charactersArr = myString.ToCharArray();

            Console.WriteLine("Input string is :" + myString);

            var result = (from charactersArrItem in charactersArr
                          group charactersArrItem by charactersArrItem).ToList();

            Console.WriteLine("The frequency of the characters are :");
            foreach (var resultItems in result)
            {
                var character = (from resultSubItem in resultItems
                                 select resultSubItem).FirstOrDefault();

                Console.WriteLine($"Character {character}: {resultItems.Count()} times");

            }

        }

        /*4.	Write a program in C# Sharp to find the string which starts and ends with a specific character
                 Input:
                 The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
                 Input starting character for the string : A
                 Input ending character for the string : M
                 Expected Output :
                 The city starting with A and ending with M is : AMSTERDAM*/


        public static void StartsEndsWithChar()
        {
            List<string> cityLists = new List<string>()
                  {
                      "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS"
                  };

            var displayCityLsit = (from city in cityLists
                                   select city).ToList();

            Console.WriteLine("The cities are :");
            foreach (var city in displayCityLsit)
            {
                Console.Write($"{city} ");
            }
            Console.WriteLine();
            Console.Write("Input starting character for the string :");
            string startWith, endsWith;
            startWith = Console.ReadLine();

            Console.Write("Input ending character for the string :");
            endsWith = Console.ReadLine();

            var resCity = (from city in cityLists
                           where city.StartsWith(startWith) && city.EndsWith(endsWith)
                           select city).FirstOrDefault();

            Console.WriteLine($"The city starting with {startWith} and ending with {endsWith} is :{resCity}");
        }

        /*5.	Write a program in C# Sharp to display the top n-th records.*/

        public static void TopNthRecords()
        {
            int[] records = { 5, 7, 13, 24, 6, 9, 8, 7 };
            Console.Write("How many records you want to display ? :");
            int input = Convert.ToInt32(Console.ReadLine());

            var res = (from rec in records
                       orderby rec descending
                       select rec).ToList();
            Console.WriteLine($"The top {input} records from the list are :");
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(res[i]);
            }
        }




    }
}
