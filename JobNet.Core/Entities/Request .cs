using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core.Entities
{
    public class Request
    {
        [Key]
        public int RequestID { get; set; }
        public int JobID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
