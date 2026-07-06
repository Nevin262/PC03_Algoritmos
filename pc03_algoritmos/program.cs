using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("=================================");
            Console.WriteLine("        PC03 ALGORITMOS");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Validar comprobante electronico");
            Console.WriteLine("2. Calcular SLA");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opcion: ");

            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (opcion == 1)
            {
                ValidarComprobante.Ejecutar();
            }
            else if (opcion == 2)
            {
                Sla.Ejecutar();
            }
            else if (opcion == 0)
            {
                Console.WriteLine("Programa finalizado.");
            }
            else
            {
                Console.WriteLine("Opcion no valida.");
            }

            Console.WriteLine();

        } while (opcion != 0);
    }
}