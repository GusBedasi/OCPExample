using System;
using System.Collections.Generic;
using OCPLibrary.Services.EmployeesServices.Contract;

namespace OCPLibrary.Services.EmployeesServices
{
    public class EmployeeService : IEmployeeService
    {
        public List<EmployeeModel> Hire(List<IApplicationModel> applicants)
        {
            var employees = new List<EmployeeModel>();
            
            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }
            
            return employees;
        }
    }
}