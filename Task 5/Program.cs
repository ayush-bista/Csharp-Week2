namespace Task_5;

class Program
{
    static void Main()
    {
        // 1. Array of 5 numbers
        int[] numbers = { 42, 7, 13, 99, 23 };

        // 2. Sort ascending
        Array.Sort(numbers); // { 7, 13, 23, 42, 99 }

        // 3. Reverse (descending)
        Array.Reverse(numbers); // { 99, 42, 23, 13, 7 }

        // 4. Print using for loop
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Index {i}: {numbers[i]}");
        }

        // 5. Find index of a number
        int index = Array.IndexOf(numbers, 42);
        Console.WriteLine($"Position of 42: Index {index}");
    }
}