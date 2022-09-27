namespace reservation_hotel.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Room Room { get; set; }
        public List<User> Users { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool IsFinish { get; set; }

        public decimal TotalToPay() => (DateEnd.Day - DateStart.Day) * Room.Category.Price;

    }
}
