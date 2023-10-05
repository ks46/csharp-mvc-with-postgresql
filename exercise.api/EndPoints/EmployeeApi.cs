using exercise.api.Models;
using exercise.api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.api.EndPoints
{
    public static class EmployeeApi
    {
        public static void ConfigureEmployeeApi(this WebApplication app)
        {
            app.MapGet("/employees", GetEmployees);
            app.MapGet("/employees/{id}", GetEmployee);
        }

        /// <summary>Get all employees</summary>
        /// <returns>
        /// Status 200 - Successfully returned a list of all employees
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetEmployees(IRepository service)
        {
            return Results.Ok(service.GetEmployees());
        }

        /// <summary>Get an employee</summary>
        /// <returns>
        /// Status 200 - Successfully returned the specified employee
        /// Status 404 - No employees with that id were found
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetEmployee(int id, IRepository service)
        {
            Employee e = service.GetEmployee(id);
            if (e == null)
                return Results.NotFound();
            return Results.Ok(e);
        }
    }
}
