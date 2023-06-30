// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.

Console.Write("Введите количество элементов массива ");
int a = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[a];

void array(int a)
{
    for (int i = 0; i < a; i++)
    {
          randomArray[i] = new Random().Next(1,9);
     Console.Write(randomArray[i]+",");
    }
}

int quantity(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}

array(a);
Console.Write($" Сумма элементов, на нечётных индексах: {quantity(randomArray)}");