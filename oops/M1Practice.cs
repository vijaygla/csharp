class Student
{
    public string StudentName { get; set; }
    public string Department { get; set; }
    public int Quiz1 { get; set; }
    public int Quiz2 { get; set; }
    public int Quiz3 { get; set; }

    public Student(string studentName, string department, int quiz1, int quiz2, int quiz3)
    {
        StudentName = studentName;
        Department = department;
        Quiz1 = quiz1;
        Quiz2 = quiz2;
        Quiz3 = quiz3;
    }

    public int GetTotalScore()
    {
        return Quiz1 + Quiz2 + Quiz3;
    }
}

class Utility
{
    List<Student> list = new List<Student>();
    // add student method
    public void AddStudent(string studentName, string department, int quiz1, int quiz2, int quiz3)
    {
        Student student = new Student(studentName, department, quiz1, quiz2, quiz3);
        list.Add(student);
        Console.WriteLine($"Record Added: {studentName}");
    }

    // top by quizz
    public void GetTopperByQuiz(string quiz)
    {
        int maxScore = -1;

        foreach(var item in list)
        {
            int score = 0;
            if(quiz == "Q1") score = item.Quiz1;
            else if(quiz == "Q2") score = item.Quiz2;
            else if(quiz == "Q3") score = item.Quiz3;

            if(score > maxScore)
            {
                maxScore = score;
            }
        }

        foreach(var item in list)
        {
            int score = 0;
            if(quiz == "Q1") score = item.Quiz1;
            else if(quiz == "Q2") score = item.Quiz2;
            else if(quiz == "Q3") score = item.Quiz3;

            if(maxScore == score)
            {
                Console.WriteLine($"{item.StudentName} {score}");
            }
        }
    }

    // top by department
    public void GetTopperByDepartment(string department)
    {
        Student topperStudent = null;
        foreach(var item in list)
        {
            if(item.Department == department)
            {
                if(topperStudent == null || item.GetTotalScore() > topperStudent.GetTotalScore())
                {
                    topperStudent = item;
                }
            }
        }
        Console.WriteLine($"{topperStudent.StudentName} {topperStudent.GetTotalScore()}");
    }
}
class Program
{
    static void Main()
    {
        Utility utility = new Utility();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');

            if (inputs[0] == "Record")
            {
                string studentName = inputs[1];
                string department = inputs[2];
                int quiz1 = int.Parse(inputs[3]);
                int quiz2 = int.Parse(inputs[4]);
                int quiz3 = int.Parse(inputs[5]);

                utility.AddStudent(studentName, department, quiz1, quiz2, quiz3);
            }
            else if (inputs[0] == "Top")
            {
                string key = inputs[1];

                if (key == "Q1" || key == "Q2" || key == "Q3")
                {
                    utility.GetTopperByQuiz(key);
                }
                else
                {
                    utility.GetTopperByDepartment(key);
                }
            }
        }
    }
}

// ================================================================================================
class Version
{
    public string VersionName { get; set; }
    public int FileSize { get; set; }

    public Version(string versionName, int fileSize)
    {
        VersionName = versionName;
        FileSize = fileSize;
    }
}

class Utility
{
    public Dictionary<String, List<Version>> dict = new Dictionary<string, List<Version>>();

    // upload
    public void Upload(string fileName, string versionName, int fileSize)
    {
        if (!dict.ContainsKey(fileName))
        {
            List<Version> version = new List<Version>();
            dict[fileName] = version;
        }
        foreach (var v in dict[fileName])
        {
            if (v.VersionName == versionName)
            {
                return;
            }
        }
        dict[fileName].Add(new Version(versionName, fileSize));
    }

    // fetch
    public void Fetch(string fileName)
    {
        if (!dict.ContainsKey(fileName))
        {
            Console.WriteLine("File Not Found");
            return;
        }

        var sorted = dict[fileName].OrderBy(v => v.FileSize).ThenBy(v => v.VersionName);

        foreach (var kv in sorted)
        {
            Console.WriteLine($"{fileName} {kv.VersionName} {kv.FileSize}");
        }
    }

    // latest
    public void Latest(string fileName)
    {
        if (!dict.ContainsKey(fileName))
        {
            Console.WriteLine("File Not Found");
            return;
        }

        // var item = dict[fileName];
        // var lastItem = item[item.Count - 1];
        // or
        var lastItem = dict[fileName].Last();
        Console.WriteLine($"{fileName} {lastItem.VersionName} {lastItem.FileSize}");
    }

