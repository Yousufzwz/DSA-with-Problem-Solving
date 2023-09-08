


string inputString = Console.ReadLine(); //mm#al#hmws##ud

Stack<char> stk = new ();
for (int i = 0; i < inputString.Length; i++)
{
    if (inputString[i] == '#')
    {
        stk.Pop();
    }
    else
    {
        stk.Push(inputString[i]);
    }
}

PrintStringFromStack(stk);
//while (stk.Count > 0)
//{
//    Console.Write(stk.Peek());
//    stk.Pop();
//}


void PrintStringFromStack(Stack<char> stk)
{
    if (stk.Count == 0)
    {
        return;
    }

    char element = stk.Peek();
    stk.Pop();
    PrintStringFromStack(stk);
    Console.Write(element);
}
