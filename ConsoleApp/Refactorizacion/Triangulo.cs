using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Refactorizacion
{
    internal class Triangulo:IArea
    {
        public int Base { get; internal set; }
        public int Altura { get; internal set; }
        public double Area()
        {
            return this.Base * this.Altura / 2;
        }

    }
}
