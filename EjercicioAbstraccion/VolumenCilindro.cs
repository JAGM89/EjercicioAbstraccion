

namespace EjercicioAbstraccion
{
    internal class VolumenCilindro : FormulaMatematica
    {

        private double radio;
        private double altura;
        public double Volumen { get; private set; }

        public VolumenCilindro(double radio, double altura)
        {
            this.radio = radio;
            this.altura = altura;
        }

        public override void Calcular()
        {
            Volumen = Math.PI * Math.Pow(radio, 2) * altura;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El volumen del cilindro es:  {Volumen} Metros cubicos");
        }
    }
}
