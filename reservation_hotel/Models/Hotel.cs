namespace reservation_hotel.Models
{
    public class Hotel
    {
        public List<Room> Rooms { get; set; }
        public List<User> Users { get; set; }
        public List<Order> OrderActives { get; set; }
        public List<Order> OrderFinish { get; set; }
    }
}
