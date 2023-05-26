// Задайте одномерный массив, заполненный случайными числами (длина массива 5 элементов). Найдите сумму элементов, стоящих на нечётных индексах (индексы с нуля).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

 void FillArray(int[] array)
{
     for (int i = 0; i < array.Length;i++)
    {
        int random = new Random().Next(0,100) ;
        array[i] = random;
    }
}

void PrintArray(int[] array)
{
    for(int i = 0;i < array.Length;i ++)
    {
        Console.Write(array[i] + " ");
    }

}

int[] array1 = new int[5];

FillArray(array1);
PrintArray(array1);
int summ = 0;

for (int i = 0; i < array1.Length; i++)
{
    if (i % 2 == 1)
    {
        summ += array1[i];
    }
}
Console.WriteLine($"Сумма элементов массива с нечётными индксами = {summ}");