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
        public async Task<IEnumerable<Request>> GetAllAsync()
        {
            return await _context.Requests.Where(s => !string.IsNullOrEmpty(s.Message)).Include(s=>s.User).Include(s=>s.Job).Include(s=>s.Job.Employer).ToListAsync();
        }

        public Request Get(int id)
        {
            return _context.Requests.Include(s => s.User).Include(s => s.Job).First(s => s.RequestID == id);
        }

        public async Task<Request> AddAsync(Request request)
        {
            _context.Requests.Add(request);
            await _context.SaveChangesAsync();
            return request;
        }

        public async Task<Request> DeleteAsync(int id)
        {
            Request request = Get(id);
            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();
            return request;
        }

        public async Task<Request> UpdateAsync(Request request)
        {
            Request r = Get(request.RequestID);
            if (r is null)
                throw new Exception("Request not found.");
            r.Message = request.Message;
            r.UserID = request.UserID;
            r.JobID = request.JobID;
            r.RequestDate = request.RequestDate;
            await _context.SaveChangesAsync();
            return r;
        }
    }
}
