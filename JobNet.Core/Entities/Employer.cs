using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.Entities
{
    public class Employer
    {
        [Key]
        public int EmployerID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string CompanyName { get; set; }
        public string Industry { get; set; }

    }
}
