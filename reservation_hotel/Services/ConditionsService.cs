using reservation_hotel.Messages;
using reservation_hotel.Models;
using reservation_hotel.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace reservation_hotel.Services
{
    public static class ConditionsService
    {

        public static bool OptionIsValid(int optionSelect)
        {

            if (optionSelect == 4 || optionSelect == -1) return false;
            else if (optionSelect < 1 || optionSelect > 4)
            {
                MessagesCustom.MessageDelayClear(StringShort.InvalidOption);
                return false;
            }
            else return true;
        }

        public static bool ValidCpf(string cpfValue)
        {
            var Cpf = new Regex("[0-9]{11}");
            return Cpf.IsMatch(cpfValue);
        }

        public static bool ValidPhone(string phoneValue)
        {
            var Cpf = new Regex("[0-9]{11}");
            return Cpf.IsMatch(phoneValue);
        }

        public static bool UserIsRegister(string cpf, List<User> users)
        {
            foreach (var item in users)
            {
                if (item.Cpf == cpf)
                {
                    return true;
                    break;
                } 
            }
            return false;

        }

        public static bool RoomIsRegister(int number, List<Room> rooms)
        {
            foreach (var item in rooms)
            {
                if (item.Number == number)
                {
                    return true;
                    break;
                }
            }
            return false;

        }

        public static bool IsBiggerZero(int number) => number > 0;
        public static bool IsBiggerZero(decimal number) => number > 0m;

    }


}
