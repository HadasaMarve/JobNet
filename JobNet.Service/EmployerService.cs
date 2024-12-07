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


        public IEnumerable<Employer> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _EmployerRepository.GetAll();
        }

        public Employer Get(int id)
        {
            return _EmployerRepository.Get(id);
        }

        public Employer Add(Employer employer)
        {
            return _EmployerRepository.Add(employer);
        }
    }
}
