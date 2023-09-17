﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Config
{
    public class IdentityRoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole() { Name = "User", NormalizedName = "USER" },
                new IdentityRole() { Name = "Company", NormalizedName = "COMPANY" },
                new IdentityRole() { Name = "Customer", NormalizedName = "CUSTOMER" },
                new IdentityRole() { Name = "Admin", NormalizedName = "ADMIN" }
            );
        }
    }
}
