using System;

class Sla
{
    static void Main(string[] args)
    {
        Console.WriteLine("CALCULO DE SLA");

        Console.Write("Fecha de creacion (yyyy-MM-dd HH:mm): ");
        DateTime creacion = DateTime.Parse(Console.ReadLine());

        Console.Write("Fecha de resolucion (yyyy-MM-dd HH:mm): ");
        DateTime resolucion = DateTime.Parse(Console.ReadLine());

        string detalle = "";
        double horas = CalcularHorasLaborales(creacion, resolucion, ref detalle);

        if (horas < 8)
        {
            Console.WriteLine("Salida: Cumplido (Horas laborales: " + detalle + " = " + horas + "h).");
        }
        else
        {
            Console.WriteLine("Salida: Incumplido: " + (horas - 8) + " horas de mas");
            Console.WriteLine("Horas laborales: " + detalle + " = " + horas + "h");
        }
    }

    static double CalcularHorasLaborales(DateTime inicio, DateTime fin, ref string detalle)
    {
        double total = 0;
        DateTime dia = inicio.Date;

        while (dia <= fin.Date)
        {
            if (dia.DayOfWeek != DayOfWeek.Saturday &&
                dia.DayOfWeek != DayOfWeek.Sunday)
            {
                DateTime entrada = dia.AddHours(9);
                DateTime salida = dia.AddHours(17);

                if (inicio > entrada)
                {
                    entrada = inicio;
                }

                if (fin < salida)
                {
                    salida = fin;
                }

                if (salida > entrada)
                {
                    double horasDia = (salida - entrada).TotalHours;
                    total = total + horasDia;

                    if (detalle != "")
                    {
                        detalle = detalle + " + ";
                    }

                    detalle = detalle + horasDia + "h el " + NombreDia(dia);
                }
            }

            dia = dia.AddDays(1);
        }

        return total;
    }

    static string NombreDia(DateTime fecha)
    {
        if (fecha.DayOfWeek == DayOfWeek.Monday)
        {
            return "lunes";
        }
        else if (fecha.DayOfWeek == DayOfWeek.Tuesday)
        {
            return "martes";
        }
        else if (fecha.DayOfWeek == DayOfWeek.Wednesday)
        {
            return "miércoles";
        }
        else if (fecha.DayOfWeek == DayOfWeek.Thursday)
        {
            return "jueves";
        }
        else if (fecha.DayOfWeek == DayOfWeek.Friday)
        {
            return "viernes";
        }
        else if (fecha.DayOfWeek == DayOfWeek.Saturday)
        {
            return "sábado";
        }
        else
        {
            return "domingo";
        }
    }
}