using ConsoleApp.Refactorizacion;
using System;

namespace ConsoleApp.Refactorizacion
{
    internal class Cilindro : IArea
    {
        public double Altura { get; internal set; }
        public double Radio { get; internal set; }

        public double Area()
        {
            return (2 * Math.PI * this.Radio * (this.Radio + this.Altura));
        }
    }
}
