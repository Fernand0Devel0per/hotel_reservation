namespace reservation_hotel.Models
{
    public class Hotel
    {
        public List<Room> Rooms { get; set; }
        public List<User> Users { get; set; }
        public List<Order> Order { get; set; }
    }
}
