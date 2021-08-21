using System;
using System.Collections.Generic;
using OCPLibrary.Services.HumanResourceServices.Contracts;

namespace OCPLibrary.Services.HumanResourceServices
{
    public class HumanResourceService : IHumanResourceService
    {
        public void GetStaffList(List<EmployeeModel> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress} IsManager: {employee.IsManager} IsExecutive: {employee.IsExecutive}");
            }
        }
    }
}