using LicoesBeeCrowd.Algoritmos.Interfaces;

namespace LicoesBeeCrowd.Algoritmos.Desafios
{
    public class Algoritmo1014 : IBaseAlgoritmo
    {
        public void Executar()
        {
            int.TryParse(Console.ReadLine(), out int distanciaPercorrida);
            float.TryParse(Console.ReadLine(), out float litrosGastos);

            var consumo = distanciaPercorrida / litrosGastos;

            Console.WriteLine($"{consumo:F3} km/l.");
        }
    }
}
