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
    public class JobRepository:IJobRepository
    {
        private readonly DataContext _context;

        public JobRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Job> GetAll()
        {
            return _context.Jobs.Where(s => !string.IsNullOrEmpty(s.Title)).Include(s => s.Employer);
        }

        public Job Get(int id)
        {
            return _context.Jobs.Include(s => s.Employer).First(s => s.JobID == id);
        }

        public Job Add(Job job)
        {
            _context.Jobs.Add(job);
            _context.SaveChanges();
            return job;
        }
    }
}
