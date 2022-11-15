// 4. По заданному с клавиатуры номеру дня недели вывести его название
// Задаем массив [0, 1, 2, 3, 4, 5, 6]
int[] array = new int[6];
// Каждому индексу присваиваем значение
string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
System.Console.WriteLine("Введите число от 0 до 6: ");
int a=Convert.ToInt32 (System.Console.ReadLine());
Console.WriteLine(weekDays[a]);