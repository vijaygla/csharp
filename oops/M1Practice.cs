// using System;

// class Student
// {
//     public string StudentName { get; set; }
//     public string Department { get; set; }
//     public int Quiz1 { get; set; }
//     public int Quiz2 { get; set; }
//     public int Quiz3 { get; set; }

//     public Student(string studentName, string department, int quiz1, int quiz2, int quiz3)
//     {
//         StudentName = studentName;
//         Department = department;
//         Quiz1 = quiz1;
//         Quiz2 = quiz2;
//         Quiz3 = quiz3;
//     }

//     public int GetTotalScore()
//     {
//         return Quiz1 + Quiz2 + Quiz3;
//     }
// }

// class Utility
// {
//     List<Student> list = new List<Student>();
//     // add student method
//     public void AddStudent(string studentName, string department, int quiz1, int quiz2, int quiz3)
//     {
//         Student student = new Student(studentName, department, quiz1, quiz2, quiz3);
//         list.Add(student);
//         Console.WriteLine($"Record Added: {studentName}");
//     }

//     // top by quizz
//     public void GetTopperByQuiz(string quiz)
//     {
//         int maxScore = -1;

//         foreach(var item in list)
//         {
//             int score = 0;
//             if(quiz == "Q1") score = item.Quiz1;
//             else if(quiz == "Q2") score = item.Quiz2;
//             else if(quiz == "Q3") score = item.Quiz3;

//             if(score > maxScore)
//             {
//                 maxScore = score;
//             }
//         }

//         foreach(var item in list)
//         {
//             int score = 0;
//             if(quiz == "Q1") score = item.Quiz1;
//             else if(quiz == "Q2") score = item.Quiz2;
//             else if(quiz == "Q3") score = item.Quiz3;

//             if(maxScore == score)
//             {
//                 Console.WriteLine($"{item.StudentName} {score}");
//             }
//         }
//     }

//     // top by department
//     public void GetTopperByDepartment(string department)
//     {
//         Student topperStudent = null;
//         foreach(var item in list)
//         {
//             if(item.Department == department)
//             {
//                 if(topperStudent == null || item.GetTotalScore() > topperStudent.GetTotalScore())
//                 {
//                     topperStudent = item;
//                 }
//             }
//         }
//         Console.WriteLine($"{topperStudent.StudentName} {topperStudent.GetTotalScore()}");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Utility utility = new Utility();

//         int n = int.Parse(Console.ReadLine());

//         for (int i = 0; i < n; i++)
//         {
//             string input = Console.ReadLine();
//             string[] inputs = input.Split(' ');

//             if (inputs[0] == "Record")
//             {
//                 string studentName = inputs[1];
//                 string department = inputs[2];
//                 int quiz1 = int.Parse(inputs[3]);
//                 int quiz2 = int.Parse(inputs[4]);
//                 int quiz3 = int.Parse(inputs[5]);

//                 utility.AddStudent(studentName, department, quiz1, quiz2, quiz3);
//             }
//             else if (inputs[0] == "Top")
//             {
//                 string key = inputs[1];

//                 if (key == "Q1" || key == "Q2" || key == "Q3")
//                 {
//                     utility.GetTopperByQuiz(key);
//                 }
//                 else
//                 {
//                     utility.GetTopperByDepartment(key);
//                 }
//             }
//         }
//     }
// }

// ================================================================================================
using System;
using System.Linq;
using System.Collections.Generic;

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

        var item = dict[fileName];
        var lastItem = item[item.Count - 1];
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
// Supermarket Store

// class Electronics
// {
//     public string ProductName { get; set; }
//     public double Price { get; set; }
//     public int Quantity { get; set; }
//     public int WarrantyPeriod { get; set; }

//     public Electronics(string productName, double price, int quantity, int warrantyPeriod)
//     {
//         ProductName = productName;
//         Price = price;
//         Quantity = quantity;
//         WarrantyPeriod = warrantyPeriod;
//     }
// }

// class Clothing
// {
//     public string ProductName { get; set; }
//     public double Price { get; set; }
//     public int Quantity { get; set; }
//     public string Size { get; set; }

//     public Clothing(string productName, double price, int quantity, string size)
//     {
//         ProductName = productName;
//         Price = price;
//         Quantity = quantity;
//         Size = size;
//     }
// }

