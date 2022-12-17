// Гипотеза Гольдбаха
//https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=6&id_topic=117&id_problem=723
int Goldbah(int d = 0)
{
for (int i = 2; i < n; i++)
{
    d = n - i;
    for (int j = 2; j < d; j++)
    {
        if (d % j == 0)
            break;
        if (i % j == 0)
            break;
    }
    /*if (d % 1 == 0 && i % 1 == 0 && d % d == 0 && i % i == 0)
        Console.WriteLine($"Число {n} раскладывает по теории Гольдбаха на {i} и {d}");
    */
}
}
Console.Clear();
Console.WriteLine("Введите чётное число: ");
int n = Convert.ToInt32(Console.ReadLine()), d = 0;
Goldbah(d)
Console.WriteLine($"Число {n} раскладывает по теории Гольдбаха на {i} и {d}");