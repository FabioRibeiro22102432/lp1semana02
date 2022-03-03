using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, raio, volume, superficie;
            double pi = Math.PI;

            Console.WriteLine("Coloque a altura: ");

            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque o raio: ");

            raio = Convert.ToDouble(Console.ReadLine());

            superficie = 2 * pi * raio *(raio + altura);
            volume = pi * Math.Pow(raio,2) * altura;


            Console.WriteLine($"O volume é: {volume}");
            Console.WriteLine($"A área da superficie é: {superficie}");


        }
    }
}
