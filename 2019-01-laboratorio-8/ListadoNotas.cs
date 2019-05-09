using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_01_laboratorio_8
{
    class ListadoNotas
    {
        private List<double> notas;
        public VariacionPromedio onAumento;
        public VariacionPromedio onDisminucion;

        public ListadoNotas()
        {
            notas = new List<double>();
            onAumento = null;
            onDisminucion = null;
        }

        public void AgregarNota(double nota)
        {
            if (nota >= 1 && nota <= 7)
            {
                // Esto evita un error... Average sobre una lista vacía no funciona :)
                if (notas.Any())
                {
                    double promedioAntiguo = Promedio();
                    notas.Add(nota);
                    double promedioNuevo = Promedio();
                    if (promedioNuevo > promedioAntiguo)
                    {
                        onAumento(promedioAntiguo, promedioNuevo);
                    }
                    else if (promedioNuevo < promedioAntiguo)
                    {
                        onDisminucion(promedioAntiguo, promedioNuevo);
                    }
                }
                else
                {
                    notas.Add(nota);
                }
            }
        }

        public double Promedio()
        {
            return notas.Average(); // LINQ <3
        }
    }
}
