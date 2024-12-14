using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.DTOs
{
    public class SubscriptionDto
    {
        public int SubscriberID { get; set; }
        public int UserId { get; set; }

        public UserDto User { get; set; }
        public DateTime SubscriptionDate { get; set; }
    }
}
