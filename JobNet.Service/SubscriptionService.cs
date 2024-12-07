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

        public IEnumerable<Subscription> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _SubscriptionRepository.GetAll();
        }

        public Subscription Get(int id)
        {
            return _SubscriptionRepository.Get(id);
        }

        public Subscription Add(Subscription subscription)
        {
            return _SubscriptionRepository.Add(subscription);
        }
    }
}
