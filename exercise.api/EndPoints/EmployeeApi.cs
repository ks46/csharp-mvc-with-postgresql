using exercise.api.Models;
using exercise.api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.api.EndPoints
{
    public static class EmployeeApi
    {
        public static void ConfigureEmployeeApi(this WebApplication app)
        {
            app.MapPost("/employees", InsertEmployee);
            app.MapGet("/employees", GetEmployees);
            app.MapGet("/employees/{id}", GetEmployee);
            app.MapPut("/employees/{id}", UpdateEmployee);
            app.MapDelete("/employees/{id}", DeleteEmployee);
        }

        /// <summary>Create a new employee</summary>
        /// <returns>
        /// Status 201 - Successfully created a new employee
        /// or
        /// Status 400 - Could not create employee, please check all required fields are correct
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> InsertEmployee(Employee employee, IRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Employee e = service.InsertEmployee(employee);
                    if (e == null)
                        return Results.BadRequest();
                    return Results.Ok(e);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        /// <summary>Get all employees</summary>
        /// <returns>
        /// Status 200 - Successfully returned a list of all employees
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetEmployees(IRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    return Results.Ok(service.GetEmployees());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        /// <summary>Get an employee</summary>
        /// <returns>
        /// Status 200 - Successfully returned the specified employee
        /// or
        /// Status 404 -  No employee with that id was found
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetEmployee(int id, IRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Employee e = service.GetEmployee(id);
                    if (e == null)
                        return Results.NotFound();
                    return Results.Ok(e);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        /// <summary>Update an employee</summary>
        /// <returns>
        /// Status 201 - Successfully updated the specified employee
        /// or
        /// Status 400 - Could not update the employee, please check all required fields are correct
        /// Status 404 - No employee with that id was found
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateEmployee(int id, Employee employee, IRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Employee e = service.UpdateEmployee(id, employee);
                    if (e == null)
                        return Results.NotFound();
                    return Results.Ok(e);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        /// <summary>Delete an employee</summary>
        /// <returns>
        /// Status 200 - Successfully deleted the specified employee
        /// or
        /// Status 404 -  No employee with that id was found
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteEmployee(int id, Employee employee, IRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Employee e = service.DeleteEmployee(id, employee);
                    if (e == null)
                        return Results.NotFound();
                    return Results.Ok(e);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
