using EjercicioAbstraccion;


class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcular área de un triángulo");
            Console.WriteLine("2. Calcular área de un cuadrado");
            Console.WriteLine("3. Calcular volumen de un cilindro");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine();
            if (opcion == "4")
                break;

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                    var triangulo = new AreaTriangulo(baseTriangulo, alturaTriangulo);
                    triangulo.Calcular();
                    triangulo.Imprimir();
                    break;

                case "2":
                    Console.Write("Ingrese el lado del cuadrado: ");
                    double lado = Convert.ToDouble(Console.ReadLine());
                    var cuadrado = new AreaCuadrado(lado);
                    cuadrado.Calcular();
                    cuadrado.Imprimir();
                    break;

                case "3":
                    Console.Write("Ingrese el radio del cilindro: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del cilindro: ");
                    double alturaCilindro = Convert.ToDouble(Console.ReadLine());
                    var cilindro = new VolumenCilindro(radio, alturaCilindro);
                    cilindro.Calcular();
                    cilindro.Imprimir();
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }



    }
}


