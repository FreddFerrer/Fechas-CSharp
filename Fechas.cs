using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechasApp
{
    internal class Fechas
    {
        int count = 0;

        DateTime fecha1 = new DateTime();
        DateTime fecha2 = new DateTime();

        public Fechas(DateTime fecha1, DateTime fecha2)
        {
            this.fecha1 = fecha1;
            this.fecha2 = fecha2;

        }


        public void ObtenerDiasCalendario(DateTime fecha1, DateTime fecha2)
        {
            try
            {
                Console.WriteLine("Ingrese la fecha 1 con el siguiente formato: dd/mm/yyyy ");
                fecha1 = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Ingrese la fecha 2 con el siguiente formato: dd/mm/yyyy ");
                fecha2 = Convert.ToDateTime(Console.ReadLine());


                Console.WriteLine("Las fechas son: " + fecha1.ToLongDateString() + " y " + fecha2.ToLongDateString());
                TimeSpan diferenciaFechas = fecha2 - fecha1;
                int dias = diferenciaFechas.Days;
                if(dias < 0)
                {
                    dias = dias * (-1);
                    Console.WriteLine("La diferencia entre las dos fechas es de " + dias + " dias");
                } else
                {
                    Console.WriteLine("La diferencia entre las dos fechas es de " + dias + " dias");

                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("el dia es " + fecha1.DayOfWeek);

            Console.WriteLine("el dia es " + fecha2.DayOfWeek);

            ObtenerDiasLaborables(fecha1, fecha2); 
        }

        public void ObtenerDiasLaborables(DateTime fecha1, DateTime fecha2)
        {
            Console.WriteLine("el dia es " + fecha2.DayOfWeek);
            

            for(DateTime date1 = fecha1; date1 <= fecha2; date1 = date1.AddDays(1))
            {
                if(date1.DayOfWeek.ToString() == "Saturday" || date1.DayOfWeek.ToString() == "Sunday")
                {
                    count++;
                }
            }

            Console.WriteLine("los dias no laborables son " + count);

        }

    }
}
