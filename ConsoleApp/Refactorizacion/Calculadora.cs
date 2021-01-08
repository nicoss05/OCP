using System.Collections.Generic;

namespace ConsoleApp.Refactorizacion
{
    class Calculadora
    {
        public double CalculadoraArea(IArea figura)
        {
            return figura.Area();

        }
        public double CalcularAreaTotal(List<IArea> figuras)
        {
            double area = 0;
            for (int i = 0; i < figuras.Count; i++)
            {
                area += figuras[i].Area();
            }
            return area;
        }
    }
}
