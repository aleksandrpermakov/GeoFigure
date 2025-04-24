using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFigure
{

    internal class Program
    {
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
            }
            if (figure == 2)
            {
                Triangle triangle = new Triangle("triangle");
            }
            if (figure == 3)
            {
                Circle circle = new Circle("circle");

            }

            //List<FourAngle> fourAngles = new List<FourAngle>();
            //string filename = "Figures.txt";
            //string myDocs = FSWorker.myDocs;
            //for (int i = 0; i < 3; i++)
            //{
            //    var number = new Random((int)DateTime.Now.Ticks);
            //    var _figure = new FourAngle($"Фигура №{i + 1}",
            //        1 + number.Next(9),
            //        1 + number.Next(8) + (int)number.NextDouble(),
            //        1 + number.Next(9),
            //        1 + number.Next(9));
            //    fourAngles.Add(_figure);
            //    FSWorker.WriteStrToFile
            //        ($"{myDocs}\\{filename}", _figure.ToString());
            //}

            //Console.WriteLine($"Мои документы - {FSWorker.myDocs}");
            //foreach (string filename in FSWorker.ContentOfDir(FSWorker.myDocs))
            //{
            //    Console.WriteLine(filename);
            //}
            //Console.WriteLine($"Рабочий стол - {FSWorker.myDesktop}");
            //foreach (string filename in FSWorker.ContentOfDir(FSWorker.myDesktop))
            //{
            //    Console.WriteLine(filename);
            //}
        }
    }
    
}
