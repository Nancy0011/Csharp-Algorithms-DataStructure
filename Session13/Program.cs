using System;

namespace Session16
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student
            //Student s1 = new Student();
            //Student s2 = new Student();
            //s1.StudentID = 000999111;
            //s1.Program = "Study";
            //s1.DateRegistered = "09/02/2020";

            //s2.StudentID = 000999111;
            //s2.Program = "Study";
            //s2.DateRegistered = "09/02/2020";

            //Console.WriteLine(s1.Equals(s2));
            //Console.WriteLine(s1==s2);



            //Person
            //Person p1 = new Person();
            //Person p2 = new Person();
            //p1.Name = "Noah Bulk";
            //p1.Email = "NoahBulk@gmail.com";
            //p1.TelNum = 0411110220;

            //p2.Name = "Noah Bulk";
            //p2.Email = "NoahBulk@gmail.com";
            //p2.TelNum = 0411110220;

            //Console.WriteLine(p1.Equals(p2));
            //Console.WriteLine(p1==p2);


            //Address


            //Address a1 = new Address();
            //Address a2 = new Address();
            //a1.Number = 5;
            //a1.Street = "Myall Street";
            //a1.Suburb = "Magill";
            //a1.Postcode = 5072;
            //a1.State = "SA";

            //a2.Number = 5;
            //a2.Street = "Myall Street";
            //a2.Suburb = "Magill";
            //a2.Postcode = 5072;
            //a2.State = "SA";

            //Console.WriteLine(a1.Equals(a2));
            //Console.WriteLine(a1 == a2);

            //  Enrollment
            //Enrollment e1 = new Enrollment();
            //Enrollment e2 = new Enrollment();

            //e1.DateEnrolled = "07/05/2020";
            //e1.Grade = "C4";
            //e1.Semester = "S2";
            //e2.DateEnrolled = "07/05/2020";
            //e2.Grade = "C4";
            //e2.Semester = "S2";

            //Console.WriteLine(e1.Equals(e2));
            //Console.WriteLine(e1 == e2);

            // Course
            Course c1 = new Course();
            Course c2 = new Course();

            c1.CourseCode = "000999";
            c1.CourseName = "3PRB";
            c1.Cost = 300;

            c2.CourseCode = "000999";
            c2.CourseName = "3PRB";
            c2.Cost = 300;

            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c1 == c2);
        }
    }
}
