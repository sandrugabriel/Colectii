using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Models
{
    public class User : IComparable<User>
    {

        private int _id;
        private string _name;
        private int _age;

        public User(int id, string name, int age)
        {
            _id = id;
            _name = name;
            _age = age;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public int CompareTo(User? other)
        {
            if (Age > other.Age) return 1;
            else if (Age == other.Age) return 0;
            else return -1;
        }

        public string descriere()
        {
            string t = "";

            t += $"Id: {Id}";
            t += $"Name: {Name}";
            t += $"Age: {Age}";

            return t;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return descriere();
        }
    }
}
