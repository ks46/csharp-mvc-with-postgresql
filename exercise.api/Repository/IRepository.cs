using exercise.api.Models;

namespace exercise.api.Repository
{
    public interface IRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();
        Employee InsertEmployee(Employee employee);
        Employee UpdateEmployee(int id, Employee employee);
        Employee DeleteEmployee(int id, Employee employee);
    }
}
