using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Refactorizacion
{
    internal class Circulo:IArea
    {
        public double Radio { get; internal set; }
        public double Area()
        {
            return Math.PI*Math.Pow(this.Radio, 2);
        }
    }
}
