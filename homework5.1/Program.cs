// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами (длина массива 5 элементов). Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[5];



void EnterFoo(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        int random = new Random().Next(100, 999);
        array[i] = random;
    }

}


void PrintFoo(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }

}
Console.WriteLine("Введите длину массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[size1];
EnterFoo(array);
PrintFoo(array);
int evenNumber = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        evenNumber++;
    }
}
Console.Write($"Количество чётных элементов в данном массиве = {evenNumber} ");
