using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.Repositories
{
    public interface ISubscriptionRepository
    {
        public Task<IEnumerable<Subscription>> GetAllAsync();

        public Subscription Get(int id);

        public Task<Subscription> AddAsync(Subscription subscription);

    }
}
