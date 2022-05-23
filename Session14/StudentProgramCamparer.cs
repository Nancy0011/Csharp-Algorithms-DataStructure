using System;
using System.Collections.Generic;
using System.Text;

namespace Session14
{
    class StudentProgramCamparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            return string.Compare(x.Program, y.Program, true);
        }
    }


}
