//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
//k1*x+b1 = k2*x+b2.
//y = k1 * x + b1, y = k2 * x + b2,

Console.WriteLine("write line k1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("write line b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("write line k2");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine("write line b2");
int b2 = int.Parse(Console.ReadLine());
int y=0;
int x=0;
if(k1==k2) Console.WriteLine($" they don't have common points");
else
x = (b1-b2)/(k2-k1);
y = (k2*b1-k1*b2)/(k2-k1);
 Console.WriteLine($"Coordinates of the point of intersection of lines x-({x}) y-({y})");