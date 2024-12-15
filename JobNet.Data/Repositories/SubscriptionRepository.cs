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
    public class SubscriptionRepository:ISubscriptionRepository
    {
        private readonly DataContext _context;

        public SubscriptionRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Subscription>> GetAllAsync()
        {
            return await _context.Subscriptions.Include(s => s.User).ToListAsync();
        }

        public Subscription Get(int id)
        {
            return _context.Subscriptions.Include(s => s.User).First(s => s.SubscriberID == id);
        }

        public async Task<Subscription> AddAsync(Subscription subscription)
        {
            _context.Subscriptions.Add(subscription);
            await _context.SaveChangesAsync();
            return subscription;
        }
    }
}
