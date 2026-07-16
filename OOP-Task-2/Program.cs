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


        }

    }
}