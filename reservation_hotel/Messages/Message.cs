using reservation_hotel.Models;
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

        public static void UserListMessage(User user) 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0}{1}", StringShort.Name, user.Name));
            sb.AppendLine(string.Format("{0}{1}", StringShort.Cpf, user.Cpf));
            sb.AppendLine(string.Format("{0}{1}", StringShort.PhoneNumber, user.Phone));
            sb.Append("--------------------------------");
            Console.WriteLine(sb.ToString());

        }


    }
}
