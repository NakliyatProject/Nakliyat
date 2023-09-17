using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class CompanyRegisterDto
    {
        public String? CompanyName { get; init; }

        public String? Email { get; init; }

        public String? Password { get; init; }
        public int EkipSayisi { get; set; }
    }
}
