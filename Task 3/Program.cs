namespace Task_3;

class Program
{
    static void Main()
    {
        // Declare and initialize variables
        byte byteValue = 10;
        short shortValue = 20;
        int intValue = 42;
        long longValue = 100000L;
        float floatValue = 3.14f;
        double doubleValue = 6.28;
        decimal decimalValue = 99.99m;
        char charValue = 'A';
        bool boolValue = true;

        // Type conversion
        string intAsString = intValue.ToString();
        double stringAsDouble = Convert.ToDouble("3.14");

        // Print variables with labels
        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"bool: {boolValue}");

        Console.WriteLine($"int converted to string: {intAsString}");
        Console.WriteLine($"string converted to double: {stringAsDouble}");
    }
}