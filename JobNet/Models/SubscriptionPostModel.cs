using JobNet.Core.Entities;

namespace JobNet.Models
{
    public class SubscriptionPostModel
    {
        //public int SubscriberID { get; set; }
        //public int UserId { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
