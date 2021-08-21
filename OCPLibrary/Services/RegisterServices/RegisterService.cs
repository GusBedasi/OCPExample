using System.Collections.Generic;

namespace OCPLibrary.Services.RegisterServices
{
    public class RegisterService : IRegisterService
    {
        public List<IApplicationModel> CreateRegistry()
        {
            var applicants = new List<IApplicationModel>
            {
                new ApplicationModel() {FirstName = "Gustavo", LastName = "Melo"},
                new ManagerModel() {FirstName = "Nicolle", LastName = "Oliveira"},
                new ExecutiveModel() { FirstName = "Teste", LastName =  "Testado"}
            };

            return applicants;
        }
    }
}