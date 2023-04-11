int count (string i)
{
    System.Console.Write($"Введите {i}");
    int count = int.Parse(Console.ReadLine());
    return count;
}

void RandomArrayy (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
}

int[] Copyarray (int[] array)
{
    int[] Copyarray = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        Copyarray[i] = array[i];
    }
    return Copyarray;
}

void PraintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]} ");
    }
}

int[] array = new int [count ("длинну массива > ")];
RandomArrayy(array);
PraintArray(array);
int[] Copyarrayy = Copyarray(array);
PraintArray(Copyarrayy);