// class Utility
// {
//     List<Electronics> list1 = new List<Electronics>();
//     List<Clothing> list2 = new List<Clothing>();
//     List<string> orderList = new List<string>();

//     // Add Product
//     public void AddElectronicsProduct(string productName, double price, int quantity, int warrantyPeriod)
//     {
//         Electronics electronics = new Electronics(productName, price, quantity, warrantyPeriod);
//         list1.Add(electronics);
//         orderList.Add("e");
//         Console.WriteLine($"Product added to inventory: {productName}");
//     }
//     public void AddClothingProduct(string productName, double price, int quantity, string Size)
//     {
//         Clothing clothing = new Clothing(productName, price, quantity, Size);
//         list2.Add(clothing);
//         orderList.Add("c");
//         Console.WriteLine($"Product added to inventory: {productName}");
//     }

//     // Display Product
//     public void DisplayInventory()
//     {
//         Console.WriteLine("\nInventory:");
//         int i = 0;
//         int j = 0;

//         foreach(var type in orderList)
//         {
//             if(type == "e")
//             {
//                 var item = list1[i++];
//                 Console.WriteLine($"{item.ProductName} - Price: {item.Price}, Quantity: {item.Quantity}, Warranty: {item.WarrantyPeriod} months");
//             }
//             else
//             {
//                 var item = list2[j++];
//                 Console.WriteLine($"{item.ProductName} - Price: {item.Price}, Quantity: {item.Quantity}, Size: {item.Size}");
//             }
//         }
//     }

//     // Total inventory price
//     public void CalculateTotalPrice()
//     {
//         double totalPrice = 0;

//         foreach(var item in list1)
//         {
//             totalPrice += item.Quantity * item.Price;
//         }
//         foreach(var item in list2)
//         {
//             totalPrice += item.Quantity * item.Price;
//         }

//         Console.WriteLine($"Total value of the inventory: {totalPrice:F2}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Utility utility = new Utility();
//         int n = int.Parse(Console.ReadLine());

//         for(int i=0; i<n; i++)
//         {
//             string input = Console.ReadLine();
//             string[] inputs = input.Split(',');

//             if (inputs[0].Trim() == "Electronics")
//             {
//                 string productName = inputs[1].Trim();
//                 double price = double.Parse(inputs[2].Trim());
//                 int quantity = int.Parse(inputs[3].Trim());
//                 int warrantyPeriod = int.Parse(inputs[4].Trim());

//                 utility.AddElectronicsProduct(productName, price, quantity, warrantyPeriod);
//             }
//             else if (inputs[0].Trim() == "Clothing")
//             {
//                 string productName = inputs[1].Trim();
//                 double price = double.Parse(inputs[2].Trim());
//                 int quantity = int.Parse(inputs[3].Trim());
//                 string size = inputs[4].Trim();

//                 utility.AddClothingProduct(productName, price, quantity, size);
//             }
//         }
//         utility.DisplayInventory();
//         utility.CalculateTotalPrice();
//     }
// }
// ===================================================================
// Event Planner
class MusicFestival
{
    public string Name { get; set; }
    public string Location { get; set; }
    public int Date { get; set; }
    public string HeadLine { get; set; }
    public string MusicGenere { get; set; }
    public int TicketPrice { get; set; }

    public MusicFestival(string name, string location, int date, string headLine, string musicGenere, int ticketPrice)
    {
        Name = name;
        Location = location;
        Date = date;
        HeadLine = headLine;
        MusicGenere = musicGenere;
        TicketPrice = ticketPrice;
    }
}
class FoodFestival
{
    public string Name { get; set; }
    public string Location { get; set; }
    public int Date { get; set; }
    public string Cuisine { get; set; }
    public int Stalls { get; set; }
    public int EntryFee { get; set; }

    public FoodFestival(string name, string location, int date, string cuisine, int stalls, int entryFee)
    {
        Name = name;
        Location = location;
        Date = date;
        Cuisine = cuisine;
        Stalls = stalls;
        EntryFee = entryFee;
    }
}
class ArtFestival
{
    public string Name { get; set; }
    public string Location { get; set; }
    public int Date { get; set; }
    public string ArtType { get; set; }
    public int Artist { get; set; }
    public int ExhibitionFee { get; set; }

