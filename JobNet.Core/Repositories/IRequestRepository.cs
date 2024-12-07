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
        public IEnumerable<Request> GetAll();

        public Request Get(int id);

        public Request Add(Request request);

    }
}
