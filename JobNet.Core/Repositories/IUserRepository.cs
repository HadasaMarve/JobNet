using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.Repositories
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAll();

        public User Get(int id);

        public User Add(User user);

    }
}
