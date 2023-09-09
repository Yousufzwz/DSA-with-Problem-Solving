
//Parentheses Balance (UVA_673)

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    Console.WriteLine(IsBalanced(s)? "Yes":"No");
}

bool IsBalanced(string s)
{
    Stack<char> stk= new ();

    foreach(char c in s)
    {
        if (c == '(' ||  c == '[')
        {
            stk.Push (c);   
        }
        else if(c == ')' && (stk.Count == 0 || stk.Pop() != '('))
        {
            return false;
        }
        else if (c == ']' && (stk.Count == 0 || stk.Pop() != '['))
        {
            return false;
        }
    }
    return stk.Count == 0;
}