using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session16
{
    public class Address
    {
        public int Number { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public int Postcode { get; set; }
        public string State { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Address otherAddress = obj as Address;
            return (this.Number == otherAddress.Number
                && this.Street == otherAddress.Street 
                && this.Suburb == otherAddress.Suburb
                && this.Postcode == otherAddress.Postcode
                && this.State == otherAddress.State);
        }
        public override int GetHashCode()
        {
            return this.Number.GetHashCode() ^ this.Street.GetHashCode() 
                 ^ this.Suburb.GetHashCode() ^ this.Postcode.GetHashCode()
                 ^ this.State.GetHashCode();
        }
    }
}
