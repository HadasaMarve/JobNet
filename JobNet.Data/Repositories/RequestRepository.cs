using JobNet.Core.Entities;
using JobNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Data.Repositories
{
    public class RequestRepository:IRequestRepository
    {
        private readonly DataContext _context;

        public RequestRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Request> GetAll()
        {
            return _context.Requests.Where(s => !string.IsNullOrEmpty(s.Message));
        }

        public Request Get(int id)
        {
            return _context.Requests.FirstOrDefault(s => s.RequestID == id);
        }

        public Request Add(Request request)
        {
            _context.Requests.Add(request);
            _context.SaveChanges();
            return request;
        }
    }
}
