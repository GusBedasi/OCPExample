namespace OCPLibrary
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicationModel application)
        {
            var employee = new EmployeeModel();

            employee.FirstName = application.FirstName;
            employee.LastName = application.LastName;
            employee.EmailAddress = $"{application.FirstName}{application.LastName}@acmecorp.com";

            employee.IsManager = true;
            
            return employee;
        }
    }
}