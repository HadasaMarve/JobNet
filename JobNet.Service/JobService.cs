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
    public class JobService:IJobService
    {
        private readonly IJobRepository _JobRepository;
        public JobService(IJobRepository jobRepository)
        {
            _JobRepository = jobRepository;
        }

        public async Task<IEnumerable<Job>> GetAllAsync()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return await _JobRepository.GetAllAsync();
        }

        public Job Get(int id)
        {
            return _JobRepository.Get(id);
        }

        public async Task<Job> AddAsync(Job job)
        {
            return await _JobRepository.AddAsync(job);
        }

        public async Task<Job> DeleteAsync(int id)
        {
            return await _JobRepository.DeleteAsync(id);
        }

        public async Task<Job> UpdateAsync(Job job)
        {
            return await _JobRepository.UpdateAsync(job);
        }
    }
}
