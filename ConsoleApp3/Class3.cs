using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Department
    {
        public string Title { get; set; } = "";
        public List<Person> Employess { get; set; } = [];
        public int NumberOfVacanties { get; set; } = 5;
        public Department(string title, List<Person> employess, int numberOfVacanties)
        {
            Title = title;
            Employess = employess;
            NumberOfVacanties = numberOfVacanties;
        }
       public virtual void StaffSelection(List<Person> candidates)
        {
            for (int i = 0; i < candidates.Count; i++)
            {
                if (candidates[i].Score > 3.0)
                {
                    Employess.Add(candidates[i]);
                    candidates.RemoveAt(i);
                }
            }
        }
    }
}