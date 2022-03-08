using System;

namespace tipoDeTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lado1, lado2, lado3;
            Console.WriteLine("Informe o valor do primeiro lado do triângulo: ");
            lado1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do segundo lado do triângulo: ");
            lado2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do terceiro lado do triângulo: ");
            lado3 = float.Parse(Console.ReadLine());
            if ((lado1 == lado2) & (lado2 == lado3))
            {
                Console.WriteLine("O triângulo é equilátero");
            } else
            {
                if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3)) {
                    Console.WriteLine("O triângulo é isóceles");
                } else
                {
                    Console.WriteLine("O triângulo é escaleno");
                }
            }

        }
    }
}
