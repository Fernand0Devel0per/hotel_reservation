using Newtonsoft.Json;
using reservation_hotel.Models;

namespace reservation_hotel.Services
{
    public static class RepositoryService
    {
        public static bool SaveNewUser(List<User> users, string path, string fileName) 
        {
            try
            {
                string json = JsonConvert.SerializeObject(users);
                string fullPath = Path.Combine(path, fileName);
                File.WriteAllText(fullPath, json);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
            

        }

        public static bool SaveNewRoom(List<Room> rooms, string path, string fileName)
        {
            try
            {
                string json = JsonConvert.SerializeObject(rooms);
                string fullPath = Path.Combine(path, fileName);
                File.WriteAllText(fullPath, json);
            }
            catch (Exception)
            {
                return false;
            }
            return true;


        }
    }
}
