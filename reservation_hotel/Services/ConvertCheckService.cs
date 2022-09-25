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
            Console.Clear();
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

            return FormatPhoneNumber(phone);
        }

        public static string ParseCpf()
        {
            Console.Clear();
            bool result = false;
            string Cpf = string.Empty;
            do
            {
                Message.TwoMessages(StringLong.DigitCPF, StringShort.Cpf);
                Cpf = Console.ReadLine();
                result = ConditionsService.ValidCpf(Cpf);
                if (!result)
                {
                    MessagesCustom.MessageDelayClear(StringError.CpfIsNotValid);
                }
            } while (!result);

            return FormatCpf(Cpf);
        }

        private static string FormatCpf(string cpf) => 
            $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6,3)}-{cpf.Substring(9)}";

        private static string FormatPhoneNumber(string phoneNumber) =>
            $"{55}-{phoneNumber.Substring(0,2)}-{phoneNumber.Substring(2)}";

        public static string GetName() 
        {
            Console.Clear();
            Message.TwoMessages(StringLong.DigitName, StringShort.Name);
            string name = Console.ReadLine();
            return name;
        }


    }
}
