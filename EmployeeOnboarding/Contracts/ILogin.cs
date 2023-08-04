using EmployeeOnboarding.Data;

namespace EmployeeOnboarding.Contracts
{
    public interface ILogin
    {
        Task<IEnumerable<Login>> getemp();
        Task<Login> AuthenticateEmp(string emailid, string password);
    }
}
