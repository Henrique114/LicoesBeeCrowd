using LicoesBeeCrowd.Algoritmos.Interfaces;

namespace LicoesBeeCrowd.Algoritmos.Desafios
{
    public class Algoritmo1014 : IBaseAlgoritmo
    {
        public void Executar()
        {
            var distanciaPercorrida = int.Parse(Console.ReadLine());
            var litrosGastos = float.Parse(Console.ReadLine());

            var consumo = distanciaPercorrida / litrosGastos;

            Console.WriteLine($"{consumo:F3} km/l.");
        }
    }
}
