using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    public class Person
    {
        private int v1;
        private string v2;
        private string v3;
        private string v4;

        public Person(int v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNum { get; set; }

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
            return this.Name.GetHashCode() ^ this.Email.GetHashCode();
        }
    }
}
