
using System;
using System.Collections.Generic;

namespace Session16
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 2:
            //Student
            String  StudentID = "000999111";
            String Program = "Study";

            DisplayOrder(StudentID, Program);
            DisplayOrder(Program, StudentID);
            DisplayOrder(StudentID, StudentID);

            DisplayOrder(3, 4);
            DisplayOrder(4, 3);
            DisplayOrder(3, 3);
        }
        static void DisplayOrder<T>(T x, T y) where T : IComparable<T>
        {
            int result = x.CompareTo(y);
            if (result == 0)
                Console.WriteLine("{0,12} = {1}", x, y);
            else if (result > 0)
                Console.WriteLine("{0,12} > {1}", x, y);
            else
                Console.WriteLine("{0,12} < {1}", x, y);
  

        // Person

        //    String Name = "John Brown";
        //    String Email = "John_Brown@gmail.com";

        //    DisplayOrder(Name, Email);
        //    DisplayOrder(Email, Name);
        //    DisplayOrder(Name, Name);

        //    DisplayOrder(3, 4);
        //    DisplayOrder(4, 3);
        //    DisplayOrder(3, 3);
        //}
        //static void DisplayOrder<T>(T x, T y) where T : IComparable<T>
        //{
        //    int result = x.CompareTo(y);
        //    if (result == 0)
        //        Console.WriteLine("{0,12} = {1}", x, y);
        //    else if (result > 0)
        //        Console.WriteLine("{0,12} > {1}", x, y);
        //    else
        //        Console.WriteLine("{0,12} < {1}", x, y);
        //}

        //    // Address

        //    String Suburb = "Magill";
        //    String Street = "Myall Avenue";

        //    DisplayOrder(Suburb, Street);
        //    DisplayOrder(Street, Suburb);
        //    DisplayOrder(Suburb, Suburb);

        //    DisplayOrder(3, 4);
        //    DisplayOrder(4, 3);
        //    DisplayOrder(3, 3);
        //}
        //static void DisplayOrder<T>(T x, T y) where T : IComparable<T>
        //{
        //    int result = x.CompareTo(y);
        //    if (result == 0)
        //        Console.WriteLine("{0,12} = {1}", x, y);
        //    else if (result > 0)
        //        Console.WriteLine("{0,12} > {1}", x, y);
        //    else
        //        Console.WriteLine("{0,12} < {1}", x, y);
        //}

        //    // Enrollment

        //    String Grade = "Grade2";
        //    String Semester = "S2";

        //    DisplayOrder(Grade, Semester);
        //    DisplayOrder(Semester, Grade);
        //    DisplayOrder(Grade, Grade);

        //    DisplayOrder(3, 4);
        //    DisplayOrder(4, 3);
        //    DisplayOrder(3, 3);
        //}
        //static void DisplayOrder<T>(T x, T y) where T : IComparable<T>
        //{
        //    int result = x.CompareTo(y);
        //    if (result == 0)
        //        Console.WriteLine("{0,12} = {1}", x, y);
        //    else if (result > 0)
        //        Console.WriteLine("{0,12} > {1}", x, y);
        //    else
        //        Console.WriteLine("{0,12} < {1}", x, y);
        //}


        //    // Course

        //    String CourseCode = "SEFD0989";
        //    String CourseName = "3PRB";

        //    DisplayOrder(CourseCode, CourseName);
        //    DisplayOrder(CourseName, CourseCode);
        //    DisplayOrder(CourseCode, CourseCode);

        //    DisplayOrder(3, 4);
        //    DisplayOrder(4, 3);
        //    DisplayOrder(3, 3);
        //}
        //static void DisplayOrder<T>(T x, T y) where T : IComparable<T>
        //{
        //    int result = x.CompareTo(y);
        //    if (result == 0)
        //        Console.WriteLine("{0,12} = {1}", x, y);
        //    else if (result > 0)
        //        Console.WriteLine("{0,12} > {1}", x, y);
        //    else
        //        Console.WriteLine("{0,12} < {1}", x, y);
        //}

        ////Question 4

        //Person[] list =
        //{
        //    new Person(000111, "Noah_Brown", "Noah_Brown@gmail.com", "0410111222"),
        //    new Person(000222, "Amy_Smith", "Amy_Smith@gmail.com", "0410111002"),
        //    new Person(000333, "Sally_Buk", "Sally_Buk@gmail.com", "0410111333"),
        //    new Person(000444, "John_Bukly", "John_Bukly@gmail.com", "0410111444")
        //};

        //Array.Sort(list, PersonNameComparer.Instance);
        //Array.Sort(list, PersonEmailComparer.Instance);
        //Array.Sort(list, PersonTelNumComparer.Instance);

        //foreach (var item in list)
        //    Console.WriteLine(item);

        //// Question 7 Hast Set

        //var person = new HashSet<Person>();
        //person.Add(new Person(000155, "Ann_Brown", "Ann_Brown@gmail.com", "0410111555"));
        //person.Add(new Person(000166, "Jane_Bob", "Jane_Bob@gmail.com", "0410111666"));

        //foreach (var Person in person)
        //    Console.WriteLine(Person);


    }
    }
}


