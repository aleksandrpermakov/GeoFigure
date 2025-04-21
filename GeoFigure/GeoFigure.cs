using System;
using System.Collections.Generic;
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
            //set { name = value; }
        }
        public GeoFigure(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
        public abstract int GetPerimetr();
        public abstract void OutPutFigureToFile();
    }
    public class FourAngle : GeoFigure
    {
        int a;
        int b;
        int c;
        int d;
        
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
       
        public override int GetPerimetr()
        {
            return a + b + c + d;
        }
        public override string ToString()
        {
            return $"{GetName} сторона a = {a}, сторона b = {b}, " +
                $"сторона c = {c}, сторона d = {d}. Периметр = {this.GetPerimetr()}";
        }
        public override void  OutPutFigureToFile()
        {
            this.ToString();//заглушка
        }

    }
}

