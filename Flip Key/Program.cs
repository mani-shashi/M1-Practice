public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Enter the word:");
        string? input = Console.ReadLine();

        string generatedKey = CleanseAndInvert(input);

        Console.WriteLine($"The generated key is - {generatedKey}");
    }

    public static string CleanseAndInvert(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 6) return "";

        string key = "";
        int index = 0;

        for (int i = input.Length - 1; i >= 0; i--) // starting from last index, to avoid extra reverse step
        {
            char charValue = char.ToLower(input[i]);
            int asciiValue = (int) charValue;

            if (!IsEven(asciiValue)) // if ascii value is not even
            {
                if (IsEven(index)) 
                {
                    charValue = char.ToUpper(charValue);
                } // if at even position, converted to upper case.

                key += charValue;
                index++;
            }
        }
        return key;
    }

    public static bool IsEven(int num)
    {
        return (num % 2 == 0);
    }
}
