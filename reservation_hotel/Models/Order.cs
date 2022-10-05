namespace reservation_hotel.Models
{
    public class Order
    {
        public Order(int id, Room room, List<User> users, DateTime dateStart, DateTime dateEnd)
        {
            Id = id;
            Room = room;
            Users = users;
            DateStart = dateStart;
            DateEnd = dateEnd;
            IsFinish = true;
        }

        public int Id { get; set; }
        public Room Room { get; set; }
        public List<User> Users { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool IsFinish { get; set; }

      

        public decimal TotalToPay() => (DateEnd.Day - DateStart.Day) * Room.Category.Price;

    }
}
