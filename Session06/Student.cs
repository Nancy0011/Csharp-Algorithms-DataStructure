using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Program { get; set; }
        public string DateRegistered { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Student otherStudent = obj as Student;
            return (this.StudentID == otherStudent.StudentID
                && this.Program == otherStudent.Program && this.DateRegistered == otherStudent.DateRegistered);
        }
        public override int GetHashCode()
        {
            return this.StudentID.GetHashCode() ^ this.Program.GetHashCode() ^ this.DateRegistered.GetHashCode();
        }
    }
}
