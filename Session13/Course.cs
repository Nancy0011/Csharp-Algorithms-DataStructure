using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Cost { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Course otherCourse = obj as Course;
            return (this.CourseName == otherCourse.CourseName 
                && this.CourseName == otherCourse.CourseName 
                && this.Cost == otherCourse.Cost);

        }

        public override int GetHashCode()
        {
            return this.CourseCode.GetHashCode() ^ this.CourseName.GetHashCode() ^ this.Cost.GetHashCode();
        }
    }
}
