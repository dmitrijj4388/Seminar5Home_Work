// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] NewDoblArr(int size, int minValue, int maxValue)
{
     double[] res = new double[size];   
    for (int i = 0; i < size; i++)
    {
        double a = new Random().Next(minValue, maxValue + 1);
        res[i] = new Random().Next(0, 100);
        res[i] = res[i]/100 + a;
    }

    return res;
}

double maxElement(double[] arr)
{
   double maxElem = arr[0];
   for (int i = 1; i <= arr.Length - 1; i++)
   {
    if (arr[i] > maxElem) maxElem = arr[i];
   }
return maxElem;
}

double minElement(double[] arr)
{
   double minElem = arr[0];
   for (int i = 1; i <= arr.Length - 1; i++)
   {
    if (arr[i] < minElem) minElem = arr[i];
   }
return minElem;
}


Console.Clear();

double[] array = NewDoblArr(5,-50,12);
Console.WriteLine(String.Join(" ", array));
double a = maxElement(array);
double b = minElement(array);
double result = a - b;
Console.WriteLine($"Максимальный элемент - {a}");
Console.WriteLine($"Минимальный элемент - {b}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");