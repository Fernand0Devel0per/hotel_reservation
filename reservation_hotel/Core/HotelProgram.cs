using reservation_hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservation_hotel.Core
{
    public class HotelProgram
    {
        public Hotel Hotel { get; private set; }

        public HotelProgram(Hotel hotel) {
            Hotel = hotel;
        }

        public void Options(int optionsSelect)
        {
            switch (optionsSelect)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        private void UserOptions()
        {
            int optionsSelect = 0;

            switch (optionsSelect)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                
            }
        }


    }
}
