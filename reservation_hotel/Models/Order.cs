namespace reservation_hotel.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Room Name { get; set; }
        public List<User> Users { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
