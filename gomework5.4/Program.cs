// Доп. задачи
// Задача 3: Задайте массив из 8 случайных чисел из промежутка [-9, 9]. Напишите программу получает на вход число и определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да
void FillArray(int[] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        int random = new Random().Next(-9,9);
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

Console.Write("Введите число для определения: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[size];
FillArray(array1);
PrintArray(array1);
int number1 = 0;
for(int i = 0;i < array1.Length;i++)
{
    if(array1[i] == number)
    {
        number++;
    }
}
if (number1 > 0)
{
    Console.Write("Введенное число определено: ");
}
else
{
    Console.WriteLine("Введённое число не присутсвует в массиве");
}
