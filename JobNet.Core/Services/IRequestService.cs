using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.Services
{
    public interface IRequestService
    {
        public Task<IEnumerable<Request>> GetAllAsync();

        public Request Get(int id);

        public Task<Request> AddAsync(Request request);
    }
}
