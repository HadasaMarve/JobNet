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

        public IEnumerable<Request> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _RequestRepository.GetAll();
        }

        public Request Get(int id)
        {
            return _RequestRepository.Get(id);
        }

        public Request Add(Request request)
        {
            return _RequestRepository.Add(request);
        }
    }
}
