using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.Entities
{
    public class Job
    {
        [Key]
        public int JobID { get; set; }

        public int EmployerID { get; set; }

        public Employer Employer { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public int Salary { get; set; }

        public DateTime PostedDate { get; set; }
    }
}