    // TotalStorage
    public void TotalStorage(string fileName)
    {
        if (!dict.ContainsKey(fileName))
        {
            Console.WriteLine("File Not Found");
            return;
        }
        int totalStorage = 0;

        foreach (var v in dict[fileName])
        {
            totalStorage += v.FileSize;
        }
        Console.WriteLine($"{fileName} {totalStorage}");
    }
}


class Program
{
    static void Main()
    {
        Utility utility = new Utility();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            string[] inputs = input.Split(' ');
            string operation = inputs[0];

            if (operation == "UPLOAD")
            {
                string fileName = inputs[1];
                string versionName = inputs[2];
                int fileSize = int.Parse(inputs[3]);

                utility.Upload(fileName, versionName, fileSize);
            }
            else if (operation == "FETCH")
            {
                string fileName = inputs[1];
                utility.Fetch(fileName);
            }
            else if (operation == "LATEST")
            {
                string fileName = inputs[1];
                utility.Latest(fileName);
            }
            else if (operation == "TOTAL_STORAGE")
            {
                string fileName = inputs[1];
                utility.TotalStorage(fileName);
            }
        }
    }
}

// ==================================================================================
class Music
{
    public string PlaylistName { get; set; }
    public string SongId { get; set; }
    public int Duration { get; set; }

    public Music(string playlistName, string songId, int duration)
    {
        PlaylistName = playlistName;
        SongId = songId;
        Duration = duration;
    }
}

class Utility
{
    Dictionary<string, List<Music>> dict = new Dictionary<string, List<Music>>();

    // method to add song
    public void AddMusic(string playlistName, string songId, int duration)
    {
        if (!dict.ContainsKey(playlistName))
        {
            dict[playlistName] = new List<Music>();
        }
        foreach (var item in dict[playlistName])
        {
            if (item.SongId == songId)
            {
                return;
            }
        }
        dict[playlistName].Add(new Music(playlistName, songId, duration));
        Console.WriteLine("Music added successfully");
    }

    // method to display the playlist
    public void PlayList(string playlistName)
    {
        if (!dict.ContainsKey(playlistName))
        {
            Console.WriteLine("File Not Found");
        }
        var sortedItem = dict[playlistName].OrderBy(x => x.Duration).ThenBy(x => x.SongId);

        foreach (var item in sortedItem)
        {
            Console.WriteLine($"{playlistName} {item.SongId} {item.Duration}");
        }
    }

    // method to find the recently added music
    public void Recent(string playlistName)
    {
        if (!dict.ContainsKey(playlistName))
        {
            Console.WriteLine("File Not Found");
        }
        var lastItem = dict[playlistName].Last();
        Console.WriteLine($"{playlistName} {lastItem.SongId} {lastItem.Duration}");
    }

    // method to calculate total duration
    public void TotalDuration(string playlistName)
    {
        double totalDuration = 0;

        foreach (var item in dict[playlistName])
        {
            totalDuration += item.Duration;
        }
        Console.WriteLine($"{playlistName} {totalDuration}");
    }
}

class Program
{
    static void Main()
    {
        Utility utility = new Utility();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            string[] inputs = input.Split(' ');

            string operation = inputs[0];
            if (operation == "AddMusic")
            {
                string playlistName = inputs[1];
                string songId = inputs[2];
                int duration = int.Parse(inputs[3]);

                utility.AddMusic(playlistName, songId, duration);
            }

            else if (operation == "PlayList")
            {
                string playlistName = inputs[1];
                utility.PlayList(playlistName);
            }

            else if (operation == "Recent")
            {
                string playlistName = inputs[1];
                utility.Recent(playlistName);
            }

            else if (operation == "TotalDuration")
            {
                string playlistName = inputs[1];
                utility.TotalDuration(playlistName);
            }
        }
    }
}

// 5
// AddMusic Rock S1 200
// AddMusic Rock S2 150
// AddMusic Rock S3 200
// PlayList Rock
// Recent Rock

// ========================================================================================
// Supermarket Store
class Product
{
    public string Type { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public int Warranty { get; set; }
    public string Size { get; set; }
}

class Utility
{
    List<Product> list = new List<Product>();

