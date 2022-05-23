using System;
using System.Collections.Generic;
using System.Text;

namespace Session14
{
    class StudentIDComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            return x.StudentID - y.StudentID;
        }
    }
}

