

int LargestElement(List<int> list)
{
    if(list.Count ==0)
    {
        Console.WriteLine("Empty list!");
    }

    int largest = list[0];
    foreach(int i in list)
    {
        if(i > largest)
        {
            largest = i;
        }
    }
    return largest;
}

Console.Write("Enter the number of elements in the list: ");
int n = int.Parse(Console.ReadLine());

List<int> list = new List<int>();

for (int i = 0; i < n; i++)
{
    Console.Write("Enter element " + (i + 1) + ": ");
    int element = int.Parse(Console.ReadLine());
    list.Add(element);
}

int largest = LargestElement(list);
Console.WriteLine($"The largest element is:{largest}");
    