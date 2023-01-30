// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите с.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i <= array.Length - 1; i+=2)
    {
            sum += array[i];
    }
    return sum;
}

Console.Clear();

int[] NewArray = GetArray(5, 0, 10);
Console.WriteLine(String.Join(" ", NewArray));
int result = SumElements(NewArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {result}");
