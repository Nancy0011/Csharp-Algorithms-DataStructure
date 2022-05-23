using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleList<string> link = new DoubleList<string>();
            link.Append("StudentID: 111777");
            link.Append("StudentID: 000222");
            link.Append("StudentID: 111999");

            link.Insert("StudentID: 222000", 1);
            //link.Insert("StudentID: 333999", 2);
            link.Delete(2);
            //Console.WriteLine(link.GetElem(0));
            //Console.WriteLine(link.GetPos("789"));

            Node<string> c = link.Head;
            Console.WriteLine("---output---");

            while (c.Next != null)
            {
                Console.WriteLine(c.Data);
                c = c.Next;
            }
            Console.WriteLine(c.Data);

            
            Console.WriteLine("---length---");
            Console.WriteLine(link.GetLenth());
        }
    }
}