using JobNet.Core.Entities;
using JobNet.Core.Repositories;
using JobNet.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Service
{
    public class EmployerService: IEmployerService
    {

        private readonly IEmployerRepository _EmployerRepository;
        public EmployerService(IEmployerRepository employerRepository)
        {
            _EmployerRepository = employerRepository;
        }


        public async Task<IEnumerable<Employer>> GetAllAsync()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return await _EmployerRepository.GetAllAsync();
        }

        public Employer Get(int id)
        {
            return _EmployerRepository.Get(id);
        }

        public async Task<Employer> AddAsync(Employer employer)
        {
            return await _EmployerRepository.AddAsync(employer);
        }

        public async Task<Employer> DeleteAsync(int id)
        {
            return await _EmployerRepository.DeleteAsync(id);
        }
    }
}
