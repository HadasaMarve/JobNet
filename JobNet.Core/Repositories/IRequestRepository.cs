using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.Repositories
{
    public interface IRequestRepository
    {
        public Task<IEnumerable<Request>> GetAllAsync();

        public Request Get(int id);

        public Task<Request> AddAsync(Request request);

    }
}
