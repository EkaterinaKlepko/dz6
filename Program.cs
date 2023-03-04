// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите элементы(через пробел): ");
// double[] arr = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
// double count = 0;
 
// for (double i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Кол-во элементов > {count}");



// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void Cross (double b1, double k1, double b2, double k2)
// {   
//     double x = -(b1 - b2) / (k1 - k2);
//     double y = k1 * x + b1;
//     if((k1 * x + b1) - (k2 * x + b2) == 0)
//         Console.WriteLine($"Координаты точки пересечения: ({x},{y})");
//     else
//         Console.WriteLine("Прямые параллельны");
// }


// Console.WriteLine("Введите b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// Cross (b1, k1, b2, k2);
