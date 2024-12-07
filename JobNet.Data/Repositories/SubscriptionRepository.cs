using JobNet.Core.Entities;
using JobNet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Data.Repositories
{
    public class SubscriptionRepository:ISubscriptionRepository
    {
        private readonly DataContext _context;

        public SubscriptionRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Subscription> GetAll()
        {
            return _context.Subscriptions;
        }

        public Subscription Get(int id)
        {
            return _context.Subscriptions.FirstOrDefault(s => s.SubscriberID == id);
        }

        public Subscription Add(Subscription subscription)
        {
            _context.Subscriptions.Add(subscription);
            _context.SaveChanges();
            return subscription;
        }
    }
}
