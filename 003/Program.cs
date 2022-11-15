// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.
System.Console.WriteLine("Введите число a: ");
double a=Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите число b: ");
double b=Convert.ToDouble(System.Console.ReadLine());
if (a>b) System.Console.WriteLine($"{a}");
if (a<b) System.Console.WriteLine($"{b}");


