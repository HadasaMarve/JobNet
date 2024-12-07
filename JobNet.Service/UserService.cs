using JobNet.Core.Entities;
using JobNet.Core.Services;
using JobNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Service
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _UserRepository;
        public UserService(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public IEnumerable<User> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _UserRepository.GetAll();
        }

        public User Get(int id)
        {
            return _UserRepository.Get(id);
        }

        public User Add(User user)
        {
            return _UserRepository.Add(user);
        }
    }
}
