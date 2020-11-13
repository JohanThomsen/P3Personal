using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Opgaver
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public int CompareTo([AllowNull] Person other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
