using System;
namespace SearchingTechniques
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            //Create an array and initialize it 
            int[] search_list = new int[] { 3, 1, 9, 8, 7, 12, 56, 23, 89 };

            int n, result;
            //Read the target value to search
            Console.WriteLine("Enter a value to search: ");
            n = Int32.Parse(Console.ReadLine());
            result = ob.LinearSearch(search_list, n);
            if (n != -1)
                Console.WriteLine("The target value " + n + " is found at position " + result);
            else
                Console.WriteLine("Target not found!");

        }

        int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (target == arr[i])
                    return (i + 1);
            }
            return -1;
        }
    }
}