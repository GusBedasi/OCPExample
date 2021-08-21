using System.Collections.Generic;

namespace OCPLibrary.Services
{
    public interface IRegisterService
    {
        List<IApplicationModel> CreateRegistry();
    }
}