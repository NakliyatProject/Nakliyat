﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Common
{
    public class ProjectException : Exception
    {
        public ProjectException() { }

        public ProjectException(string message) : base(message) { }
    }
}
