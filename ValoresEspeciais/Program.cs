using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            int variavel1 = int.MaxValue;
            short variavel2 = short.MaxValue;
            byte variavel3 = byte.MaxValue;
            double variavel4 = double.NaN;
            float variavel5 = float.PositiveInfinity;
            float variavel6;

            variavel1++;
            variavel2++;
            variavel3++;
            variavel6 = variavel5;



            Console.WriteLine(variavel1);
            Console.WriteLine(variavel2);
            Console.WriteLine(variavel3);
            Console.WriteLine(variavel4);
            Console.WriteLine(variavel5);
            Console.WriteLine(variavel5 == variavel6 + 0.0001);


        }
    }
}
