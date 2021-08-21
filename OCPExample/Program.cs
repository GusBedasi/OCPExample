using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OCPLibrary.Messages;
using OCPLibrary.Services;
using OCPLibrary.Services.EmployeesServices;
using OCPLibrary.Services.EmployeesServices.Contract;
using OCPLibrary.Services.HumanResourceServices;
using OCPLibrary.Services.HumanResourceServices.Contracts;
using OCPLibrary.Services.RegisterServices;

namespace OCPExample
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var services = ConfigureService();
            var servicesProvider = services.BuildServiceProvider();

            var registerService = servicesProvider.GetService<IRegisterService>() ?? throw new Exception("The service cannot be null");
            var employeeService = servicesProvider.GetService<IEmployeeService>()  ?? throw new Exception("The service cannot be null");
            var humanResourceService = servicesProvider.GetService<IHumanResourceService>()  ?? throw new Exception("The service cannot be null");
            
            
            var applicants = registerService.CreateRegistry();
            var employees = employeeService.Hire(applicants);
            humanResourceService.GetStaffList(employees);
            StandardMessages.EndApplicationMessage();
        }

        private static IServiceCollection ConfigureService()
        {
            var services = new ServiceCollection();

            services
                .AddTransient<IRegisterService, RegisterService>()
                .AddTransient<IEmployeeService, EmployeeService>()
                .AddTransient<IHumanResourceService, HumanResourceService>();

            return services;
        }
    }
}