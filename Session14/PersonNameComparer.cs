using Session16;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Session16
{
    class PersonNameComparer : Comparer<Person>
    {
        private static PersonNameComparer _instance = new PersonNameComparer();
        public static PersonNameComparer Instance { get { return _instance; } }
        private PersonNameComparer() { }

        public override int Compare(Person x, Person y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            return string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
        }
    }
}
    