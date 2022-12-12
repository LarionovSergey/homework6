// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Вводим сразу все числа в одну линию, не через бесконечное кол-во ReadLine.

Console.Write("Введите числа, используя пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = array.Count(x => x > 0);
Console.WriteLine($"Чисел больше 0: {count}");
