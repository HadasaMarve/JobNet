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
    public class RequestService: IRequestService
    {
        private readonly IRequestRepository _RequestRepository;
        public RequestService(IRequestRepository requestRepository)
        {
            _RequestRepository = requestRepository;
        }

        public async Task<IEnumerable<Request>> GetAllAsync()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return await _RequestRepository.GetAllAsync();
        }

        public Request Get(int id)
        {
            return _RequestRepository.Get(id);
        }

        public async Task<Request> AddAsync(Request request)
        {
            return await _RequestRepository.AddAsync(request);
        }
    }
}
