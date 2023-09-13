using Application.Repositories;
using Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly IUserService _userService;

        public ServiceManager(IUserService userService)
        {
            _userService = userService;
        }

        public IUserService UserService => _userService;

        public IUserService CompanyService 
        {
            set
            {
                CompanyService = _userService;
            }
        }
    }
}
