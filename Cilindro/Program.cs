using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, raio, volume, superficie;
            float pi = 3.1415926;

            superficie = 2 * pi * raio *(raio + altura);
            volume = pi * raio * raio * altura;

            Console.WriteLine("Coloque a altura: ");

            altura = Console.ReadLine();

            Console.WriteLine("Coloque o raio: ");

            raio = Console.ReadLine();

            Console.WriteLine($"O volume é: {volume}");
            Console.WriteLine($"A área da superficie é: {superficie}");


        }
    }
}
