using JobNet.Core.Entities;
using JobNet.Core.Repositories;
using Microsoft.EntityFrameworkCore;
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
            return _context.Requests.Where(s => !string.IsNullOrEmpty(s.Message)).Include(s=>s.User).Include(s=>s.Job);
        }

        public Request Get(int id)
        {
            return _context.Requests.Include(s => s.User).Include(s => s.Job).First(s => s.RequestID == id);
        }

        public Request Add(Request request)
        {
            _context.Requests.Add(request);
            _context.SaveChanges();
            return request;
        }
    }
}
