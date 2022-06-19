﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public  class Students
    {

        //6.Write a program in C# Sharp to find the n-th Maximum grade point
        //achieved by the students from the list of students.

        
            public int StuId { get; set; }
            public string StuName { get; set; }
            public int GrPoint { get; set; }
        public static void NthMaxGrade()
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });

            //Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : 3 
            Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  :");
            int nthGrPoints = Convert.ToInt32(Console.ReadLine());

            var res = (from stulistitems in stulist
                       orderby stulistitems.GrPoint descending
                       group stulistitems.GrPoint by stulistitems.GrPoint
                       ).ToList();


            var list = res[nthGrPoints - 1];

            List<Students> result = new List<Students>();

            foreach (var item in list)
            {
                result = (from stulistitems in stulist
                          where stulistitems.GrPoint == item
                          select stulistitems).ToList();
            }
            foreach (var resultitem in result)
            {
                Console.WriteLine($"id: {resultitem.StuId} name: {resultitem.StuName} Achived grade points: {resultitem.GrPoint}");
            }


            Console.WriteLine();

        }
    }
}