    // method to add item in inventory
    public void AddProduct(Product product)
    {
        list.Add(product);
        Console.WriteLine($"Product added to inventory: {product.Name}");
    }

    // method to Display
    public void Display()
    {
        Console.WriteLine("\nInventory:");
        foreach (var item in list)
        {
            if (item.Type == "Electronics")
            {
                Console.WriteLine($"{item.Name} - Price: {item.Price}, Quantity: {item.Quantity}, Warranty: {item.Warranty} months");
            }
            else if (item.Type == "Clothing")
            {
                Console.WriteLine($"{item.Name} - Price: {item.Price}, Quantity: {item.Quantity}, Size: {item.Size}");
            }
        }
    }

    // method to calculate price of all item in Inventory
    public void TotalPrice()
    {
        double totalPrice = 0;
        foreach (var item in list)
        {
            totalPrice += item.Price * item.Quantity;
        }
        Console.WriteLine($"Total value of the inventory: {totalPrice:F2}");
    }
}

class Program
{
    static void Main()
    {
        Utility utility = new Utility();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(",");

            string type = inputs[0].Trim();
            string name = inputs[1].Trim();
            double price = double.Parse(inputs[2].Trim());
            int quantity = int.Parse(inputs[3].Trim());

            Product product = new Product();
            product.Type = type;
            product.Name = name;
            product.Price = price;
            product.Quantity = quantity;
            if (type == "Electronics")
            {
                product.Warranty = int.Parse(inputs[4].Trim());
            }
            else if (type == "Clothing")
            {
                product.Size = inputs[4].Trim();
            }
            utility.AddProduct(product);
        }
        utility.Display();
        utility.TotalPrice();
    }
}

// ============================================================================================
class Electronics
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public int WarrantyPeriod { get; set; }

    public Electronics(string productName, double price, int quantity, int warrantyPeriod)
    {
        ProductName = productName;
        Price = price;
        Quantity = quantity;
        WarrantyPeriod = warrantyPeriod;
    }
}

class Clothing
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Size { get; set; }

    public Clothing(string productName, double price, int quantity, string size)
    {
        ProductName = productName;
        Price = price;
        Quantity = quantity;
        Size = size;
    }
}

class Utility
{
    List<Electronics> list1 = new List<Electronics>();
    List<Clothing> list2 = new List<Clothing>();
    List<string> orderList = new List<string>();

    // Add Product
    public void AddElectronicsProduct(string productName, double price, int quantity, int warrantyPeriod)
    {
        Electronics electronics = new Electronics(productName, price, quantity, warrantyPeriod);
        list1.Add(electronics);
        orderList.Add("e");
        Console.WriteLine($"Product added to inventory: {productName}");
    }
    public void AddClothingProduct(string productName, double price, int quantity, string Size)
    {
        Clothing clothing = new Clothing(productName, price, quantity, Size);
        list2.Add(clothing);
        orderList.Add("c");
        Console.WriteLine($"Product added to inventory: {productName}");
    }

    // Display Product
    public void DisplayInventory()
    {
        Console.WriteLine("\nInventory:");
        int i = 0;
        int j = 0;

        foreach(var type in orderList)
        {
            if(type == "e")
            {
                var item = list1[i++];
                Console.WriteLine($"{item.ProductName} - Price: {item.Price}, Quantity: {item.Quantity}, Warranty: {item.WarrantyPeriod} months");
            }
            else
            {
                var item = list2[j++];
                Console.WriteLine($"{item.ProductName} - Price: {item.Price}, Quantity: {item.Quantity}, Size: {item.Size}");
            }
        }
    }

    // Total inventory price
    public void CalculateTotalPrice()
    {
        double totalPrice = 0;

        foreach(var item in list1)
        {
            totalPrice += item.Quantity * item.Price;
        }
        foreach(var item in list2)
        {
            totalPrice += item.Quantity * item.Price;
        }

        Console.WriteLine($"Total value of the inventory: {totalPrice:F2}");
    }
}

