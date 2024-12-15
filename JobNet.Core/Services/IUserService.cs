using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetAllAsync();

        public User Get(int id);

        public Task<User> AddAsync(User user);
    }
}
