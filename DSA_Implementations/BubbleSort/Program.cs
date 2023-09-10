using System.Diagnostics;

Random rng = new Random(0);


void BubbleSort(int[]arr)
{
    Stopwatch stopwatch = new();
    stopwatch.Start();
    int n = arr.Length;

    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    stopwatch.Stop();   
    TimeSpan duration = stopwatch.Elapsed;
    Console.WriteLine(duration.TotalMilliseconds + "ms");
}


int n = 50000;
int[] arr = new int[n];
for(int i = 0; i<n; i++)
{
    arr[i] = rng.Next(0, n+1);  // [0 ~ 50000]
}

BubbleSort(arr);


//void BubbleSort(int n)
//{
//    for(int i = 0; i < n; i++)
//    {
//        for(int j= i+1; j < n; j++)
//        {
//            if (arr[i] > arr[j])
//            {
//                int temp = arr[i];
//                arr[i] = arr[j];
//                arr[j] = temp;
//            }
//        }
//    }
//}

//int n = 10;
//int[] arr = new int[n];

//for (int i = 0; i < n;i++)
//{
//    arr[i] = n - i;
//}

//BubbleSort(n);

//for(int i=0; i < n; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//Console.WriteLine();





