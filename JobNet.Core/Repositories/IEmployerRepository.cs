using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.Repositories
{
    public interface IEmployerRepository
    {
        public Task<IEnumerable<Employer>> GetAllAsync();

        public Employer Get(int id);

        public Task<Employer> AddAsync(Employer employer);


    }
}
