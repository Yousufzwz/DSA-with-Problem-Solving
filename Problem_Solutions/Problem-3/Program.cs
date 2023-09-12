//Palindrome Check

bool IsPalindrome(string text)
{
    string solidInput = text.Replace(" ",string.Empty).ToLower();
    int leftCounter = 0; 
    int rightCounter = solidInput.Length -1 ;

    while(leftCounter < rightCounter)
    {
        if (solidInput[leftCounter] != solidInput[rightCounter])
        {
            return false;
        }
        leftCounter++;
        rightCounter--;
    }
    return true;

}

string textInput= Console.ReadLine();
if(IsPalindrome(textInput))
{
    Console.WriteLine("Palindrome!");
}
else
{
    Console.WriteLine("Not Palindrome!");
}