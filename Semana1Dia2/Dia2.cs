using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1Dia2
{
    internal class Dia2
    {
        static void Main(string[] args)
        {
            //ex01Idade();
            //ex02SomaDeNumeros();
            //ex03LetraMusica();
            //ex04Frase();
        }
        static void ex01Idade()
        {
            int anoNascimento, anoAtual, idade;
            Console.WriteLine("Digite seu ano de nascimento:");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu ano atual:");
            anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sua idade é: {anoAtual - anoNascimento}");

            Console.ReadLine();

        }
        static void ex02SomaDeNumeros()
        {
            int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;

            Console.WriteLine("Digite 10 números para somar:");

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            num5 = int.Parse(Console.ReadLine());
            num6 = int.Parse(Console.ReadLine());
            num7 = int.Parse(Console.ReadLine());
            num8 = int.Parse(Console.ReadLine());
            num9 = int.Parse(Console.ReadLine());
            num10 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma dos seus números é: {num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10}");
        }
    }  
}