    public ArtFestival(string name, string location, int date, string artType, int artist, int exhibitionFee)
    {
        Name = name;
        Location = location;
        Date = date;
        ArtType = artType;
        Artist = artist;
        ExhibitionFee = exhibitionFee;
    }
}

class Utility
{
    List<MusicFestival> list1 = new List<MusicFestival>();
    List<FoodFestival> list2 = new List<FoodFestival>();
    List<ArtFestival> list3 = new List<ArtFestival>();
    
    public void AddMusicFestival(string name, string location, int date, string headLine, string musicGenere, int ticketPrice)
    {
        list1.Add(new MusicFestival(name, location, date, headLine, musicGenere, ticketPrice));
    }
    public void AddFoodFestival(string name, string location, int date, string cuisine, int stalls, int entryFee)
    {
        list2.Add(new FoodFestival(name, location, date, cuisine, stalls, entryFee));
    }
    public void AddArtFestival(string name, string location, int date, string artType, int artist, int exhibitionFee)
    {
        list3.Add(new ArtFestival(name, location, date, artType, artist, exhibitionFee));
    }

    public void DisplayFestivalDetails(string name)
    {
        foreach(var item in list1)
        {
            if(item.Name == name)
            {
                Console.WriteLine($"Festival Name: {item.Name}");
                Console.WriteLine($"Location: {item.Location}");
                Console.WriteLine($"Date: {item.Date}");
                Console.WriteLine($"Headliner: {item.HeadLine}");
                Console.WriteLine($"Music Genre: {item.MusicGenere}");
                Console.WriteLine($"Ticket Price: {item.TicketPrice}");
                return;
            }
        }
        foreach(var item in list2)
        {
            if(item.Name == name)
            {
                Console.WriteLine($"Festival Name: {item.Name}");
                Console.WriteLine($"Location: {item.Location}");
                Console.WriteLine($"Date: {item.Date}");
                Console.WriteLine($"Cuisine: {item.Cuisine}");
                Console.WriteLine($"Number of Stalls: {item.Stalls}");
                Console.WriteLine($"Entry Fee: {item.EntryFee}");
                return;
            }
        }
        foreach(var item in list3)
        {
            if(item.Name == name)
            {
                Console.WriteLine($"Festival Name: {item.Name}");
                Console.WriteLine($"Location: {item.Location}");
                Console.WriteLine($"Date: {item.Date}");
                Console.WriteLine($"Art Type: {item.ArtType}");
                Console.WriteLine($"Number of Artists: {item.Artist}");
                Console.WriteLine($"Exhibition Fee: {item.ExhibitionFee}");
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
        while(true)
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');

            if(inputs[0] == "ADD_FESTIVAL")
            {
                if(inputs[1] == "MUSIC")
                {
                    string name = inputs[2];
                    string location = inputs[3];
                    int date = int.Parse(inputs[4]);
                    string headLine = inputs[5];
                    string musicGenere = inputs[6];
                    int ticketPrice = int.Parse(inputs[7]);

                    utility.AddMusicFestival(name, location, date, headLine, musicGenere, ticketPrice);
                }
                else if (inputs[1] == "FOOD")
                {
                    string name = inputs[2];
                    string location = inputs[3];
                    int date = int.Parse(inputs[4]);
                    string cuisine = inputs[5];
                    int stalls = int.Parse(inputs[6]);
                    int entryFee = int.Parse(inputs[7]);

                    utility.AddFoodFestival(name, location, date, cuisine, stalls, entryFee);
                }
                else if (inputs[1] == "ART")
                {
                    string name = inputs[2];
                    string location = inputs[3];
                    int date = int.Parse(inputs[4]);
                    string artType = inputs[5];
                    int artist = int.Parse(inputs[6]);
                    int exhibitionFee = int.Parse(inputs[7]);

                    utility.AddArtFestival(name, location, date, artType, artist, exhibitionFee);
                }
            }
            else if(inputs[0] == "DISPLAY_DETAILS")
            {
                string name = inputs[1];
                utility.DisplayFestivalDetails(name);
            }
            else if(inputs[0] == "EXIT")
            {
                return;
            }
        }
    }
}
