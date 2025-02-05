using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JobNet.Core.Entities.User;

namespace JobNet.Core.DTOs
{
    public class UserDto
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        //public string Password { get; set; }

        public string Email { get; set; }

        public eRole Role { get; set; }
    }
}
