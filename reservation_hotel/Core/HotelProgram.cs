using reservation_hotel.Models;
using reservation_hotel.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reservation_hotel.Services;
using reservation_hotel.Strings;

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
                    UserOptions();
                    break;
                case 2:
                    RoomOptions();
                    break;
                case 3:
                    break;
            }
        }

        private void UserOptions()
        {
            int optionsSelect = 0;
            do
            {
                Message.MenuUserMessage();
                optionsSelect = ConvertCheckService.ParseIntCheck();
                if (!ConditionsService.OptionIsValid(optionsSelect))
                    continue;
                else
                {
                    switch (optionsSelect)
                    {
                        case 1:
                            UserService.GetAllUsers(Hotel);
                            break;
                        case 2:
                            UserService.RegisterUser(Hotel);
                            break;
                        case 3:
                            UserService.RemoveUser(Hotel);
                            break;
                    }
                }
               
            } while (!(optionsSelect == 4));  
        }

        private void RoomOptions()
        {
            int optionsSelect = 0;
            do
            {
                Message.MenuRoomMessage();
                optionsSelect = ConvertCheckService.ParseIntCheck();
                if (!ConditionsService.OptionIsValid(optionsSelect))
                    continue;
                else
                {
                    switch (optionsSelect)
                    {
                        case 1:
                            RoomService.GetAllRooms(Hotel);
                            break;
                        case 2:
                            RoomService.RegisterRoom(Hotel);
                            break;
                        case 3:
                            //UserService.RemoveUser(Hotel);
                            break;
                    }
                }

            } while (!(optionsSelect == 4));
        }

        





    }
}
