using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5
{
    //class BinarySearch
    //{
        //private static void BinarySearchOfInt()
        //{
        //    Console.WriteLine("Number of elements in the array?");
        //    string elements = Console.ReadLine();
        //    int numElements = int.Parse(elements);
        //    int[] array = new int[numElements];
        //    Console.WriteLine("---------------");
        //    Console.WriteLine("Enter array elements");
        //    Console.WriteLine("---------------");

        //    for (int i = 0; i < numElements; i++)
        //    {
        //        string s1 = Console.ReadLine();
        //        array[i] = int.Parse(s1);

        //    }
        //    Console.WriteLine("---------------");
        //    Console.WriteLine("Enter Serarch elements");
        //    Console.WriteLine("---------------");
        //    int searchElement = int.Parse(Console.ReadLine());
        //    int min = 0;
        //    int N = array.Length;
        //    int max = N - 1;
        //    do
        //    {
        //        int mid = (min + max) / 2;
        //        if (searchElement > array[mid])
        //            min = mid + 1;
        //        else
        //            max = mid - 1;
        //        if (array[mid] == searchElement)
        //        {
        //            Console.WriteLine("Search Element found at index: " + mid);
        //            break;
        //        }
        //        if (min > max)
        //            break;

        //    } while (min <= max);
        //    Console.WriteLine("Search Element NOT found");
        //    Console.ReadLine();
        

        public class StudentNameComparer : IComparer<string>
            {
                public int Compare(string x, string y)
             {
                 if (x == null)
                    {
                        if (y == null)
                        {
                    // If x is null and y is null, they're
                    // equal.
                            return 0;
                     }
                        else
                     {
                    // If x is null and y is not null, y
                    // is greater.
                            return -1;
                     }
                    }
                    else
                    {
                // If x is not null...
                //
                     if (y == null)
                // ...and y is null, x is greater.
                        {
                            return 1;
                        }
                        else
                        {
                    // ...and y is not null, compare the
                    // lengths of the two strings.
                    //
                            int retval = x.Length.CompareTo(y.Length);

                            if (retval != 0)
                         {
                        // If the strings are not of equal length,
                        // the longer string is greater.
                        //
                                return retval;
                            }
                            else
                            {
                        // If the strings are of equal length,
                        // sort them with ordinary string comparison.
                        //
                             return x.CompareTo(y);
                            }
                        }
                 }
                }
            }

}
    
