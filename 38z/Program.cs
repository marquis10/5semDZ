void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*(50-10)+10, 2);
    }
}

void ReleaseArray(double[] array)
{
    double diff = 0;
    double max = 0;
    double min = 50;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    diff = max - min;
    Console.WriteLine($"Разница между max {max} и min {min} = {diff}");
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double [] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив : [{string.Join(", ", array)}]");
ReleaseArray(array);