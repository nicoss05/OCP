namespace ConsoleApp.Refactorizacion
{
    internal class Rectangulo:IArea
    {
        public double Base { get; internal set; }
        public double Atura { get; internal set; }
        public double Area()
        {
            return this.Base * this.Atura;

        }
    }
}