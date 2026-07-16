namespace OOP_Task_2
{
    class Room
    {
        public int RoomNo { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public Room(int RoomNo, string RoomType, double PricePerNight, bool IsAvailable)
        {
            this.RoomNo = RoomNo;
            this.RoomType = RoomType;
            this.PricePerNight = PricePerNight;
            this.IsAvailable = IsAvailable;
        }

        public void DisplayRoom()
        {
            Console.WriteLine("Room Details : ");
            Console.WriteLine("Room Number: " + RoomNo);
            Console.WriteLine("Room Type: " + RoomType);
            Console.WriteLine("Price Per Night: " + PricePerNight);

            if (IsAvailable)
            {
                Console.WriteLine("Room is available");
            }
            else
            {
                Console.WriteLine("Room is not available");
            }
        }
    }

    class Guest
    {
        public string GuestID { get; set; }
        public string GuestName { get; set; }
        public int RoomNo { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        public void DisplayGuest()
        {
            Console.WriteLine("Guest Details : ");
            Console.WriteLine("Guest ID: " + GuestID);
            Console.WriteLine("Guest Name: " + GuestName);
            Console.WriteLine("Room Number: " + RoomNo);
            Console.WriteLine("Check In Date: " + CheckInDate);
            Console.WriteLine("Total Nights: " + TotalNights);
        }

        public void CalculateTotalCost()
        {
            double totalPrice = TotalNights * Room.PricePerNight;
            Console.WriteLine("Total Price: " + totalPrice);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Romm>();
            List<Guest> guests = new List<Guest>();

            rooms.Add(new Room(101, "Single", 100, true));
            rooms.Add(new Room(101, "Single", 100, false));
            rooms.Add(new Room(102, "Double", 150, true));
            rooms.Add(new Room(102, "Double", 150, false));
            rooms.Add(new Room(103, "Suite", 200, true));
            rooms.Add(new Room(103, "Suite", 200, false));

            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guest");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest\r\n");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");
                Console.WriteLine("================================================");
                Console.WriteLine("Enter your choice: ");
            }
            


        }

    }
}