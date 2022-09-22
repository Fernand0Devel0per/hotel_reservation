using reservation_hotel.Messages;
using reservation_hotel.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
