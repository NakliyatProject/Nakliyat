﻿using Application.Repositories;
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
        private readonly ICustomerService _customerService;

        private readonly ITasimaTalebiService _tasimaTalebiService;
        
        private readonly IEkipService _ekipService;

        private readonly IAuthService _authService;
        public ServiceManager(ICustomerService customerService, ITasimaTalebiService tasimaTalebiService, IAuthService authService, IEkipService ekipService)
        {
            _customerService = customerService;
            _tasimaTalebiService = tasimaTalebiService;
            _authService = authService;
            _ekipService = ekipService;
        }




        public ICustomerService CustomerService => _customerService;
        public IAuthService AuthService => _authService;
        public ITasimaTalebiService TasimaTalebiService => _tasimaTalebiService;
        public IEkipService EkipService => _ekipService;
    }
}
