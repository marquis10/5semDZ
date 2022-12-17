//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел
void InputArray(int[] array)
{    
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99,1000);
}        
    
void ReleaseArray(int[] array)
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            Count++;
    }
    Console.Write(Count);
}

Console.Clear();
Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);