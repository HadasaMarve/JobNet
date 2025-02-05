using static JobNet.Core.Entities.User;

namespace JobNet.Models
{
    public class UserPostModel
    {
        //public int UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public eRole Role { get; set; }
    }
}
