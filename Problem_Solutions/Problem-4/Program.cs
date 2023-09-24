

string ReverseString(string input)
{
    char[] inputChar = new char[input.Length];
    int length = input.Length;

    for(int i = 0; i < length; i++)
    {
        inputChar[i] = input[length - 1 -i];
    }

    return new string(inputChar);
}

Console.Write("Enter input string:");
string inp =Console.ReadLine();
string reversedString = ReverseString(inp);
Console.WriteLine($"Reversed String:{reversedString}");