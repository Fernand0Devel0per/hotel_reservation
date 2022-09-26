using reservation_hotel.Messages;
using reservation_hotel.Models;
using reservation_hotel.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservation_hotel.Services
{
    public static class RoomService
    {
        public static void GetAllRooms(Hotel hotel)
        {
            List<Room> room = hotel.Rooms.OrderBy(r => r.Number).ToList();
            room.ForEach(r => Message.RoomListMessage(r));
            MessagesCustom.MessageAwaitKeyPress(StringLong.PressKeyToExit);
        }

        public static void RegisterRoom(Hotel hotel)
        {
            int numberRoom = ConvertCheckService.GetNumberRoom();
            int spaceRoom = ConvertCheckService.GetSpaceRoom();
            Category category = ConvertCheckService.GetCategoryRoom();

            if (ConditionsService.RoomIsRegister(numberRoom, hotel.Rooms))
                MessagesCustom.MessageDelayClear(StringError.RoomIsRegister);
            else
            {
                Room room = new Room(numberRoom, spaceRoom, category);
                hotel.Rooms.Add(room);
                try
                {
                    RepositoryService.SaveNewRoom(hotel.Rooms, StringPath.WorkComputerPartialPath, StringPath.FileNameRooms);
                    Message.RoomListMessage(room);
                    MessagesCustom.MessageAwaitKeyPress(StringLong.RoomCreate);
                }
                catch (Exception)
                {

                    hotel.Rooms.Remove(room);
                    MessagesCustom.MessageDelayClear(StringError.FileRoomsNotFound);
                }
            }

        }

        //public static void RemoveUser(Hotel hotel)
        //{
        //    string cpf = ConvertCheckService.ParseCpf();
        //    User user = hotel.Users.FirstOrDefault(u => u.Cpf == cpf);
        //    if (user != null)
        //    {

        //        try
        //        {
        //            hotel.Users.Remove(user);
        //            RepositoryService.SaveNewUser(hotel.Users, StringPath.WorkComputerPartialPath, StringPath.FileNameUsers);
        //            Message.UserListMessage(user);
        //            MessagesCustom.MessageAwaitKeyPress(StringLong.UserDeleted);
        //        }
        //        catch (Exception)
        //        {
        //            hotel.Users.Add(user);
        //        }


        //    }
        //    else
        //    {
        //        MessagesCustom.MessageDelayClear(StringError.UserIsNotRegister);
        //    }

        //}
    }



}
