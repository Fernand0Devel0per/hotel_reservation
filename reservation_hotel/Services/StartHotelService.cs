using Newtonsoft.Json;
using reservation_hotel.Models;
using reservation_hotel.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservation_hotel.Services
{
    public static class StartHotelService
    {
        public static Hotel CreateHotel()
        {
            var rooms = ReadRoomsList(@"..\Infra\Data\Rooms.json");
            var users = ReadUsersList(@"..\Infra\Data\Users.json");
            var hotel = new Hotel();
            hotel.Rooms = rooms;
            hotel.Users = users;
            hotel.OrderFinish = new List<Order>();
            hotel.OrderActives = new List<Order>();

            return hotel;
        }

        private static List<Room> ReadRoomsList(string path)
        {
            string content = string.Empty;
            List<Room> rooms;
            try
            {
                content = File.ReadAllText(path);
                rooms = JsonConvert.DeserializeObject<List<Room>>(content);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException(StringError.FileRoomsNotFound, path);
            }

            return rooms;
            
        }

        private static List<User> ReadUsersList(string path)
        {
            string content = string.Empty;
            List<User> users;
            try
            {
                content = File.ReadAllText(path);
                users = JsonConvert.DeserializeObject<List<User>>(content);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException(StringError.FileUsersNotFound, path);
            }

            return users;

        }

        private static List<Order> ReadOrderActivesList(string path)
        {
            string content = string.Empty;
            List<Order> order;
            try
            {
                content = File.ReadAllText(path);
                order = JsonConvert.DeserializeObject<List<Order>>(content);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException(StringError.FileOrderActivesNotFound, path);
            }

            return order;

        }

        private static List<Order> ReadOrderFinishList(string path)
        {
            string content = string.Empty;
            List<Order> order;
            try
            {
                content = File.ReadAllText(path);
                order = JsonConvert.DeserializeObject<List<Order>>(content);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException(StringError.FileOrderFinishNotFound, path);
            }

            return order;

        }
    }
}
