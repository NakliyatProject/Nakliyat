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
        private readonly IUserService _userService;

        private readonly IAuthService _authService;

        public ServiceManager(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        public IUserService UserService => _userService;

        public IUserService CompanyService 
        {
            set
            {
                CompanyService = _userService;
            }
        }

        public IAuthService AuthService => _authService;
    }
}
