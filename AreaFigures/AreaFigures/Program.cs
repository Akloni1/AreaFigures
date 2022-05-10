// See https://aka.ms/new-console-template for more information
using AreaFigures;

IAreaFigures figure = null;
Console.WriteLine("Введите название фигуры:");
string figureName = Console.ReadLine();
if (figureName.ToLower() == "треугольник")
{
    try
    {
        Console.WriteLine("Введите первую сторону:");
        double firstSide = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите вторую сторону:");
        double secondSide = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите третью сторону:");
        double thirdSide = Convert.ToDouble(Console.ReadLine());
        figure = new Triangle(firstSide, secondSide, thirdSide);
    }
    catch (FormatException)
    {
        Console.WriteLine("ошибка конвертации");
        System.Diagnostics.Process.GetCurrentProcess().Kill();
    }

}
else if (figureName.ToLower() == "круг")
{
    try
    {
        Console.WriteLine("Введите радиус:");
        double radius = Convert.ToDouble(Console.ReadLine());
        figure = new Circle(radius);
    }
    catch (FormatException)
    {
        Console.WriteLine("ошибка конвертации");
        System.Diagnostics.Process.GetCurrentProcess().Kill();
    }
}
else
{
    Console.WriteLine("Данная фигура не может быть расчитана");
    System.Diagnostics.Process.GetCurrentProcess().Kill();
}

Console.WriteLine($"площадь= {figure.AreaFigure()}");


