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
    public static class UserService
    {
        public static void GetAllUsers(Hotel hotel)
        {
            List<User> user = hotel.Users.OrderBy(u => u.Name).ToList();
            user.ForEach(u => Message.UserListMessage(u));
            MessagesCustom.MessageAwaitKeyPress(StringLong.PressKeyToExit);
        }

        public static void RegisterUser(Hotel hotel)
        {
            string phone = ConvertCheckService.ParsePhone();
            string cpf = ConvertCheckService.ParseCpf();
            string name = ConvertCheckService.GetName();

            if (ConditionsService.UserIsRegister(cpf, hotel.Users))
                MessagesCustom.MessageDelayClear(StringError.UserIsRegister);
            else
            {
                User user = new User(name, cpf, phone);
                hotel.Users.Add(user);
                try
                {
                    RepositoryService.SaveNewUser(hotel.Users, StringPath.WorkComputerPartialPath, StringPath.FileNameUsers);
                    Message.UserListMessage(user);
                    MessagesCustom.MessageAwaitKeyPress(StringLong.UserCreate);
                }
                catch (Exception)
                {

                    hotel.Users.Remove(user);
                    MessagesCustom.MessageDelayClear(StringError.FileUsersNotFound);
                }
            }

        }

        public static void RemoveUser(Hotel hotel)
        {
            string cpf = ConvertCheckService.ParseCpf();
            User user = hotel.Users.FirstOrDefault(u => u.Cpf == cpf);
            if (user != null)
            {

                try
                {
                    hotel.Users.Remove(user);
                    RepositoryService.SaveNewUser(hotel.Users, StringPath.WorkComputerPartialPath, StringPath.FileNameUsers);
                    Message.UserListMessage(user);
                    MessagesCustom.MessageAwaitKeyPress(StringLong.UserDeleted);
                }
                catch (Exception)
                {
                    hotel.Users.Add(user);
                }


            }
            else
            {
                MessagesCustom.MessageDelayClear(StringError.UserIsNotRegister);
            }

        }
    }



}
