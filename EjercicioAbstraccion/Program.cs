using EjercicioAbstraccion;


class Program
{
    static void Main(string[] args)
    {
        
                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                    var triangulo = new AreaTriangulo(baseTriangulo, alturaTriangulo);
                    triangulo.Calcular();
                    triangulo.Imprimir();

                     Console.WriteLine();


                    Console.Write("Ingrese el lado del cuadrado: ");
                    double lado = Convert.ToDouble(Console.ReadLine());
                    var cuadrado = new AreaCuadrado(lado);
                    cuadrado.Calcular();
                    cuadrado.Imprimir();

                     Console.WriteLine();

                    Console.Write("Ingrese el radio del cilindro: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del cilindro: ");
                    double alturaCilindro = Convert.ToDouble(Console.ReadLine());
                    var cilindro = new VolumenCilindro(radio, alturaCilindro);
                    cilindro.Calcular();
                    cilindro.Imprimir();



    }
}


