using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFigure
{

    internal class Program

    {
        static List<GeoFigure> listFigure = new List<GeoFigure>();
        static public List<GeoFigure> AddlistFigure(GeoFigure figure) //метод добавления фигур в список
        {
            listFigure.Add(figure);
            return listFigure;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Выберите фигуру, которую хотите создать:");
            Console.WriteLine("Четырехугольник - 1");
            Console.WriteLine("Треугольник - 2");
            Console.WriteLine("Круг - 3");
            
            int figure = 0;
            try
            {
                figure = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели не корректное значение");
                

            }

            if (figure == 1)
            {
                FourAngle fourAngle = new FourAngle("fourAngle");
                Console.WriteLine("Введите имя для четырехугольника:");
                fourAngle.SetName(Console.ReadLine());
                Console.WriteLine("Введите сторону а четырехугольника:");
                fourAngle.SetA(int.Parse(Console.ReadLine()));
                Console.WriteLine("Введите сторону b четырехугольника:");
                fourAngle.SetB(int.Parse(Console.ReadLine()));
                Console.WriteLine("Введите сторону c четырехугольника:");
                fourAngle.SetC(int.Parse(Console.ReadLine()));
                Console.WriteLine("Введите сторону d четырехугольника:");
                fourAngle.SetD(int.Parse(Console.ReadLine()));
                AddlistFigure(fourAngle);
                fourAngle.OutPutFigureToFile();

            }
            if (figure == 2)
            {
                Triangle triangle = new Triangle("triangle");
                Console.WriteLine("Введите имя для Треугольника:");
                triangle.SetName(Console.ReadLine());
                Console.WriteLine("Введите сторону а треугольника:");
                triangle.SetA(int.Parse(Console.ReadLine()));
                Console.WriteLine("Введите сторону b треугольника:");
                triangle.SetB(int.Parse(Console.ReadLine()));
                Console.WriteLine("Введите сторону c треугольника:");
                triangle.SetC(int.Parse(Console.ReadLine()));
                AddlistFigure(triangle);
                triangle.OutPutFigureToFile();
            }
            if (figure == 3)
            {
                Circle circle = new Circle("circle");
                Console.WriteLine("Введите имя для Круга:");
                circle.SetName(Console.ReadLine());
                Console.WriteLine("Введите диаметр круга:");
                circle.SetD(int.Parse(Console.ReadLine()));
                AddlistFigure(circle);
                circle.OutPutFigureToFile();
            }
            else
            { Console.WriteLine("Вы ввели не верное значение:"); }
 
        }
    }
    
}
