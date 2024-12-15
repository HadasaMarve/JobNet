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

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return await _UserRepository.GetAllAsync();
        }

        public User Get(int id)
        {
            return _UserRepository.Get(id);
        }

        public async Task<User> AddAsync(User user)
        {
            return await _UserRepository.AddAsync(user);
        }
    }
}
