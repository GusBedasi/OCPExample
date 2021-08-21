namespace OCPLibrary
{
    public class ExecutiveAccounts: IAccounts
    {
        public EmployeeModel Create(IApplicationModel application)
        {
            var employee = new EmployeeModel();

            employee.FirstName = application.FirstName;
            employee.LastName = application.LastName;
            employee.EmailAddress = $"{application.FirstName.Substring(0, 1)}.{application.LastName}@acmecorp.com";

            employee.IsManager = true;
            employee.IsExecutive = true;
            
            return employee;
        }
    }
}