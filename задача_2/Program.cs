//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
///y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine ("Ведите точку пересечения прямой с осью Y b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Ведите значение коэффициента k1 :");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Ведите точку пересечения прямой с осью Y b2 :");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Ведите значение коэффициента k2 :");
double k2 = Convert.ToInt32(Console.ReadLine());
Junction ( b1, k1,  b2, k2);

void Junction (double b1, double k1, double b2, double k2)
{ 
     double y;
     double x;
     if (k1!=k2 || k1!=k2 && b1!=b2 )
      {
          //y = k1 * x + b1;
           x = (b2 - b1) / (k1 - k2);
           y = k2 * x + b2;
           Console.WriteLine($"Точка пересечения двух прямых:({x};{y})");
      }
       else 
      {
           Console.WriteLine("Прямые параллельны или совпадают ");
      }
          
}

