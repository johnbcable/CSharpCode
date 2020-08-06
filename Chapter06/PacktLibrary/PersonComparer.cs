using System.Collections.Generic;

namespace Packt.Shared
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y) 
        {
            // Compare the name lengths ...
            int result = x.Name.Length.CompareTo(y.Name.Length);
            // if they are equal
            if (result == 0) 
            {
                // ... then compare by Name
                return x.Name.CompareTo(y.Name);
            } 
            else 
            {
                // .. return result of comparing by the lengths
                return result;
            }
        }
    }
}