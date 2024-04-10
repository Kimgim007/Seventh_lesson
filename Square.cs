using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Seventh_lesson
{
    public class Square
    {
        public Square() { }

        public Square(int Sidelength, string Color)
        {
            this.Sidelength = Sidelength;
            this.Color = Color;
            
        }

        public int Sidelength { get; set; }
        public string Color { get; set; }
        public int Area => CalculatesTheAreaOfAFigure();

        public override string ToString()
        {
            return $"{Sidelength} - Длина стороны, {Color} - Цвет, {Area} - Область";
        }

        private int CalculatesTheAreaOfAFigure()
        {
           
           
           return Sidelength * Sidelength;
        }

    }
}
