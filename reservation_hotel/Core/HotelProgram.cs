﻿using reservation_hotel.Models;
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
                            GetAllUsers();
                            break;
                        case 2:
                            RegisterUser();
                            break;
                        case 3:
                            break;
                    }
                }
               
            } while (!(optionsSelect == 4));  
        }

        private void GetAllUsers()
        {
            List<User> user = Hotel.Users.OrderBy(u => u.Name).ToList();
            user.ForEach(u => Message.UserListMessage(u));
            MessagesCustom.MessageAwaitKeyPress(StringLong.PressKeyToExit);
        }

        private void RegisterUser()
        {
            string phone = ConvertCheckService.ParsePhone();
        }

    }
}
