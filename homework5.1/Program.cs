// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами (длина массива 5 элементов). Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.WriteLine("Ввндите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// RandNumberArray(array);
// DecitionArray(array);
// PrintArray(array);


// Console.WriteLine("Введите число");
// string str = "234";
// int sum = 0;
// for (int i = 0; i < str.Length;i++)
// {
//     int number = int.Parse(str[i].ToString());
//     sum +=number;
// }
// Console.WriteLine(sum);

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
EnterFoo(array);
EvenFoo(array);
PrintFoo(array);

void EnterFoo(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int random = new Random().Next(100, 999);
        array[i] = random;
    }

}

void EvenFoo(int[] array,)
{
    
}


void PrintFoo(int[] array)
{
    for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");

}
Console.WriteLine();
}
