using System;

namespace Teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Clear();
                Console.WriteLine("Você precisa digitar um número.");
                Console.WriteLine("Digite um número: ");
            }

            int somaTotal = Contador.SomarMultiplosDe_3_e_5(numero);
            Console.WriteLine($"Soma dos múltiplos de 3 e 5 até o número {numero} é igual a {somaTotal}.");

            // Readline para o processo não finalizar instantaneamente assim que terminar de processar a soma dos múltiplos. Evitando o fechamento do console.
            Console.ReadLine();
        }
    }

    public class Contador
    {
        public static int SomarMultiplosDe_3_e_5(int limite)
        {
            int somaTotal = 0;

            for(int i = 0; i <= limite; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    somaTotal += i;
            }

            return somaTotal;
        }
    }
}
