// Задача 38: Задайте массив целых двухзначных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[a];

void el(int a)
{
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = rand.Next(9, 99);
        Console.Write($"{randomArray[i]+", "}");
    }
}

double diff(int[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if(max<randomArray[i])
        max = randomArray[i];
        if(min>randomArray[i])
        min = randomArray[i];
        i++;
    }
    return max-min;
}
el(a);
Console.Write($" Разница между максимальным и минимальным элементом массива: {diff(randomArray)}");