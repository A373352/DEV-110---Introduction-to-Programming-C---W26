using System.Formats.Asn1;

namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        Console.Write("Please enter your Full Name: ");
        string name = Console.ReadLine();
        // - Hometown (city, state)
        Console.Write("Please enter the hometown (city, state): ");
        string Hometown = Console.ReadLine();
        Console.WriteLine($"Hometown: {Hometown}");
        // Phone Number
        Console.Write("Please enter your Phone Number.");
        string phoneNumber = Console.ReadLine();
        // - Favorite color
        Console.Write("Please enter your favorite color: ");
        string favoriteColor = Console.ReadLine();
        // - Dream job
        Console.Write("Please enter your dream job: ");
        string dreamJob = Console.ReadLine();

        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        Console.Write("Please enter your major: ");
        string major = Console.ReadLine();
        // - GPA (double, 0.0-4.0)
        Console.Write("Please enter your gpa(0.0 -4.0)");
        double gpa = double.Parse(Console.ReadLine());
        // - Graduation year (int)
        Console.Write("Please enter your graduation year: ");
        int graduationYear = int.Parse(Console.ReadLine());
        // - Is full-time student? (bool from yes/no)
        Console.Write("Is full-time student? (yes/no): ");
        string answer = Console.ReadLine();
        bool isFullTime = answer.ToLower() == "yes";

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        // - Height in inches (double)
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        Console.Write("Please enter your height in inches: ");
        int heightInches = int.Parse(Console.ReadLine());
        int feet = heightInches / 12;
        int inches = heightInches % 12;
        // - Favorite number (int)
        Console.Write("Please enter your favorite number.");
        int favoriteNumber = int.Parse(Console.ReadLine());


        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        int birthYear = 2026 - age;
        // - Years to graduation = graduationYear - 2026
        int yearsToGraduation = graduationYear - 2026;
        // - Is honor student? = gpa >= 3.5
        bool isHonorStudent = gpa >= 3.5;
        // - Age in months = age * 12
        int ageINMonths = age * 12;


        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        Console.WriteLine("\n╔════════════════════════════════════════════╗");
        Console.WriteLine("\n║             Profile Card                   ║");
        Console.WriteLine("\n╚════════════════════════════════════════════╝\n");
        // - PERSONAL INFORMATION
        Console.WriteLine("\nPersonal Information ");
        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
        Console.WriteLine($"Full Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Favorite Color: {favoriteColor}");
        Console.WriteLine($"Dream Job: {dreamJob}");
        Console.WriteLine($"Height: {feet} feet and {inches} inches");

        // - ACADEMIC DETAILS
        Console.WriteLine("\nAcademic Information ");
        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
        Console.WriteLine($"Major: {major}");
        Console.WriteLine($"GPA: {gpa:F2} / 4.00");
        Console.WriteLine($"Graduation Year: {graduationYear}");
        Console.WriteLine($"Status: {(isFullTime ? "Full-time student" : "Part-time student")}");
        Console.WriteLine($"Is honor student? {isHonorStudent} ⭐");

        // - CALCULATED STATISTICS
        Console.WriteLine("\nCALCULATED STATISTICS ");
        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
        Console.WriteLine($"Birth Year: {birthYear}");
        Console.WriteLine($"Years To Graduation: {yearsToGraduation} ");
        Console.WriteLine($"Age in months: {ageINMonths}");
        Console.WriteLine($"Favorite Number: {favoriteNumber}");

        // Use proper alignment and formatting
        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}
