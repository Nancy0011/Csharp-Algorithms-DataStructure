using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int TelNum { get; set; }

        public override bool Equals (object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Person otherPerson = obj as Person;
            return (this.Name == otherPerson.Name && this.Email == otherPerson.Email && this.TelNum == otherPerson.TelNum);
            
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Email.GetHashCode() ^ this.TelNum.GetHashCode();
        }
    }
}
