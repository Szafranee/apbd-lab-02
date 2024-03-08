// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Cruel World!!");

Console.WriteLine(GetAvg([1, 2, 3, 4, 5]));

Console.WriteLine(GetMax([1, 2, 3, 4, 5]));

static double GetAvg(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}

static int GetMax(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}