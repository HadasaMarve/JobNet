﻿using JobNet.Core.Entities;
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
        public async Task<IEnumerable<Job>> GetAllAsync()
        {
            return await _context.Jobs.Where(s => !string.IsNullOrEmpty(s.Title)).Include(s => s.Employer).ToListAsync();
        }

        public Job Get(int id)
        {
            return _context.Jobs.Include(s => s.Employer).First(s => s.JobID == id);
        }

        public async Task<Job> AddAsync(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task<Job> DeleteAsync(int id)
        {
            Job job = Get(id);
            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task<Job> UpdateAsync(Job job)
        {
            Job j = Get(job.JobID);
            if (j is null)
                throw new Exception("Job not found.");
            j.JobID = job.JobID;
            j.Salary = job.Salary;
            j.Location = job.Location;
            j.Title = job.Title;
            j.EmployerID = job.EmployerID;
            j.Description = job.Description;
            j.PostedDate = job.PostedDate;
            await _context.SaveChangesAsync();
            return j;
        }
    }
}
