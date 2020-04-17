using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

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
            XmlDocument doc = new XmlDocument();
            XmlDocument doc2 = new XmlDocument();
            doc.Load(@"e:\g2.txt");

           

            // XmlNode node = doc.DocumentElement.SelectSingleNode("/catalog/book");

            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/catalog/book");
            foreach (XmlNode node in nodes)
            {
                for(int i=0; i<2; i++)
                {
                   
                    XmlNode anothernode = node.CloneNode(true);
                    anothernode.SelectSingleNode("publish_date").InnerText = $"*GoTemp[{i}]_yy/mm/dd";
                    doc.DocumentElement.InsertAfter(anothernode, node);
                }
                
            }
            
            //doc.AppendChild(node);
            //doc.DocumentElement.AppendChild(anothernode);
           
           
            doc.Save(@"e:\g2.txt");
            //doc.Load(@"e:\g2.txt");
            //XmlNodeList nodes = doc.DocumentElement.SelectNodes("/catalog/book/price");
            //
            //foreach (XmlNode node_temp in nodes)
            //{
            //    node_temp.InnerText = "100";
               
                
            //}
            //doc.Save(@"e:\g2.txt");

            XElement custOrd = XElement.Load("e:\\g1.txt");
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
            //this is f driver for console 6
        }
    
    }
}

