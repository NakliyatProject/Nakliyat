using Application.Repositories;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class TasimaTalebiRepository : RepositoryBase<TasimaTalebi>, ITasimaTalebiRepository
    {
        public TasimaTalebiRepository(NakliyatDbContext context) : base(context)
        {
        }
    }
}
