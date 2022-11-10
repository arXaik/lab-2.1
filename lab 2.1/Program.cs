//Петросян Араик 22-ИСП-2/1  вар 2,1
Console.WriteLine("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
double y = double.Parse(Console.ReadLine());
double part1 = (x * x + y * y);
double part2 = ((x - 2) * (x - 2) + y * y);
if (part1 <= 1*1 && part2 <= 2 * 2 ) Console.WriteLine("Принадлежит");
else Console.WriteLine("Не принадлежит");

