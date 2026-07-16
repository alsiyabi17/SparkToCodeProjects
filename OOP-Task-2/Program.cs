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

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine("press Enter to return to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddNewRoom();
                        break;
                    case 2:
                        RegisterNewGuest();
                        break;
                    case 3:
                        BookRoomForGuest();
                        break;
                    case 4:
                        ViewAllRooms();
                        break;
                    case 5:
                        ViewAllGuests();
                        break;
                    case 6:
                        SearchAndFilterRooms();
                        break;
                    case 7:
                        GuestAndBookingStatistics();
                        break;
                    case 8:
                        UpdateRoomPrice();
                        break;
                    case 9:
                        GuestLookupByName();
                        break;
                    case 10:
                        RoomTypeBreakdownReport();
                        break;
                    case 11:
                        CheckOutGuest();
                        break;
                    case 12:
                        RemoveUnavailableRooms();
                        break;
                    case 13:
                        ExtendGuestStay();
                        break;
                    case 14:
                        HighestRevenueBooking();
                        break;
                    case 15:
                        GuestPaginationViewer();
                        break;
                    case 0:
                        exit = true;
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine("press Enter to return to the menu...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

                if(!exit)
                {
                    Console.WriteLine("press Enter to return to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            // Case 1
            void AddNewRoom()
            {
                Console.WriteLine("### Add New Room ###");
                Console.WriteLine("Enter the room number: ");
                int roomNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the room type (Single / Double / Suite): ");
                string roomtype = Console.ReadLine();

                Console.WriteLine("Enter the Price per night: ");
                double price = double.Parse(Console.ReadLine());

                bool roomExist = rooms.Any(r => r.RoomNo == roomNum);

                if (roomNum > 0 && price > 0)
                {
                    if (roomExist)
                    {
                        Console.WriteLine("Error: Room with same number already exist");
                        return;
                    }
                    else
                    {
                        Room newRoom = new Room(roomNum, roomtype, price, true);
                        rooms.Add(newRoom);

                        Console.WriteLine("New room added successfully");
                        Console.WriteLine("Room Number: " + newRoom.RoomNo);
                        Console.WriteLine("Room Type: " + newRoom.RoomType);
                        Console.WriteLine("Price Per Night: " + newRoom.PricePerNight);
                        Console.WriteLine("Total Rooms in System: " + rooms.Count);
                    }
                }
                else
                {
                    Console.WriteLine("both room number and price per night must be positive");
                }

            }

        }

    }
}