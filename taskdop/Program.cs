// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку.

// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] SortArray(int[] arr)
{
int temp = 0;
for (int i = 0; i < arr.Length; i++)
 {
    for (int j = 0; j < arr.Length - 1; j++) 
    {
        if (arr[j] < arr[j + 1]) 
        {
            temp = arr[j + 1];
            arr[j + 1] = arr[j];
            arr[j] = temp;
        }
    }
}
    return arr;
}

Console.Clear();

int[] first = GetArray(7,-10,20);
Console.WriteLine(String.Join(" ", first));
int[] sortFirst = SortArray(first);
Console.WriteLine(String.Join(" ", sortFirst));