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
    }
}
