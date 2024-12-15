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
    public class SubscriptionService: ISubscriptionService
    {
        private readonly ISubscriptionRepository _SubscriptionRepository;
        public SubscriptionService(ISubscriptionRepository subscriptionRepository)
        {
            _SubscriptionRepository = subscriptionRepository;
        }

        public async Task<IEnumerable<Subscription>> GetAllAsync()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return await _SubscriptionRepository.GetAllAsync();
        }

        public Subscription Get(int id)
        {
            return _SubscriptionRepository.Get(id);
        }

        public async Task<Subscription> AddAsync(Subscription subscription)
        {
            return await _SubscriptionRepository.AddAsync(subscription);
        }
    }
}
