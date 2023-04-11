// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int number (string i)
{
    System.Console.Write($"Введите {i}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

void NewArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = number($"значение {i+1}");
    }
}

int count (int[] array)
{
    int x = 0;
    for (int i = 0; i <array.Length; i++)
    {
        if(array[i]>0) x++;
    }
    return x;
}

int[] array = new int [number("длинну массива")];
NewArray (array);
System.Console.Write("[ ");
printArray(array);
System.Console.Write("]");
System.Console.WriteLine();
System.Console.WriteLine($"Пользователь ввел {count (array)} чисел больше нуля");
