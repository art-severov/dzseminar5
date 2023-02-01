// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] GreatArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
int[] arr = GreatArrayRnd(5, 100, 1000);

int NumberofEven(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            result++;
    }return result;
}

int namberOfEven = NumberofEven(arr);

// int result = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if(arr[i] % 2 == 0)
//     result ++;
// }


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

PrintArray(arr);

Console.WriteLine("Количество четных чисел в массиве");

Console.Write($"-> " + namberOfEven);

