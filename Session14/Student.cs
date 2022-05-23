using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    public class Student
    {
        
        public int StudentID;
        public string Program;
        

        public Student(int StudentID, string Program)
        {
            this.StudentID = StudentID;
            this.Program = Program;
            
        }

        public override string ToString()
        {
            return (this.StudentID + " " + this.Program);
        }

    }
    }
