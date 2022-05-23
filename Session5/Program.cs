using Session15;
using System;
using System.Collections.Generic;

namespace Session15

{
    class Program
    {
        static void Main(string[] args)
        {

            //    // Question 1 
            //    Program ob = new Program();
            //    //Create an array of studentID and initialize it 
            //    int[] search_list = new int[] {000111, 000222, 000333, 000444, 000555, 000666, 000777, 111000, 111222, 111333 };

            //    int n, result;
            //    //Read the target value to search
            //    Console.WriteLine("Enter a value to search: ");
            //    n = Int32.Parse(Console.ReadLine());
            //    result = ob.LinearSearch(search_list, n);
            //    if (n != -1)
            //        Console.WriteLine("The target value " + n + " is found at position " + result);
            //    else
            //        Console.WriteLine("Target not found!");

            //}

            //int LinearSearch(int[] arr, int target)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (target == arr[i])
            //            return (i + 1);
            //    }
            //        return -1;
            //}

            // Question 2  BinarySearch for StudentID
            //    Array myStudentName = Array.CreateInstance(typeof(Int32), 5);

            //    myStudentName.SetValue("Ann_Brown", 0);
            //    myStudentName.SetValue("Sally_Buk", 1);
            //    myStudentName.SetValue("John_Smith", 2);
            //    myStudentName.SetValue("Noah_Bukly", 3);
            //    myStudentName.SetValue("Amy_Bob", 4);

            //    // Do the required sort first
            //    Array.Sort(myStudentName);

            //    // Displays the values of the Array.
            //    Console.WriteLine("The Int32 array contains the following:");
            //    PrintValues(myStudentName);

            //    // Locates a specific object that does not exist in the Array.
            //    object myObjectOdd = 1;
            //    FindMyObject(myStudentName, myObjectOdd);

            //    // Locates an object that exists in the Array.
            //    object myObjectEven = 6;
            //    FindMyObject(myStudentName, myObjectEven);
            //}

            //public static void FindMyObject(Array myArr, object myObject)
            //{
            //    int myIndex = Array.BinarySearch(myArr, myObject);
            //    if (myIndex < 0)
            //    {
            //        Console.WriteLine("The StudentName to search for ({0}) is not found. The next larger object is at index {1}.", myObject, ~myIndex);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The student to search for ({0}) is at index {1}.", myObject, myIndex);
            //    }
            //}

            //public static void PrintValues(Array myArr)
            //{
            //    int i = 0;
            //    int cols = myArr.GetLength(myArr.Rank - 1);
            //    foreach (object o in myArr)
            //    {
            //        if (i < cols)
            //        {
            //            i++;
            //        }
            //        else
            //        {
            //            Console.WriteLine();
            //            i = 1;
            //        }
            //        Console.Write("\t{0}", o);
            //    }
            //    Console.WriteLine();

            // Binary search by Name
            //List<string> students = new List<string>();

            //students.Add("Sally_Buk");
            //students.Add("Noah_Bukly");
            //students.Add("John_Brown");
            //students.Add("Ann_Smith");

            //Console.WriteLine("Initial list:");
            //Console.WriteLine();
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine("\nSort:");
            //students.Sort();

            //Console.WriteLine();
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine("\nBinarySearch and Insert \"Sara_Rogo\":");
            //int index = students.BinarySearch("Sara_Rego");
            //if (index < 0)
            //{
            //    students.Insert(~index, "Sara_Rogo");
            //}

            //Console.WriteLine();
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //Console.WriteLine("\nBinarySearch and Insert \"Jeremy_Wilson\":");
            //index = students.BinarySearch("Jeremy_Wilson");
            //if (index < 0)
            //{
            //    students.Insert(~index, "Jeremy_Wilson");
            //}

            //Console.WriteLine();
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}

            // Binary search by name 
            //    List<string> students = new List<string>();

            //    students.Add("Sally_Buk");
            //    students.Add("Noah_Bukly");
            //    students.Add("John_Brown");
            //    students.Add("Ann_Smith");

            //    int Student1 = 5;
            //    Display(students);

            //    StudentNameComparer dc = new StudentNameComparer();

            //    Console.WriteLine("\nSort a range with the alternate comparer:");
            //    students.Sort(0, Student1, dc);
            //    Display(students);

            //    Console.WriteLine("\nBinarySearch a range and Insert \"{0}\":",
            //        "Jeremy_Wilson");

            //    int index = students.BinarySearch(0, Student1, "jeremy_Wilson", dc);

            //    if (index < 0)
            //    {
            //        students.Insert(~index, "Samuel_Fisher");
            //        Student1++;
            //    }

            //    Display(students);
            //}

            //private static void Display(List<string> list)
            //{
            //    Console.WriteLine();
            //    foreach (string s in list)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}


            // Bubble Sort 
            String[] arr = {"Alice_Reimer", "Crystal_Murphy",
                        "Ella_Wilson", "Markus_Harsch", "Olivia_Crescitelli"};
            int n = arr.Length;
            sortStudentName(arr, n);
            Console.WriteLine("Strings in sorted order are : ");
            for (int i = 0; i < n; i++)
                Console.WriteLine("String " + (i + 1) +
                                  " is " + arr[i]);
        }

        private static void sortStudentName(string[] arr, int n)
        {
            //throw new NotImplementedException();
        }
    }



    //string[] arr1;
    //string temp;
    //int n, i, j, l;

    //Console.Write("\n\nSorts the strings of an array using bubble sort :\n");
    //Console.Write("-----------------------------------------------------\n");
    //Console.Write("Input number of strings :");
    //n = Convert.ToInt32(Console.ReadLine());
    //arr1 = new string[n];
    //Console.Write("Input {0} strings below :\n", n);
    //for (i = 0; i < n; i++)
    //{
    //    arr1[i] = Console.ReadLine();
    //}
    //l = arr1.Length;

    //for (i = 0; i < l; i++)
    //{
    //    for (j = 0; j < l - 1; j++)
    //    {
    //        if (arr1[j].CompareTo(arr1[j + 1]) > 0)
    //        {
    //            temp = arr1[j];
    //            arr1[j] = arr1[j + 1];
    //            arr1[j + 1] = temp;
    //        }
    //    }
    //}
    //Console.Write("\n\nAfter sorting the array appears like : \n");
    //for (i = 0; i < l; i++)
    //{
    //    Console.WriteLine(arr1[i] + " ");
    //}
}
    
    

   
