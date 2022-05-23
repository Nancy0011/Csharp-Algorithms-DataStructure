using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5
{
    class BubbleSort
    {

        public static void sortStudentName(String[] arr,
                                  int n)
        {
            String temp;

            // Sorting strings using bubble sort
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = j + 1; i < n; i++)
                {
                    if (arr[j].CompareTo(arr[i]) > 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    }
}

            //private static void BubbleSortOfInt(int[] scores)
            //{
            //    int t;
            //    Console.WriteLine("The Array is : ");
            //    for (int i = 0; i < scores.Length; i++)
            //    {
            //        Console.WriteLine(scores[i]);
            //    }
            //    for (int j = 0; j <= scores.Length - 2; j++)
            //    {
            //        for (int i = 0; i <= scores.Length - 2; i++)
            //        {
            //            if (scores[i] > scores[i + 1])
            //            {
            //                t = scores[i + 1];
            //                scores[i + 1] = scores[i];
            //                scores[i] = t;
            //            }
            //        }
        //}
        //}
    
