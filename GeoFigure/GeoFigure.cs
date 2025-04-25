using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFigure
{
    public abstract class GeoFigure
    {
        private string name;

        public string GetName
        {
            get { return name; }
           
        }
        public void SetName(string name) { this.name = name; }
        public GeoFigure(string name = "figure")
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
        public abstract double GetPerimetr();//периметр
        public abstract void OutPutFigureToFile(); //запись фигуры в фаил
        public abstract double GetArea(); //площадь
    }
    public class FourAngle : GeoFigure //четырехугольник
    {
        int a;
        int b;
        int c;
        int d;
        string name;

        public int GetA() { return a; }
        public int GetB() { return b; }
        public int GetC() { return c; }
        public int GetD() { return d; }

        public void SetA (int a) { this.a = a; }
        public void SetB (int b ) { this.b = b; }
        public void SetC(int c) { this.c = c; }
        public void SetD(int d) { this.d = d; }
        
        public FourAngle(string name, int a = 1, int b = 1,
            int c = 1, int d = 1) : base(name)
        {
            List<int> sides = new List<int>() { a, b, c, d };
            int maxSide = sides.Max();
            if (maxSide > sides.Sum() - maxSide) //если максимальная сторона больше чем сумма остальных сторон
            {
                Console.WriteLine("Вы задали не корректные стороны четырехугольника!");
            }
            else
            {
                this.a = a; this.b = b;
                this.c = c; this.d = d;

            }

        }
       // public void SetName(string name) { this.name = name; }
        public override double GetPerimetr()
        {
            return a + b + c + d;
        }
        public override string ToString()
        {
            return $"{GetName} сторона a = {a}, сторона b = {b}, " +
                $"сторона c = {c}, сторона d = {d}. Периметр = {this.GetPerimetr()}";
        }
        public override double GetArea()
        {
            Console.WriteLine("Плащадь верна, при условии , что это квадрат или прямоугольник!");
            return this.a * this.b; 
        }
        public override void OutPutFigureToFile()
        {
            string path = "figure.txt";
            string content = this.ToString();
            System.IO.StreamWriter sr = new StreamWriter(path,  true);
            sr.Write(content);
            sr.Close();         
        }

    }
    public class Triangle : GeoFigure //треугольник
    {
        int a;
        int b;
        int c;

        public int GetA() { return a; }
        public int GetB() { return b; }
        public int GetC() { return c; }
        public void SetA(int a) { this.a = a; }
        public void SetB(int b) { this.b = b; }
        public void SetC(int c) { this.c = c; }
        public Triangle(string name, int a = 1, int b = 1,
            int c = 1) : base(name)
        {
            List<int> sides = new List<int>() { a, b, c };
            int maxSide = sides.Max();
            if (maxSide > sides.Sum() - maxSide) //если максимальная сторона больше чем сумма остальных сторон
            {
                Console.WriteLine("Вы задали не корректные стороны треугольника!");
            }
            sides.Sort(); //сортировка по возрастанию
            sides.Reverse(); // меняем расположение элементов на обратное (по убыванию)

            if (maxSide < (sides[1] - sides[2]))
            {
                Console.WriteLine("Вы задали не корректные стороны треугольника!");
            }
            else
            {
                this.a = a; this.b = b; this.c = c;
            }

        }
        public override double GetPerimetr()
        {
            return a + b + c;
        }
        public override string ToString()
        {
            return $"{GetName} сторона a = {a}, сторона b = {b}, " +
                $"сторона c = {c}. Периметр = {this.GetPerimetr()} , Площадь = {this.GetArea()}";
        }
        public override double GetArea()
        {
            double area = 0;
            double p_ = this.GetPerimetr() / 2; //полупериметр
            area = Math.Sqrt((p_ * (p_ - this.a) * (p_ - this.b) * (p_ - this.c)));
            return area;
        }
        public override void OutPutFigureToFile()
        {
            string path = "figure.txt";
            string content = this.ToString();
            System.IO.StreamWriter sr = new StreamWriter(path, true);
            sr.Write(content);
            sr.Close();
        }

    }
    public class Circle : GeoFigure //круг
    {
        int d; //диаметр
        public Circle(string name, int d = 1) : base(name)
        { this.d = d; }

        public int GetD() { return d; }
        public void SetD(int d) { this.d = d; }
        public override double GetPerimetr()
        {

            return this.d * Math.PI;
        }
        public override double GetArea()
        { 
            return  Math.PI * (this.d / 2) * (this.d / 2); //2Pr^2
        }
        public override string ToString()
        {
            return $"{GetName} диаметр = {d}, Периметр = {this.GetPerimetr()}, Площадь = {this.GetArea()} ";
        }
        public override void OutPutFigureToFile()
        {
            string path = "figure.txt";
            string content = this.ToString();
            System.IO.StreamWriter sr = new StreamWriter(path, true);
            sr.Write(content);
            sr.Close();
        }
    }
}

