using reservation_hotel.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservation_hotel.Messages
{
    public static class Message
    {
        public static void StartProgramMessage()
        {
            MessagesCustom.MessageDelayClear(StringLong.StartProgram, 3);
        }

        public static void FirstMenuMessage()
        {
            MessagesCustom.MessageDelay(StringLong.WelcomeProgram);
            MessagesCustom.MessageDelay(StringOptions.OptionUser);
            MessagesCustom.MessageDelay(StringOptions.OptionRoom);
            MessagesCustom.MessageDelay(StringOptions.OptionReservation);
            MessagesCustom.MessageDelay(StringOptions.LeaveProgram);
        }

        public static void MenuUserMessage()
        {
            MessagesCustom.MessageClearAndMessage(StringLong.WelcomeProgram);
            MessagesCustom.MessageDelay(StringOptions.ListUser);
            MessagesCustom.MessageDelay(StringOptions.RegisterUser);
            MessagesCustom.MessageDelay(StringOptions.RemoveUser);
            MessagesCustom.MessageDelay(StringOptions.LeaveProgram);
        }


    }
}
