using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int variavel1 = int.MinValue;
            short variavel2 = short.MinValue;
            byte variavel3 = byte.MinValue;
            double variavel4 = double.NaN;
            float variavel5 = float.PositiveInfinity;

            Console.WriteLine(variavel1);
            Console.WriteLine(variavel2);
            Console.WriteLine(variavel3);
            Console.WriteLine(variavel4);
            Console.WriteLine(variavel5);


        }
    }
}
