using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Calculadora
    {
        public double CalculadoraArea(object figura)
        {


            if (figura.GetType() == typeof(Triangulo))
            {
                var triangulo = (Triangulo)figura;
                return triangulo.Base * triangulo.Altura / 2;
            }
            else if (figura.GetType() == typeof(Cuadrado))
            {
                Cuadrado cuadrado = (Cuadrado)figura;
                return Math.Pow(cuadrado.Lado, 2);
            }
            else if (figura.GetType() == typeof(Circulo))
            {
                Circulo circulo = (Circulo)figura;
                return Math.PI * Math.Pow(circulo.Radio, 2);
            }
            throw new ArgumentException("Tipo de figura no implementada");
                }
        }
    }
    
   
