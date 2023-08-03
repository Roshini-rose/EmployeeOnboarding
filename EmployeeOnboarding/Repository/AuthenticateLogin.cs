using EmployeeOnboarding.Contracts;
using EmployeeOnboarding.Data;

namespace EmployeeOnboarding.Repository
{
    public class AuthenticateLogin : ILogin
    {
        private readonly ApplicationDbContext _context;

        public AuthenticateLogin(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Login> AuthenticateEmp(string email, string password)
        {
            var succeeded = _context.Logins.FirstOrDefault(authUser => authUser.Emailid == email && authUser.Password == password);
            return succeeded;
        }

        public async Task<IEnumerable<Login>> getemp()
        {
            return _context.Logins.ToList();
        }
    }
}
