using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.DTOs
{
    public class RequestDto
    {
        public int RequestID { get; set; }
        public int JobID { get; set; }

        public JobDto Job { get; set; }
        public int UserID { get; set; }

        public UserDto User { get; set; }
        public string Message { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
