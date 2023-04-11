

int[] array = new int [count ("количество чисел Фибоначи > ")];
Fibonachi (array);
PrintFibonachi (array);


void Fibonachi (int[] array)
{
    array [0] = 0;
    array [1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
}

int count (string i)
{
    System.Console.Write($"Введите {i}");
    int count = int.Parse(Console.ReadLine());
    return count;
}

void PrintFibonachi (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}