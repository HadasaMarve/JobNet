using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.DTOs
{
    public class EmployerDto
    {
        public int EmployerID { get; set; }
        public int UserID { get; set; }
        public UserDto User { get; set; }
        public string CompanyName { get; set; }
        public string Industry { get; set; }
    }
}
