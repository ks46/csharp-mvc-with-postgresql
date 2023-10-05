using exercise.api.Models;

namespace exercise.api.Repository
{
    public interface IRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployee(int id);
    }
}
