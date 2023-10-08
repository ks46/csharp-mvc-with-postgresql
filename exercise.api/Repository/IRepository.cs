using exercise.api.Models;

namespace exercise.api.Repository
{
    public interface IRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee? GetEmployee(int id);
        Employee InsertEmployee(Employee employee);
        Employee? UpdateEmployee(int id, Employee employee);
        Employee? DeleteEmployee(int id);
    }
}
