using JobNet.Core.Entities;

namespace JobNet.Models
{
    public class SubscriptionPostModel
    {
        public int SubscriberID { get; set; }
        public int UserId { get; set; }
        public DateTime SubscriptionDate { get; set; }
    }
}
