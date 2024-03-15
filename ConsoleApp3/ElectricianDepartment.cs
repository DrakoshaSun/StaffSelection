namespace ConsoleApp3
{
    public class ElectricianDepartment : Department
    {
        public ElectricianDepartment(string title, List<Person> employess, int numberOfVacanties) : base(title, employess, numberOfVacanties)
        {
        }
        public override void StaffSelection(List<Person> candidates)
        {
            for (int i = 0; i < candidates.Count; i++)
            {
                if (candidates[i].PersonSpeciality == Speciality.Electrician && candidates[i].Score >= 4.5)
                {
                    Employess.Add(candidates[i]);
                    candidates.RemoveAt(i);
                }
            }
            Console.WriteLine(Title + ":");
            for (int i = 0; i < Employess.Count; i++)
            {
                Console.WriteLine(Employess[i].Name + " - Электрик, средний балл: " + Employess[i].Score + ", возраст: " + Employess[i].Age);
            }
            Console.WriteLine("---------");
        }
    }
}