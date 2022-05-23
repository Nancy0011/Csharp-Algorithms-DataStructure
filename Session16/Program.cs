using System;

namespace Session16
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(7);

            foreach (int value in list)
            {
                Console.WriteLine(value);
            }

        }
    }
}
