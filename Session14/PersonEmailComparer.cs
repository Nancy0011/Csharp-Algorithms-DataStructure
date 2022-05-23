using System;
using System.Collections.Generic;
using System.Text;

namespace Session16
{
    class PersonEmailComparer : Comparer<Person>
    {
        private static PersonEmailComparer _instance = new PersonEmailComparer();
        public static PersonEmailComparer Instance { get { return _instance; } }
        private PersonEmailComparer() { }

        public override int Compare(Person x, Person y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            return string.Compare(x.Email, y.Email, StringComparison.CurrentCulture);
        }

    }
}
