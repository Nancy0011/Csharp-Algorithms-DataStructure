using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
    {
        public class Enrollment
    {
            public string DateEnrolled { get; set; }
            public string Grade { get; set; }
            public string Semester { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                if (ReferenceEquals(obj, this))
                    return true;
                if (obj.GetType() != this.GetType())
                    return false;
                Enrollment otherEnrollment = obj as Enrollment;
                return (this.DateEnrolled == otherEnrollment.DateEnrolled 
                && this.Grade == otherEnrollment.Grade && this.Semester == otherEnrollment.Semester);

            }

            public override int GetHashCode()
            {
                return this.DateEnrolled.GetHashCode() ^ this.Grade.GetHashCode() ^ this.Semester.GetHashCode();
            }
        }
    }
