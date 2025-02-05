using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Entities
{
    public  class Shifts
    {
        [Key]
        public int shiftId { get; set; }
        public DateTime shiftDate { get; set; }

        public DateTime shiftHour { get; set; }
        public int userId { get; set; }
        public Users User { get; set; }

        public int roomId { get; set; }
        public Rooms Room {  get; set; }
    }
}
