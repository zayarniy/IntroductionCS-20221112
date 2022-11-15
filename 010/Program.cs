// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 
int n=Convert.ToInt32(Console.ReadLine());
for (n=n%10;n>=9;);
Console.WriteLine("Последняя цифра: " +n);