class Program
{
    static void Main()
    {
        Utility utility = new Utility();
        int n = int.Parse(Console.ReadLine());

        for(int i=0; i<n; i++)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(',');

            if (inputs[0].Trim() == "Electronics")
            {
                string productName = inputs[1].Trim();
                double price = double.Parse(inputs[2].Trim());
                int quantity = int.Parse(inputs[3].Trim());
                int warrantyPeriod = int.Parse(inputs[4].Trim());

                utility.AddElectronicsProduct(productName, price, quantity, warrantyPeriod);
            }
            else if (inputs[0].Trim() == "Clothing")
            {
                string productName = inputs[1].Trim();
                double price = double.Parse(inputs[2].Trim());
                int quantity = int.Parse(inputs[3].Trim());
                string size = inputs[4].Trim();

                utility.AddClothingProduct(productName, price, quantity, size);
            }
        }
        utility.DisplayInventory();
        utility.CalculateTotalPrice();
    }
}

// ===================================================================
// Event Planner
class Festival
{
    public string Type;
    public string Name;
    public string Location;
    public int Date;

    // unknown attribute
    public string A;
    public string B;
    public int C;
}

class Utility
{
    List<Festival> list = new List<Festival>();

    // add festival
    public void AddFestival(Festival f)
    {
        list.Add(f);
    }

    // display festival
    public void DisplayFestival(string name)
    {
        if (!list.Any(x => x.Name == name))
        {
            Console.WriteLine("Festival Not Found");
            return;
        }

        foreach (var item in list)
        {
            if (item.Name == name)
            {
                Console.WriteLine($"Festival Name: {item.Name}");
                Console.WriteLine($"Location: {item.Location}");
                Console.WriteLine($"Date: {item.Date}");

                if (item.Type == "MUSIC")
                {
                    Console.WriteLine($"Headliner: {item.A}");
                    Console.WriteLine($"Music Genre: {item.B}");
                    Console.WriteLine($"Ticket Price: {item.C}");
                }
                else if (item.Type == "FOOD")
                {
                    Console.WriteLine($"Cuisine: {item.A}");
                    Console.WriteLine($"Number of Stalls: {item.B}");
                    Console.WriteLine($"Entry Fee: {item.C}");
                }
                else if (item.Type == "ART")
                {
                    Console.WriteLine($"Art Type: {item.A}");
                    Console.WriteLine($"Number of Artists: {item.B}");
                    Console.WriteLine($"Exhibition Fee: {item.C}");
                }
                return;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Utility utility = new Utility();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            string[] inputs = input.Split(' ');

            if (inputs[0] == "ADD_FESTIVAL")
            {
                Festival f = new Festival();
                f.Type = inputs[1];
                f.Name = inputs[2];
                f.Location = inputs[3];
                f.Date = int.Parse(inputs[4]);

                if (f.Type == "MUSIC")
                {
                    f.A = inputs[5];
                    f.B = inputs[6];
                    f.C = int.Parse(inputs[7]);
                }
                else if (f.Type == "ART")
                {
                    f.A = inputs[5];
                    f.B = inputs[6];
                    f.C = int.Parse(inputs[7]);
                }
                else if (f.Type == "FOOD")
                {
                    f.A = inputs[5];
                    f.B = inputs[6];
                    f.C = int.Parse(inputs[7]);
                }
                utility.AddFestival(f);
            }

            else if (inputs[0] == "DISPLAY_DETAILS")
            {
                string name = inputs[1];
                utility.DisplayFestival(name);
            }
            else if (inputs[0] == "EXIT")
            {
                return;
            }
        }
    }
}

// =======================================================================================
class Passenger
{
    public string PassengerId { get; set; }
    public int SeatNumber { get; set; }
    public string Status { get; set; }

    public Passenger(string passengerId)
    {
        PassengerId = passengerId;
        SeatNumber = -1;
        Status = "WAITLISTED";
    }
}

class Flight
{
    public string FlightNumber { get; set; }
    public int TotalSeat { get; set; }
    public List<Passenger> BookedPassenger = new List<Passenger>();
    public Queue<Passenger> WaitList = new Queue<Passenger>();

    public Flight(string flightNumber, int totalSeat)
    {
        FlightNumber = flightNumber;
        TotalSeat = totalSeat;
    }
}

class Utility
{
    public Dictionary<string, Flight> dict = new Dictionary<string, Flight>();

    // create flight
    public void CreateFlight(string flightNumber, int totalSeat)
    {
        if (!dict.ContainsKey(flightNumber))
        {
            dict[flightNumber] = new Flight(flightNumber, totalSeat);
            Console.WriteLine($"Flight {flightNumber} have {totalSeat} seat");
        }
    }

