using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservation_hotel.Messages
{
    public static class MessagesCustomTime
    {
        public static void MessageDelayClear(string message, int time)
        {
            Console.WriteLine(message);
            Thread.Sleep(time * 1000);
            Console.Clear();
        }
        public static void MessageDelaySeconds(string message, int time)
        {
            Console.WriteLine(message);
            Thread.Sleep(time * 1000);
        }
    }
}
