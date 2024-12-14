using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.DTOs
{
    public class JobDto
    {
        public int JobID { get; set; }

        public int EmployerID { get; set; }

        public EmployerDto Employer { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public int Salary { get; set; }

        public DateTime PostedDate { get; set; }
    }
}
