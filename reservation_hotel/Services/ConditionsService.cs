using reservation_hotel.Messages;
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
    }


}
