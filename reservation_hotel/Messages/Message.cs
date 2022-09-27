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

        public static void RoomListMessage(Room room)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0}{1}", StringShort.RoomNumber, room.Number));
            sb.AppendLine(string.Format("{0}{1}", StringShort.RoomSpace, room.Space));
            sb.AppendLine(string.Format("{0}{1}", StringShort.CategoryName, room.Category.Name));
            sb.AppendLine(string.Format("{0}{1}", StringShort.CategoryPrice, room.Category.Price));
            sb.Append("--------------------------------");
            Console.WriteLine(sb.ToString());
        }


        public static void OrderListMessage(Order order)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0}{1}", StringShort.IdOrder, order.Id));
            sb.AppendLine(string.Format("{0}{1}", StringShort.RoomNumber, order.Room.Number));
            foreach (var item in order.Users)
            {
                sb.AppendLine(string.Format("{0}{1}", StringShort.Name, item.Name));
            }
            sb.AppendLine(string.Format("{0}{1}", StringShort.Checkin, order.DateStart.ToString("dd/MM/yyyy")));
            sb.AppendLine(string.Format("{0}{1}", StringShort.Checkout, order.DateEnd.ToString("dd/MM/yyyy")));
            sb.AppendLine(string.Format("{0}{1}", StringShort.TotalToPay, order.TotalToPay().ToString("C")));
            sb.Append("--------------------------------");
            Console.WriteLine(sb.ToString());
        }
        public static void TwoMessages(string firstMessage, string secondMessage) 
        {
            Console.WriteLine(firstMessage);
            Console.Write(secondMessage);
        }

        public static void MenuRoomMessage()
        {
            MessagesCustom.MessageClearAndMessage(StringLong.WelcomeProgram);
            MessagesCustom.MessageDelay(StringOptions.ListRoom);
            MessagesCustom.MessageDelay(StringOptions.RegisterRoom);
            MessagesCustom.MessageDelay(StringOptions.RemoveRoom);
            MessagesCustom.MessageDelay(StringOptions.LeaveProgram);
        }

        public static void MenuReservatioMessage()
        {
            MessagesCustom.MessageClearAndMessage(StringLong.WelcomeProgram);
            MessagesCustom.MessageDelay(StringOptions.ReservatioActives);
            MessagesCustom.MessageDelay(StringOptions.ReservatioFinish);
            MessagesCustom.MessageDelay(StringOptions.LeaveProgram);
        }

        public static void ReservatioActivesMessage()
        {
            MessagesCustom.MessageClearAndMessage(StringLong.WelcomeProgram);
            MessagesCustom.MessageDelay(StringOptions.ListReservatioActives);
            MessagesCustom.MessageDelay(StringOptions.RegisterReservatioActive);
            MessagesCustom.MessageDelay(StringOptions.RemoveReservatioActive);
            MessagesCustom.MessageDelay(StringOptions.LeaveProgram);
        }


    }
}
