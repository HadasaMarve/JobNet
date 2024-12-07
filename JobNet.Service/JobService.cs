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

        public IEnumerable<Job> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _JobRepository.GetAll();
        }

        public Job Get(int id)
        {
            return _JobRepository.Get(id);
        }

        public Job Add(Job job)
        {
            return _JobRepository.Add(job);
        }
    }
}
