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
            Room room = SelectRoom(hotel);
            List<User> users = RegisterUsers(hotel, room.Space);
            (DateTime dateStart, DateTime dateEnd) dates = SelectDatas();
            var order = new Order(numberOrder, room, users, dates.dateStart, dates.dateEnd);
            hotel.Order.Add(order);

            try
            {
                RepositoryService.SaveNewOrder(hotel.Order, StringPath.HomeComputerPartialPath, StringPath.FileNameOrders);
                Message.OrderListMessage(order);
                MessagesCustom.MessageAwaitKeyPress(StringLong.OrderCreate);
            }
            catch (Exception)
            {

                hotel.Order.Remove(order);
                MessagesCustom.MessageDelayClear(StringError.FileRoomsNotFound);
            }
            

        }

        private static Room SelectRoom(Hotel hotel)
        {
            int roomNumber = 0;
            Room room = null;
            do
            {
                roomNumber = ConvertCheckService.ParseIntCheck(StringShort.RoomSearch);
                room = hotel.Rooms.FirstOrDefault(r => r.Number == roomNumber);
                if (room == null)
                {
                    MessagesCustom.MessageDelayClear(StringError.RoomIsNotRegister);
                }

            } while (room == null);
            return room;
        }

        private static List<User> RegisterUsers(Hotel hotel, int space)
        {
            List<User> users = new List<User>();

            char decision = 'n';
            do
            {
                string cpf = ConvertCheckService.ParseCpf();
                User user = hotel.Users.FirstOrDefault(u => u.Cpf == cpf);
                if (user != null)
                {
                    if (!users.Contains(user))
                    {
                        users.Add(user);
                    }
                    else
                    {
                        MessagesCustom.MessageDelayClear(StringLong.UserIsAdd);
                        continue;
                    }
                }
                else
                {
                    MessagesCustom.MessageDelayClear(StringLong.userNotFound);
                }
                if (users.Count >= space)
                {
                    break;
                }
                MessagesCustom.MessageClearAndMessage(StringLong.MessegeOptionNewUser);
                decision = char.Parse(Console.ReadLine().ToLower());
            } while (decision == 'y');
            return users;
        }
        
        private static (DateTime, DateTime) SelectDatas()
        {
            DateTime dateStart = DateTime.Now;
            DateTime dateEnd = DateTime.Now;
            do
            {
                dateStart = ConvertCheckService.ParseDateTimeCheck(StringLong.DateStart);
                if (dateStart <= DateTime.Now.Date)
                {
                    MessagesCustom.MessageDelayClear(StringError.DateIsTooSmall, 2);
                }
            } while (dateStart <= DateTime.Now.Date);

            do
            {
                dateEnd = ConvertCheckService.ParseDateTimeCheck(StringLong.DateEnd);
                if (dateStart >= dateEnd)
                {
                    MessagesCustom.MessageDelayClear(StringError.DateIsNotCorrect, 2);
                }
            } while (dateStart >= dateEnd);

            return (dateStart, dateEnd);
        }
    }

}
