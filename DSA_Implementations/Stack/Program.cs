

Stack<int> elements = new();
elements.Push(1);
elements.Push(2);
elements.Push(3);
Console.WriteLine($"Top Element:{elements.Peek()}");
Console.WriteLine($"Size:{elements.Count()}");
elements.Pop();
Console.WriteLine($"After removing top element, now top Element:{elements.Peek()}");
