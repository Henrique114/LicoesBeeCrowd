﻿using LicoesBeeCrowd.Algoritmos.Interfaces;

namespace LicoesBeeCrowd.Algoritmos.Desafios
{
    public class Algoritmo1023 : IBaseAlgoritmo
    {
        public void Executar()
        {
            // Transfornar a duração de tempo de segundos para o formato hh:mm:ss.

            //variavel que guarda o tempo em segundos.
            var tempoEmSegundos = int.Parse(Console.ReadLine());

            //formatação do tempo em hh:mm:ss com TimeSpan
            var tempoCompleto = TimeSpan.FromSeconds(tempoEmSegundos);

            //variavwl para horas.
            var horas = tempoCompleto.Hours;

            //variavwl para minutos.
            var minutos = tempoCompleto.Minutes;

            //variavwl para segundos.
            var segundos = tempoCompleto.Seconds;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");

        }
    }
}
