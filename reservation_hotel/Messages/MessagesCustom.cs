using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservation_hotel.Messages
{
    public static class MessagesCustom
    {
        public static void MessageDelayClear(string message, int time = 1)
        {
            Console.WriteLine(message);
            Thread.Sleep(time * 1000);
            Console.Clear();
        }
        public static void MessageDelay(string message, int time = 1)
        {
            Console.WriteLine(message);
            Thread.Sleep(time * 1000);
        }

        public static void MessageClearAndMessage(string message) 
        {
            Console.Clear();
            Console.WriteLine(message);
        }

        public static void MessageAwaitKeyPress(string message) 
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }



    }
}
