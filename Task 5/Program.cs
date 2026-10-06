namespace Task_5;

class Program
{
    static void Main()
    {
        // Create birthdate
        DateTime birthDate = new DateTime(2006, 5, 31);

        // Create current date and time
        DateTime currentDate = DateTime.Now;

        // Calculate the difference using TimeSpan
        TimeSpan ageDifference = currentDate - birthDate;

        // Calculate age in years
        int age = (int)(ageDifference.TotalDays / 365.25);

        // Print details
        Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");
        Console.WriteLine($"Current Date & Time: {currentDate}");
        Console.WriteLine($"Age: {age} years");

        // Add 10 days to birthdate
        DateTime newDate = birthDate.AddDays(10);

        Console.WriteLine($"Birthdate + 10 days: {newDate:yyyy-MM-dd}");
    }
}