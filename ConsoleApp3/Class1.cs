using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public enum Speciality
    {
        Electrician,
        Mechanic,
        Mathematician,
        Programmer,
        Lawyer
    }

    public class Person(string Name, int Age, Speciality PersonSpeciality, double Score)
    {
        public readonly string Name = Name;
        public readonly int Age = Age;
        public Speciality PersonSpeciality = PersonSpeciality;
        public readonly double Score = Score;
    }
}