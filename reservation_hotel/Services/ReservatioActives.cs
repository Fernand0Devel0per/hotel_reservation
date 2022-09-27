using reservation_hotel.Messages;
using reservation_hotel.Models;
using reservation_hotel.Strings;

namespace reservation_hotel.Services
{
    public static class ReservatioActives
    {
        public static void GetAllReservatioActives(Hotel hotel)
        {
            List<Order> orders = hotel.Order.Where(o => o.IsFinish == false).OrderBy(o => o.DateStart).ToList();
            orders.ForEach(o => Message.OrderListMessage(o));
            MessagesCustom.MessageAwaitKeyPress(StringLong.PressKeyToExit);
        }

        public static void RegisterNewOrder(Hotel hotel)
        {
            int numberOrder = ConvertCheckService.CreateNextNumberOrder(hotel.Order);
        }

        /*
         * public static void RegisterUser(Hotel hotel)
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

        
 
         */


    }

}
