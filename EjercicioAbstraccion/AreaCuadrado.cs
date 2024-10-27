

namespace EjercicioAbstraccion
{
    public class AreaCuadrado : FormulaMatematica

    {

        private double lado;
        public double Area { get; private set; }

        public AreaCuadrado(double lado)
        {
            this.lado = lado;
        }

        public override void Calcular()
        {
            Area = lado * lado;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El área del cuadrado es: {Area}");
        }
    }
}
