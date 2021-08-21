using System.Collections.Generic;

namespace OCPLibrary.Services.EmployeesServices.Contract
{
    public interface IEmployeeService
    {
        List<EmployeeModel> Hire(List<IApplicationModel> applicants);
    }
}