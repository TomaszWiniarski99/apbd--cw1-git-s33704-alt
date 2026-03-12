// See https://aka.ms/new-console-template for more information

Double calculateAverage(int[] values)
{
    int sum = 0;
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return sum / values.Length;
}

calculateAverage(new int[] {1, 3, 2});
System.Console.WriteLine(calculateAverage(new int[] {1, 3, 2}));

Double calculateMAx(int[] values)
{
    int max = values[0];
    for (int i = 0; i < values.Length; i++)
    {
        if (values[i] > max)
        {
            max = values[i];
        };
    }
    return max;
}