using System.Collections.Generic;

namespace OCPLibrary.Services.HumanResourceServices.Contracts
{
    public interface IHumanResourceService
    {
        void GetStaffList(List<EmployeeModel> employees);
    }
}