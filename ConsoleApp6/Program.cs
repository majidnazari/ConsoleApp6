using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        public class person
        {
            public string name { get; set; }
            public int Id { get; set; }
        };
        static void Main(string[] args)
        {

           
            Console.ReadKey();

                List<person> people = new List<person>
                {
                    new person{Id=1,name="ali1"},
                    new person{Id=2,name="ali2"},
                    new person{Id=3,name="ali3"},
                    new person{Id=4,name="ali4"},
                    new person{Id=5,name="ali5"},
                    new person{Id=6,name="ali6"},

                };

                List<int> list1 = new List<int> { 1, 2, 3 };
                List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var x = people.Where(p => list1.Contains(p.Id));
        }
    
    }
}

