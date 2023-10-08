using exercise.api.Data;
using exercise.api.Models;

namespace exercise.api.Repository
{
    public class Repository : IRepository
    {
        public IEnumerable<Employee> GetEmployees()
        {
            using (var db = new DataContext())
            {
                return db.Employees.ToList();
            }
            return null;
        }

        public Employee? GetEmployee(int id)
        {
            using (var db = new DataContext())
            {
                return db.Employees.FirstOrDefault(e => e.Id == id);
            }
            return null;
        }

        public Employee InsertEmployee(Employee employee)
        {
            using (var db = new DataContext())
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return employee;
            }
            return null;
        }

        public Employee? UpdateEmployee(int id, Employee employee)
        {
            using (var db = new DataContext())
            {
                var result = db.Employees.FirstOrDefault(e => e.Id == id);
                if (result != null)
                {
                    db.Employees.Attach(result);
                    result.Name = employee.Name;
                    result.JobName = employee.JobName;
                    result.SalaryGrade = employee.SalaryGrade;
                    result.Department = employee.Department;
                    db.SaveChanges();
                    return result;
                }
            }
            return null;
        }

        public Employee? DeleteEmployee(int id)
        {
            using (var db = new DataContext())
            {
                var result = db.Employees.FirstOrDefault(e => e.Id == id);
                if (result != null)
                {
                    db.Remove(result);
                    db.SaveChanges();
                    return result;
                }
            }
            return null;
        }
    }
}
