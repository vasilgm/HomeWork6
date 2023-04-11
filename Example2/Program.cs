// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double number (string i)
{
    System.Console.Write($"Введите {i}: ");
    double number = double.Parse(Console.ReadLine());
    return number;
}



double b1 = number ("коэффициент b1 первой прямой");
double k1 = number ("коэффициент k1 первой прямой");
double b2 = number ("коэффициент b2 второй прямой");
double k2 = number ("коэффициент k2 второй прямой");
System.Console.WriteLine($"Уравнение первой прямой - y = {k1}*x+{b1}");
System.Console.WriteLine($"Уравнение второй прямой - y = {k2}*x+{b2}");
double x = (b2-b1) / (k1-k2);
double y = k1*x+b1;
System.Console.WriteLine($"Точка пересечения двух прямых имеет координаты x={x}, y={y}");
