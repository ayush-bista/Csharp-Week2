namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create a single-dimensional integer array with 5 favorite numbers
        int[] numbers = { 5, 27, 13, 69, 23 };

        Console.WriteLine("Original Array:");
        PrintArray(numbers);

        // 2. Sort the array in ascending order
        Array.Sort(numbers);
        Console.WriteLine("\nUsing Array.Sort()");
        PrintArray(numbers);

        // 3. Reverse the sorted array (results in descending order)
        Array.Reverse(numbers);
        Console.WriteLine("\nUsing Array.Reverse()");
        
        // 4. Print each element of the array using a standard for loop
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element at index {i}: {numbers[i]}");
        }

        // 5. Use Array.IndexOf() to find the index of a specific number
        int targetNumber = 5;
        int index = Array.IndexOf(numbers, targetNumber);

        Console.WriteLine($"\nSearch Result");
        if (index != -1)
        {
            Console.WriteLine($"The number {targetNumber} was found at index {index}.");
        }
        else
        {
            Console.WriteLine($"The number {targetNumber} was not found in the array.");
        }
    }

    // Helper method to display array contents
    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}