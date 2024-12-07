using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.Entities
{
    public class Subscription
    {
        [Key]
        public int SubscriberID { get; set; }
        public int UserId { get; set; }
        public DateTime SubscriptionDate { get; set; }
    }
}
