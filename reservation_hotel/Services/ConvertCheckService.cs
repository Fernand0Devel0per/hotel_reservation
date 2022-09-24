using reservation_hotel.Messages;
using reservation_hotel.Strings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace reservation_hotel.Services
{
    public static class ConvertCheckService
    {
        public static int ParseIntCheck()
        {
            int valueParse = 0;
            bool result;
            Console.Write(StringShort.InsertValue);
            result = int.TryParse(Console.ReadLine(), out valueParse);
            if (!result)
            {
                MessagesCustom.MessageDelayClear(StringError.ValueIsNotInteger);
                return -1;
            }
            return valueParse;
        }

        public static string ParsePhone()
        {
            bool result = false;
            string phone = string.Empty;
            do
            {
                Message.TwoMessages(StringLong.DigitPhoneNumber, StringShort.PhoneNumber);
                phone = Console.ReadLine();
                result = ConditionsService.ValidPhone(phone);
                if (!result)
                {
                    MessagesCustom.MessageDelayClear(StringError.PhoneIsNotValid);
                }
            } while (!result);
            return phone;
        }

    }
}
