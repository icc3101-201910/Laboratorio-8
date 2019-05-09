using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_01_laboratorio_8
{
    class ObservadorNotas
    {
        public static void MostrarAumento(double promedioAntiguo, double promedioNuevo)
        {
            // Estoy usando aproximados para ser más exactos a la hora de decir si el usuario se salvó o no
            // no era necesario hacerlo :)
            double nuevoAproximado = Math.Round(promedioNuevo, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine($"\nExcelente! Tu promedio aumentó a {promedioNuevo} (aproximado {nuevoAproximado})");
            
            double antiguoAproximado = Math.Round(promedioAntiguo, 1, MidpointRounding.AwayFromZero);
            if (antiguoAproximado < 4 && nuevoAproximado >= 4)
            {
                Console.WriteLine("Te salvaste! Ahora estás sobre 4");
            }
        }

        public static void MostrarDisminucion(double promedioAntiguo, double promedioNuevo)
        {
            // Estoy usando aproximados para ser más exactos a la hora de decir si el usuario se salvó o no
            // no era necesario hacerlo :)
            double nuevoAproximado = Math.Round(promedioNuevo, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine($"\nBuuu! Bajaste el promedio a {promedioNuevo} (aproximado {nuevoAproximado})");

            double antiguoAproximado = Math.Round(promedioAntiguo, 1, MidpointRounding.AwayFromZero);
            if (antiguoAproximado >= 4 && nuevoAproximado < 4)
            {
                Console.WriteLine("Caracoles! Te estas echando el ramo!!");
            }
        }
    }
}
