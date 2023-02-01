// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}
double[] array = CreateArrayRndDouble(5, 0, 10);





// double FindMinMax(double[] array)
// {
    double min = array[0];
    double max = array[0];
    // double diff = 0;
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[0] < min) min = min[i];
            if (array[0] > max) max = max[i];
           
        }
    }

Console.WriteLine($"Минимальное значение:{min}");
Console.WriteLine($"Максимальное значение:{max}");
double diff = max - min;
Console.WriteLine($"Разница между самым большим и самым маленьким значением:{diff}");
Console.ReadLine();


void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

PrintArrayDouble(array);

//         return diff;
     
// }

// double findMinMax = FindMinMax(min, max);



// double DiffMinMax(double minr, double maxr)

// {
//     double result = Math.Round(maxr - minr);

//     return result;
// }

// double result = DiffMinMax(max, min);







PrintArrayDouble(array);

// double min = FindMin(array);
// double max = FindMax(array);








