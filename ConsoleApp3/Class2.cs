using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Factory()
    {
        private static readonly List<Person> value =
            [
            new Person("Сергей",34, Speciality.Electrician, 4.9),
            new Person("Алина",25, Speciality.Mechanic, 4.4),
            new Person("Костя",48, Speciality.Mathematician, 5),
            new Person("Маша",33, Speciality.Lawyer, 4.4),
            new Person("Даря", 28, Speciality.Mathematician, 4.8),
            new Person("Леха", 24, Speciality.Programmer, 5.0),
            new Person("Чинчопа", 22, Speciality.Electrician, 4.6),
            new Person("Валера", 27, Speciality.Mechanic, 4.0),
            new Person("Радомир", 21, Speciality.Mathematician, 4.9)
            ];
        static public List<Person> Candidates = value;
        static public List<Department> Departments { get; set; } =
            [
            new ElectricianDepartment("Энергетическое подразделение",[],5),
            new MechanicDepartmet("Ремонтно-механическое подразделение",[],5),
            new InformDepartment("Диспетчерское подразделение",[],5)
            ];
    }
}