using reservation_hotel.Messages;
using reservation_hotel.Models;
using reservation_hotel.Strings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
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
        public static int ParseIntCheckNoMessage()
        {
            int valueParse = 0;
            bool result;
            result = int.TryParse(Console.ReadLine(), out valueParse);
            if (!result)
            {
                MessagesCustom.MessageDelayClear(StringError.ValueIsNotInteger);
                return -1;
            }
            return valueParse;
        }

        public static decimal ParseDecimalCheckNoMessage()
        {
            decimal valueParse = 0;
            bool result;
            result = decimal.TryParse(Console.ReadLine(), out valueParse);
            if (!result)
            {
                MessagesCustom.MessageDelayClear(StringError.ValueIsNotDecimal);
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

        public static int GetNumberRoom()
        {
            bool result = false;
            int number = 0;
            do
            {
                Console.Clear();
                Message.TwoMessages(StringLong.DigitNumberRoom, StringShort.RoomNumber);
                number = ParseIntCheckNoMessage();
                result = ConditionsService.IsBiggerZero(number);
                if (!result)
                {
                    MessagesCustom.MessageDelayClear(StringError.ValueBiggerZero);
                }
            } while (!result);
            return number;

        }

        public static int GetNumberOrder()
        {
            bool result = false;
            int number = 0;
            do
            {
                Console.Clear();
                Message.TwoMessages(StringLong.DigitNumberOrder, StringShort.IdOrder);
                number = ParseIntCheckNoMessage();
                result = ConditionsService.IsBiggerZero(number);
                if (!result)
                {
                    MessagesCustom.MessageDelayClear(StringError.ValueBiggerZero);
                }
            } while (!result);
            return number;

        }

        public static int GetSpaceRoom()
        {
            bool result = false;
            int space = 0;
            do
            {
                Console.Clear();
                Message.TwoMessages(StringLong.DigitSpaceRoom, StringShort.RoomSpace);
                space = ParseIntCheckNoMessage();
                result = ConditionsService.IsBiggerZero(space);
                if (!result)
                {
                    MessagesCustom.MessageDelayClear(StringError.ValueBiggerZero);
                }
            } while (!result);
            return space;

        }

        public static Category GetCategoryRoom() 
        {
            Console.Clear();
            Message.TwoMessages(StringLong.DigitCategoryName, StringShort.CategoryName);
            string nameCategory = Console.ReadLine();

            bool result = false;
            decimal valueRoom = 0m;
            do
            {
                Console.Clear();
                Message.TwoMessages(StringLong.DigitValueByDay, StringShort.CategoryPrice);
                valueRoom = ParseDecimalCheckNoMessage();
                result = ConditionsService.IsBiggerZero(valueRoom);
                if (!result)
                {
                    MessagesCustom.MessageDelayClear(StringError.ValueBiggerZeroDecimal);
                }
            } while (!result);

            return new Category(nameCategory, valueRoom);
        }

        public static int CreateNextNumberOrder(List<Order> listOrder)
        {
            int result = 0;
            listOrder.ForEach(o => result = (o.Id > result) ? o.Id : result);
            return result + 1;
        }

        public static int ParseIntCheck(string message)
        {
            int valueParse = 0;
            bool result;
            Console.Write(message);
            result = int.TryParse(Console.ReadLine(), out valueParse);
            if (!result)
            {
                MessagesCustom.MessageDelayClear(StringError.ValueIsNotInteger);
                return -1;
            }
            return valueParse;
        }

        public static DateTime ParseDateTimeCheck(string message)
        {
            DateTime date = DateTime.Now;
            bool result;           
            do
            {
                Console.Write(message);
                result = DateTime.TryParse(Console.ReadLine(), out date);
                if (!result)
                {
                    MessagesCustom.MessageDelayClear(StringError.DateIsNotValid);
                }
            } while (!result);
            return date;
        }


    }
}
