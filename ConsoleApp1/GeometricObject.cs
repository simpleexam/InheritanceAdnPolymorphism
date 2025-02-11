using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class GeometricObject
    {
        private string _color;
        private bool _filled;
        private DateTime _createdTime;

        public string Color => _color;
        public DateTime CreatedTime => _createdTime;
        public bool Filled => _filled;
        public GeometricObject(string color, bool filled)
        {
            _color = color;
            _filled = filled;
            _createdTime = DateTime.Now;
        }
        public GeometricObject()
        {
            _color = "White";
            _filled = true;
            _createdTime = DateTime.Now;
        }

        public virtual void SetFilled() => _filled = true;

        public override string ToString()
        {
            return $"";
        }

        public abstract void PrintCircle();

    }
}
