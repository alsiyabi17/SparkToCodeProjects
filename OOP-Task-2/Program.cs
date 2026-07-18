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

        public Guest(string GuestID, string GuestName, int RoomNo, string CheckInDate, int TotalNights)
        {
            this.GuestID = GuestID;
            this.GuestName = GuestName;
            this.RoomNo = RoomNo;
            this.CheckInDate = CheckInDate;
            this.TotalNights = TotalNights;
        }

        public void DisplayGuest()
        {
            Console.WriteLine("Guest Details : ");
            Console.WriteLine("Guest ID: " + GuestID);
            Console.WriteLine("Guest Name: " + GuestName);
            Console.WriteLine("Room Number: " + RoomNo);
            Console.WriteLine("Check In Date: " + CheckInDate);
            Console.WriteLine("Total Nights: " + TotalNights);
        }

        public void CalculateTotalCost(double pricePerNight)
        {
            double totalPrice = TotalNights * pricePerNight;
            Console.WriteLine("Total Price: " + totalPrice);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
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

                if (!exit)
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
            // Case 2
            void RegisterNewGuest()
            {
                Console.WriteLine("### Register New Guest ###");

                Console.WriteLine("Enter guest name: ");
                string gname = Console.ReadLine();

                Console.WriteLine("Enter check-in date: ");
                string checkIN = Console.ReadLine();

                Console.WriteLine("Enter number of nights: ");
                int nightNum = int.Parse(Console.ReadLine());

                int nextIdNumber = guests.Count + 1;
                string guestId = "G" + nextIdNumber.ToString("D3");
                if (nightNum > 0)
                {
                    Guest newGuest = new Guest(guestId, gname, 0, checkIN, nightNum);
                    guests.Add(newGuest);

                    Console.WriteLine("New guest added successfully");
                    Console.WriteLine("Guest ID: " + newGuest.GuestID);
                    Console.WriteLine("Guest Name: " + newGuest.GuestName);
                    Console.WriteLine("Room Number: Not Assinged");
                    Console.WriteLine("Total Nights: " + newGuest.TotalNights);
                }
                else
                {
                    Console.WriteLine("Error: number of nights must be positive");
                }

            }

            // Case 3
            void BookRoomForGuest()
            {
                Console.WriteLine("Enter Guest ID: ");
                string guestId = Console.ReadLine();

                Console.WriteLine("Enter the room number: ");
                int rooNum = int.Parse(Console.ReadLine());

                Guest foundGuest = guests.FirstOrDefault(g => g.GuestID == guestId);
                Room foundRoom = rooms.FirstOrDefault(r => r.RoomNo == rooNum);

                if (foundGuest != null)
                {
                    if (foundRoom != null)
                    {
                        if (foundRoom.IsAvailable)
                        {
                            foundGuest.RoomNo = foundRoom.RoomNo;
                            foundRoom.IsAvailable = false;

                            Console.WriteLine("### room is booked successfuly ###");
                            Console.WriteLine("Guest Name: " + foundGuest.GuestName);
                            Console.WriteLine("Room Number: " + foundGuest.RoomNo);
                            Console.WriteLine("Room Type: " + foundRoom.RoomType);
                            Console.WriteLine("Price Per Night: " + foundRoom.PricePerNight);
                            Console.WriteLine("Total Nights: " + foundGuest.TotalNights);
                            foundGuest.CalculateTotalCost(foundRoom.PricePerNight);

                        }
                        else
                        {
                            Console.WriteLine("Room is already booked");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Room is Not Found");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Guest is Not Found");
                    return;
                }

            }
            // Case 4
            void ViewAllRooms()
            {
                var sortedRooms = rooms.OrderBy(r => r.RoomNo).ToList();
                Console.WriteLine("Total Rooms in System: " + sortedRooms.Count);
                if (sortedRooms.Count() == 0)
                {
                    Console.WriteLine("No rooms found in the system.");
                }
                else
                {
                    foreach (Room room in sortedRooms)
                    {
                        Console.WriteLine("Room Details: ");
                        Console.WriteLine("Room Number: " + room.RoomNo);
                        Console.WriteLine("Room Type: " + room.RoomType);
                        Console.WriteLine("Price Per Night: " + room.PricePerNight);
                        if (room.IsAvailable)
                        {
                            Console.WriteLine("Room is available");
                        }
                        else
                        {
                            Console.WriteLine("Room is not available");
                        }
                    }
                }
            }
            // Case 5
            void ViewAllGuests()
            {
                var sortedGuests = guests.OrderBy(g => g.GuestName);
                Console.WriteLine("Total Guests in System: " + sortedGuests.Count());

                if (sortedGuests.Count() == 0)
                {
                    Console.WriteLine("No guests found in the system.");

                }
                else
                {
                    foreach (Guest guest in sortedGuests)
                    {
                        Console.WriteLine("Guest Details: ");
                        Console.WriteLine("Guest ID: " + guest.GuestID);
                        Console.WriteLine("Guest Name: " + guest.GuestName);
                        Console.WriteLine("Room Number: " + (guest.RoomNo == 0 ? "Not Assigned" : guest.RoomNo.ToString()));
                        Console.WriteLine("Check In Date: " + guest.CheckInDate);
                        Console.WriteLine("Total Nights: " + guest.TotalNights);
                    }
                }
            }
            // Case 6
            void SearchAndFilterRooms()
            {
                bool exitSub = false;
                while (!exitSub)
                {
                    Console.WriteLine("### Sub Menu ###");
                    Console.WriteLine(" 1. Show all available rooms");
                    Console.WriteLine(" 2. Filter by room type");
                    Console.WriteLine(" 3. Filter by max price");
                    Console.WriteLine(" 4. Room price statistics");
                    Console.WriteLine(" 0. Back");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            var AllRooms = rooms.Where(r => r.IsAvailable == true).OrderBy(r => r.PricePerNight);

                            if (AllRooms.Count() == 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                Console.WriteLine("Number of Available rooms " + AllRooms.Count());
                                foreach (var room in AllRooms)
                                {
                                    Console.WriteLine("Room Info : ");
                                    Console.WriteLine("Room Number: " + room.RoomNo);
                                    Console.WriteLine("Room Type: " + room.RoomType);
                                    Console.WriteLine("Price Per Night: " + room.PricePerNight.ToString("F2"));
                                    Console.WriteLine("Room Available\n");
                                }
                            }
                            break;

                        case "2":
                            Console.WriteLine("Enter the room type (Single / Double / Suite): ");
                            string roomtype = Console.ReadLine();

                            var FilterByType = rooms.Where(r => r.RoomType.ToLower() == roomtype.ToLower());

                            if (FilterByType.Count() == 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                Console.WriteLine("Number of Matching rooms " + FilterByType.Count());
                                foreach (var room in FilterByType)
                                {
                                    Console.WriteLine("Room Info : ");
                                    Console.WriteLine("Room Number: " + room.RoomNo);
                                    Console.WriteLine("Room Type: " + room.RoomType);
                                    Console.WriteLine("Price Per Night: " + room.PricePerNight.ToString("F2"));
                                    if (room.IsAvailable)
                                    {
                                        Console.WriteLine("Room Available\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Room Booked\n");
                                    }
                                }
                            }
                            break;

                        case "3":
                            Console.WriteLine("Enter the maximum price: ");
                            double maxPrice = double.Parse(Console.ReadLine());

                            var FilterbyPrice = rooms.Where(r => r.IsAvailable == true && r.PricePerNight <= maxPrice).OrderBy(r => r.PricePerNight);

                            if (FilterbyPrice.Count() == 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                Console.WriteLine("Number of Available rooms " + FilterbyPrice.Count());
                                foreach (var room in FilterbyPrice)
                                {
                                    Console.WriteLine("Room Info : ");
                                    Console.WriteLine("Room Number: " + room.RoomNo);
                                    Console.WriteLine("Room Type: " + room.RoomType);
                                    Console.WriteLine("Price Per Night: " + room.PricePerNight.ToString("F2"));
                                    Console.WriteLine("Room Available\n");
                                }
                            }
                            break;

                        case "4":
                            if (rooms.Count() == 0)
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                int totalRooms = rooms.Count();
                                int availableRooms = rooms.Count(r => r.IsAvailable == true);
                                double avgPrice = rooms.Average(r => r.PricePerNight);
                                double minPrice = rooms.Min(r => r.PricePerNight);
                                double maxPriceStat = rooms.Max(r => r.PricePerNight);

                                Console.WriteLine("Total Rooms: " + totalRooms);
                                Console.WriteLine("Available Rooms: " + availableRooms);
                                Console.WriteLine("Average Price: " + avgPrice.ToString("F2"));
                                Console.WriteLine("Cheapest Price: " + minPrice.ToString("F2"));
                                Console.WriteLine("Most Expensive Price: " + maxPriceStat.ToString("F2"));
                            }
                            break;

                        case "0":
                            exitSub = true;
                            break;
                    }
                }
            }
            // Case 7
            void GuestAndBookingStatistics()
            {
                Console.WriteLine("### Guest & Booking Statistics ###");
                Console.WriteLine("Total Guests: " + guests.Count());

                var bookedGuests = guests.Where(g => g.RoomNo != 0);
                Console.WriteLine("Total Booked Guests: " + bookedGuests.Count());

                var availableRooms = rooms.Where(r => r.IsAvailable == true);
                Console.WriteLine("Total Available Rooms: " + availableRooms.Count());

                Console.WriteLine("Total Rooms: " + rooms.Count());

                var bookedRooms = rooms.Where(r => r.IsAvailable == false);
                Console.WriteLine("Total Booked Rooms: " + bookedRooms.Count());

                if (!guests.Any(g => g.RoomNo != 0))
                {
                    Console.WriteLine("No guests have booked rooms yet.");
                }
                else
                {
                    var AvgGuestsAssigend = guests.Where(g => g.RoomNo != 0).Average(g => g.TotalNights);
                    Console.WriteLine("Average Nights per Guest: " + AvgGuestsAssigend.ToString("F2"));

                    var TopGuest = guests.Where(g => g.RoomNo != 0).OrderByDescending(g => g.TotalNights * rooms.FirstOrDefault(r => r.RoomNo == g.RoomNo).PricePerNight).Take(3);

                    foreach (var guest in TopGuest)
                    {
                        var room = rooms.FirstOrDefault(r => r.RoomNo == guest.RoomNo);
                        double totalCost = guest.TotalNights * room.PricePerNight;
                        Console.WriteLine("Top Guest: " + guest.GuestName + ", Total Cost: " + totalCost.ToString("F2"));
                    }
                    var summaries = guests
                        .Where(g => g.RoomNo != 0)
                        .Select(g => {
                            double roomPrice = rooms.FirstOrDefault(r => r.RoomNo == g.RoomNo).PricePerNight;
                            double totalCost = g.TotalNights * roomPrice;
                            return $"{g.GuestName} — Room {g.RoomNo} — {g.TotalNights} nights — OMR {totalCost.ToString("F2")}";
                        });

                    foreach (var summary in summaries)
                    {
                        Console.WriteLine(summary);
                    }
                }
            }
            // Case 8
            void UpdateRoomPrice()
            {
                Console.WriteLine("Enter a room number: ");
                int rnum = int.Parse(Console.ReadLine());
                var room = rooms.FirstOrDefault(r => r.RoomNo == rnum);

                if (room != null)
                {
                    Console.WriteLine("Enter the updated  new price per night: ");
                    double perNight = double.Parse(Console.ReadLine());

                    if (perNight >= 0)
                    {
                        Console.WriteLine($"Old price per night: {room.PricePerNight}");
                        room.PricePerNight = perNight;
                        Console.WriteLine($"new price per night: {room.PricePerNight}");
                    }
                    else
                    {
                        Console.WriteLine("Error: the newly entered price must be positive");
                    }
                }
                else
                {
                    Console.WriteLine($"Error: room with {rnum} number is not found");
                    return;
                }
            }
            // Case 9
            void GuestLookupByName()
            {
                Console.WriteLine("Enter name or partial name to search for: ");
                string searchName = Console.ReadLine();

                var guestFound = guests.Where(g => g.GuestName.ToLower().Contains(searchName.ToLower()));

                if (guestFound.Count() != 0)
                {
                    Console.WriteLine($"{guestFound.Count()} guests found with name '{searchName}' ");
                    foreach (var guest in guestFound)
                    {
                        Console.WriteLine("Found guest by name info :");
                        Console.WriteLine($"Guest ID: {guest.GuestID}");
                        Console.WriteLine($"Guest Name: {guest.GuestName}");
                        Console.WriteLine($"Guest Room number: {guest.RoomNo}");
                    }
                }
                else
                {
                    Console.WriteLine("No guests matched that search");
                }
            }
        }
    }
}