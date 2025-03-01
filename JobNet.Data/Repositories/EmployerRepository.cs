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

        public async Task<Employer> DeleteAsync(int id) 
        {
            Employer employer=Get(id);
            _context.Employers.Remove(employer);
            await _context.SaveChangesAsync();
            return employer;
        }

        public async Task<Employer> UpdateAsync(Employer employer)
        {
            Employer e=Get(employer.EmployerID);
            if (e is null)
                throw new Exception("Employer not found.");
            e.UserID=employer.UserID;
            e.CompanyName=employer.CompanyName;
            e.Industry=employer.Industry;
            await _context.SaveChangesAsync();
            return employer;
        }
    }
}
