using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class Algoritmo1014 : IBaseAlgoritmo
    {
        public void Executar()
        {
            var distanciaPercorrida = Int32.Parse(Console.ReadLine());
            var litrosGastos = float.Parse(Console.ReadLine());

            var consumo = distanciaPercorrida / litrosGastos;

            Console.WriteLine($"{consumo:F3} km/l.");
        }
    }
}
