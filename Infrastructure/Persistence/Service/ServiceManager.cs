using Application.Repositories;
using Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly ICustomerService _userService;

        private readonly IAuthService _authService;

        public ServiceManager(ICustomerService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        public ICustomerService UserService => _userService;

        public ICustomerService CompanyService 
        {
            set
            {
                CompanyService = _userService;
            }
        }

        public IAuthService AuthService => _authService;
    }
}
