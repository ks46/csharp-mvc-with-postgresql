using exercise.api.Models;

namespace exercise.api.Repository
{
    public class Repository : IRepository
    {
        public IEnumerable<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee InsertEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee DeleteEmployee(int id, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
