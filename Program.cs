using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {            
             /*
                quero que exiba a tabuada do numero digitado 
                5 X 1 = 5 
                5 X 2 = 10
                5 X 3 = 15             
             */

            // sequenciador 
            Console.WriteLine("Digite um numero");
            int numero = int.Parse(Console.ReadLine());

            for (int i = numero; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
