using exercise.api.Models;

namespace exercise.api.Data
{
    public static class Seeder
    {
        public static List<string> Names = new List<string>()
        {
            "Nigel",
            "Dave",
            "Nathan"
        };

        public static void Seed(this WebApplication app)
        {
            using (var db = new DataContext())
            {
                if (!db.Employees.Any())
                {
                    for (int i = 1; i <= Names.Count; i++)
                    {
                        db.Employees.Add(new Employee() { Id = i, Name = Names[i-1], JobName = "Software Engineer", SalaryGrade = "8", Department = "Software Development" });
                    }
                    db.SaveChanges();
                }
            }
        }
    }
}
