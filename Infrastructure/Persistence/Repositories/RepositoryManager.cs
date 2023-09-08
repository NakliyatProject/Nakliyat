using Application.Repositories;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly NakliyatDbContext _context;

        private readonly IUserRepository _userRepository;

        public RepositoryManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IUserRepository UserRepository => _userRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
