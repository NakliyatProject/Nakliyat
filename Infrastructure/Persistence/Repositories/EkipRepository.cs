using Application.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class EkipRepository : RepositoryBase<Ekip>, IEkipRepository
    {
        public EkipRepository(NakliyatDbContext context) : base(context)
        {
        }
    }
}
