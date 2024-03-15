namespace ConsoleApp3
{
    public class InformDepartment : Department
    {
        public InformDepartment(string title, List<Person> employess, int numberOfVacanties) : base(title, employess, numberOfVacanties)
        {
        }
        public override void StaffSelection(List<Person> candidates)
        {
            for (int i = 0; i < candidates.Count; i++)
            {
                if (candidates[i].PersonSpeciality == Speciality.Mathematician && candidates[i].Score >= 4.8 && candidates[i].Age > 22)
                {
                    Employess.Add(candidates[i]);
                    candidates.RemoveAt(i);
                }
                if (candidates[i].PersonSpeciality == Speciality.Programmer && candidates[i].Score >= 4.8 && candidates[i].Age > 22)
                {
                    Employess.Add(candidates[i]);
                    candidates.RemoveAt(i);
                }
            }
            Console.WriteLine(Title + ":");
            for (int i = 0; i < Employess.Count; i++)
            {
                Console.Write(Employess[i].Name);
                if (Employess[i].PersonSpeciality == Speciality.Mathematician) { Console.WriteLine(" - Математик, средний балл: " + Employess[i].Score + ", возраст: " + Employess[i].Age); } 
                else { Console.WriteLine(" - Программист, средний балл: " + Employess[i].Score + ", возраст: " + Employess[i].Age); }
            }
            Console.WriteLine("---------");
        }
    }
}