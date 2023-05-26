// Задача 4: Задайте массив из 10 случайных чисел из промежутка [-100, 100]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2] -> 0

// [10, 11, 12, 13, 14] -> 5
void FillArray(int[] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        int random = new Random().Next(-100,100);
        array[i] = random;
    }
}

void PrintArray(int[] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int [size];
FillArray(array1);
PrintArray(array1);
int number1 = 0;
Console.WriteLine();
for(int i = 0; i < array1.Length;i++)
{
    if(array1[i] >=10 && array1[i] <= 99)
    {
        number1++;
    }
}
Console.Write($"количество элементов массива, значения которых лежат в отрезке [10,99]. {number1}");