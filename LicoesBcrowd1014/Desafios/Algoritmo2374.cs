using LicoesBeeCrowd.Algoritmos.Interfaces;

namespace LicoesBeeCrowd.Algoritmos.Desafios
{
    internal class Algoritmo2374 : IBaseAlgoritmo
    {
        public void Executar()
        {
            //Escreva um programa que, dada a pressão desejada digitada
            //pelo motorista e a pressão do pneu lida pela bomba, indica a
            //diferença entre a pressão desejada e a pressão lida.

            //variavel que recebera e guardara a pressao desejada pelo usuario.
            Console.WriteLine("Insira a pressão desejada:");//Apagar ou comentar para enviar para o BeeCrowd.
            int.TryParse(Console.ReadLine(), out int pressaoDesejada);

            // variavel que recebera e guardara a leitura da pressao contida no pneu.
            Console.WriteLine("Insira a pressão atual:");//Apagar ou comentar para enviar para o BeeCrowd.
            int.TryParse(Console.ReadLine(), out int leituraDaPressao);

            // Calculo para encontrar a diferença de pressao no pneu em relaçao da pressao desejada.
            var diferençaDePressao = pressaoDesejada - leituraDaPressao;

            Console.WriteLine(diferençaDePressao);
        }
    }
}
