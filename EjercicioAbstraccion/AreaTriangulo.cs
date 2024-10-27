

namespace EjercicioAbstraccion
{
    public class AreaTriangulo : FormulaMatematica
    {
        private double baseTriangulo;
        private double altura;
        public double Area { get; private set; }


        public AreaTriangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }


        public override void Calcular()
        {
            Area= (baseTriangulo * altura) / 2;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El area del triangulo es:  {Area} centimetros");
        }
    }
}
