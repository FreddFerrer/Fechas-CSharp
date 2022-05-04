using System;

namespace FechasApp
{
    class Program
    {
        public static void Main(String[] args)
        {
            DateTime fecha1 = new DateTime();

            DateTime fecha2 = new DateTime();

            Fechas fechas = new Fechas(fecha1, fecha2);

            fechas.ObtenerDiasCalendario(fecha1, fecha2);

            


        }
    }
}