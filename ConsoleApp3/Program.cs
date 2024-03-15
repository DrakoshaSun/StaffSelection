using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main() {
        Factory.Departments[0].StaffSelection(Factory.Candidates);
        Factory.Departments[1].StaffSelection(Factory.Candidates);
        Factory.Departments[2].StaffSelection(Factory.Candidates);
        Console.WriteLine("Нетрудоустроенные:");
        var Specialities = new Dictionary<Speciality, string>()
        {
            { Speciality.Electrician, "Электрик" },
            { Speciality.Mechanic, "Механик" },
            { Speciality.Mathematician, "Математик" },
            { Speciality.Programmer, "Программист" },
            { Speciality.Lawyer, "Юрист" }
        };
        foreach (Person person in Factory.Candidates)
        {
            Console.WriteLine(person.Name + $" - {Specialities[person.PersonSpeciality]}" + ", средний балл: " + person.Score + ", возраст: " + person.Age);
        }
    }

}
