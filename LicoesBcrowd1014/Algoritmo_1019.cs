using System;

namespace Algoritmos
{

    public class Algoritmo_1019 : IBaseAlgoritmo
    {
        public void Executar()
        {
            // Transfornar a duração de tempo de segundos para o formato hh:mm:ss.

            //variavel que guarda o tempo em segundos.
            var tempoEmSegundos = int.TryParse(Console.ReadLine());

            //formatação do tempo em hh:mm:ss com TimeSpan
            var tempoCompleto = TimeSpan.FromSeconds(tempoEmSegundos);

            //variavwl para horas.
            var horas = tempoCompleto.Hours;

            //variavwl para minutos.
            var minutos = tempoCompleto.Munutes;

            //variavwl para segundos.
            var segundos = tempoCompleto.Seconds;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");



        }
    }
}