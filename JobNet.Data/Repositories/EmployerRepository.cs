using JobNet.Core.Entities;
using JobNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Data.Repositories
{
    public class EmployerRepository:IEmployerRepository
    {
        private readonly DataContext _context;

        public EmployerRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Employer> GetAll()
        {
            return _context.Employers.Where(e => !string.IsNullOrEmpty(e.CompanyName));
        }

        public Employer Get(int id)
        {
            return _context.Employers.FirstOrDefault(s => s.EmployerID == id);
        }

        public Employer Add(Employer employer)
        {
            _context.Employers.Add(employer);
            _context.SaveChanges();
            return employer;
        }
    }
}
