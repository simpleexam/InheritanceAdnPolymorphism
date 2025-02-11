using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle : GeometricObject
    {
        private double _radius;
        public double Radius => _radius;
        public double GetArea => _radius * _radius * Math.PI;
        public double GerPerimetr => _radius * Math.PI  * 2;
        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            _radius = radius;
        }

        public Circle(double radius)
        {   
            _radius = radius;
        }
        public Circle()
        {
            _radius = 1;
        }
        
        public void SetRadius(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("недопустимое значение радиуса");
            _radius = radius;
        }

        public override void PrintGeometricObject()
        {
            //TODO печать текущего объекта окружности
        }
    }
}
