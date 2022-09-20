using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservation_hotel.Models
{
    public class Room
    {
        public int Number { get; set; }
        public int Space { get; set; }
        public int Category { get; set; }
        public bool IsFree { get; set; }
    }
}
