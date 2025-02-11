using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle : GeometricObject
    {
        private double _width;
        private double _height;

        public double Width => _width;
        public double Height => _height;
        public double GetArea => _width * _height;
        public double GetPreimetr => 2 * (Width + Height);

        public Rectangle()
        {
            _width = 1;
            _height = 1;
        }
        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }
        public Rectangle(double width, double height, string color, bool filled)
            :base(color, filled)
        {
            _width = width;
            _height = height;
        }

        public void SetHeight(double h)
        {
            if (h > 0)
                _height = h;
            else
                throw new ArgumentException("некорректное значение высоты");
        }
        public void SetWidth(double w)
        {
            if (w > 0)
                _width = w;
            else
                throw new ArgumentException("некорректное значение ширины");
        }

        public override void PrintCircle()
        {
            //TODO реализовать печать текущего объекта прямоугольника
        }
    }
}
