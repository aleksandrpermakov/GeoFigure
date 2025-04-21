using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFigure
{
    internal abstract class GeoFigure
    {
        private string name;

        public string Name
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
        public abstract float GetPerimetr();
    }
    public class FourAngle : GeoFigure
    {
        float a;
        float b;
        float c;
        float d;
        public FourAngle(string name, float a = 1, float b = 1,
            float c = 1, float d = 1) : base(name)
        {
            this.a = a; this.b = b;
            this.c = c; this.d = d;
        }
        public override float GetPerimetr()
        {
            return a + b + c + d;
        }
        public override string ToString()
        {
            return $"{Name} сторона a = {a}, сторона b = {b}, " +
                $"сторона c = {c}, сторона d = {d}. Периметр = {this.GetPerimetr()}";
        }
    }
}

