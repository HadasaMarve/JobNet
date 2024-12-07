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
        public IEnumerable<Request> GetList();

        public Request Get(int id);

        public Request Add(Request request);
    }
}
