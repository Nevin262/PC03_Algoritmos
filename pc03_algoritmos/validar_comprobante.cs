using System;

class ValidarComprobante
{
    public static void Ejecutar()
    {
        Console.WriteLine("VALIDAR COMPROBANTE ELECTRONICO");
        Console.Write("Ingrese comprobante: ");
        string numero = Console.ReadLine();

        if (ValidarComprobanteElectronico(numero))
        {
            Console.WriteLine("Comprobante valido");
        }
        else
        {
            Console.WriteLine("Comprobante invalido");
        }
    }

    static bool ValidarComprobanteElectronico(string numero)
    {
        if (numero == null || numero.Length != 13)
        {
            return false;
        }

        numero = numero.ToUpper();

        if (numero[4] != '-')
        {
            return false;
        }

        if (numero[0] != 'B' && numero[0] != 'F')
        {
            return false;
        }

        for (int i = 1; i <= 3; i++)
        {
            if (!char.IsDigit(numero[i]))
            {
                return false;
            }
        }

        for (int i = 5; i <= 12; i++)
        {
            if (!char.IsDigit(numero[i]))
            {
                return false;
            }
        }

        return true;
    }
}