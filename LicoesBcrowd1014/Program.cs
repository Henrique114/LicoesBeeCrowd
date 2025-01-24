namespace LicoesBcrowd1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcule o consumo médio de um automóvel sendo
            //fornecidos a distância total percorrida (em Km)
            //e o total de combustível gasto (em litros).

            var distanciaPercorrida  =  Int32.Parse(Console.ReadLine());    
            var litrosGastos = float.Parse(Console.ReadLine());

            var consumo = distanciaPercorrida/litrosGastos;

            Console.WriteLine($"{consumo:F3} km/l.");

        }
    }
}
