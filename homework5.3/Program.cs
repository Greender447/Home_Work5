// Задача 38: Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов). Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FillArray(int[] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        array[i] = new Random().Next(-100,100);
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
int size =  Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[size];
FillArray(array1);
PrintArray(array1);
int summ = 0;
int max = array1[0];
int min = array1[0];
for (int i = 0;i < array1.Length;i++)
{
    if(array1[i] > max)
    {
        max = array1[i];
    }

    if(array1[i] < min)
    {
        min = array1[i];
    }

}
Console.WriteLine();
summ = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {summ}");