    // book flight
    public void BookFlight(string flightNumber, string passengerId)
    {
        if (!dict.ContainsKey(flightNumber))
        {
            return;
        }
        Flight f = dict[flightNumber];
        Passenger p = new Passenger(passengerId);

        if (f.BookedPassenger.Count < f.TotalSeat)
        {
            p.Status = "CONFIRMED";
            p.SeatNumber = f.BookedPassenger.Count + 1;
            f.BookedPassenger.Add(p);

            Console.WriteLine($"{passengerId} Confirmed || SeatNumber: {p.SeatNumber}");
        }
        else
        {
            f.WaitList.Enqueue(p);
            Console.WriteLine($"{passengerId} WaitListed");
        }
    }
    // Cancel
    public void CancelFlight(string flightNumber, string passengerId)
    {
        if (!dict.ContainsKey(flightNumber))
        {
            return;
        }
        Flight f = dict[flightNumber];
        Passenger p = null;

        foreach (var item in f.BookedPassenger)
        {
            if (item.PassengerId == passengerId)
            {
                p = item;
                break;
            }
        }
        if (p != null)
        {
            f.BookedPassenger.Remove(p);
            Console.WriteLine($"{passengerId} cancelled");

            // reassianed seat
            for (int i = 0; i < f.BookedPassenger.Count; i++)
            {
                f.BookedPassenger[i].SeatNumber = i + 1;
            }

            // move waiting list to confirm
            if (f.WaitList.Count > 0)
            {
                Passenger wp = f.WaitList.Dequeue();
                wp.Status = "CONFIRMED";
                wp.SeatNumber = f.BookedPassenger.Count + 1;

                f.BookedPassenger.Add(wp);
                Console.WriteLine($"{wp.PassengerId} Confirmed || SeatNumber : {wp.SeatNumber}");
            }
        }
        else
        {
            // remove from waitlist since queue cannot direct remove so create new queue of remaining passenger in waiting queue
            f.WaitList = new Queue<Passenger>(f.WaitList.Where(x => x.PassengerId != passengerId));
            Console.WriteLine($"{passengerId} removed from waiting queue");
        }
    }

    // flight status
    public void FlightStatus(string flightNumber)
    {
        if (!dict.ContainsKey(flightNumber)) return;

        var f = dict[flightNumber];

        Console.WriteLine("Confirmed");
        foreach (var p in f.BookedPassenger)
        {
            Console.WriteLine($"{p.PassengerId} {p.SeatNumber}");
        }

        Console.WriteLine("Waitlisted");
        foreach (var p in f.WaitList)
        {
            Console.WriteLine($"{p.PassengerId}");
        }
    }

    // passenger status
    public void PassengerStatus(string passengerId)
    {
        foreach (var item in dict.Values)
        {
            var p = item.BookedPassenger.FirstOrDefault(x => x.PassengerId == passengerId);

            if (p != null)
            {
                Console.WriteLine($"{passengerId} Confirmed {p.SeatNumber}");
                return;
            }
            if (item.WaitList.Any(x => x.PassengerId == passengerId))
            {
                Console.WriteLine($"{passengerId} Waitlisted");
                return;
            }
        }
        Console.WriteLine($"{passengerId} Not Found");
    }
}

class Program
{
    static void Main()
    {
        Utility utility = new Utility();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');

            if (inputs[0] == "CREATE_FLIGHT")
            {
                string flightNumber = inputs[1];
                int totalSeat = int.Parse(inputs[2]);

                utility.CreateFlight(flightNumber, totalSeat);
            }

            else if (inputs[0] == "BOOK")
            {
                string flightNumber = inputs[1];
                string passengerId = inputs[2];

                utility.BookFlight(flightNumber, passengerId);
            }

            else if (inputs[0] == "CANCEL")
            {
                string flightNumber = inputs[1];
                string passengerId = inputs[2];

                utility.CancelFlight(flightNumber, passengerId);
            }

            else if (inputs[0] == "FLIGHT_STATUS")
            {
                string flightNumber = inputs[1];

                utility.FlightStatus(flightNumber);
            }

            else if (inputs[0] == "PASSENGER_STATUS")
            {
                string passengerId = inputs[1];
            }
        }
    }
}
