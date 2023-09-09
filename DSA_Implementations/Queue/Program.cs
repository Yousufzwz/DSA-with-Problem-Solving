

Queue<int> elements = new();
elements.Enqueue(1);
elements.Enqueue(2);
elements.Enqueue(3);
Console.WriteLine($"First Element:{elements.Peek()}");
Console.WriteLine($"Size:{elements.Count()}");
elements.Dequeue();
Console.WriteLine($"After removing first element, now first Element:{elements.Peek()}");
