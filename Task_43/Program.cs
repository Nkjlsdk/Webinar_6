// ввод значений b1, k1, b2 и k2 пользователем,
//найти точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 

Console.WriteLine("Введите значение b1");
double CoefficientB1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1");
double CoefficientK1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2");
double CoefficientB2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2");
double CoefficientK2 = Convert.ToDouble(Console.ReadLine());

double PointX = (CoefficientB2 - CoefficientB1)/(CoefficientK1 - CoefficientK2);
double PointY = CoefficientK1*PointX + CoefficientB1;

Console.WriteLine($"Точка пересечения 2-х прямых: {PointX};{PointY}");
