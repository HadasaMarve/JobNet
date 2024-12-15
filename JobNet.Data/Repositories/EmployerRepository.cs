using JobNet.Core.Entities;
using JobNet.Core.Repositories;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Employer>> GetAllAsync()
        {
            return await _context.Employers.Where(e => !string.IsNullOrEmpty(e.CompanyName)).ToListAsync();
        }

        public Employer Get(int id)
        {
            return _context.Employers.FirstOrDefault(s => s.EmployerID == id);
        }

        public async Task<Employer> AddAsync(Employer employer)
        {
            _context.Employers.Add(employer);
            await _context.SaveChangesAsync();
            return employer;
        }
    }
}
