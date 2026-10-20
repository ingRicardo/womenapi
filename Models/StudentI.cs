using System;

namespace WebWomen.Models
{
    public class StudentI : IComparable<StudentI>
    {
        public int Roll;
        public string Name;
        public string Address;

        public StudentI(int roll, string name, string address)
        {
            Roll = roll;
            Name = name;
            Address = address;
        }

        public int CompareTo(StudentI other)
        {
            if (other == null) return 1;
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{Roll} {Name} {Address}";
        }
    }
}
