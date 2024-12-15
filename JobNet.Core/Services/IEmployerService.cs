using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.Services
{
    public interface IEmployerService
    {
        public Task<IEnumerable<Employer>> GetAllAsync();

        public Employer Get(int id);

        public Task<Employer> AddAsync(Employer employer);
    }
}
