using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1Dia4
{
    internal class Dia4
    {
        static void Main(string[] args)
        {
            //ex01ContadorDeNotas();
            //ex02ComparaçãoDeNumeros();
            //ex03MediaDeNotas();
            ex4Jokenpo();
        }
        
            static void ex4Jokenpo()
        {
            
            Console.WriteLine("Vamos jogar JOKEMPO?");
           
            

            Console.WriteLine("Quantas vezes você quer jogar?");
            int quantasVezes = int.Parse(Console.ReadLine());


            for (int i = 1; i <= quantasVezes; i++)
            {
                int posicao;
                string escolha, computador;

                Console.WriteLine("Escolha entre pedra, papel ou tesoura e boa sorte!");
                escolha = Console.ReadLine();

                string[] jokempo = new string[3];

                jokempo[0] = "pedra";
                jokempo[1] = "papel";
                jokempo[2] = "tesoura";

                Random r = new Random();

                posicao = r.Next(jokempo.Length);

                computador = jokempo[posicao];

                if (computador == escolha)
                {
                    Console.WriteLine($"Você escolheu: {escolha}");
                    Console.WriteLine($"Seu oponente escolheu: {computador}");
                    Console.WriteLine("Você Venceu!");
                }
                else if (computador != escolha)
                {
                    Console.WriteLine($"Você escolheu: {escolha}");
                    Console.WriteLine($"Seu oponente escolheu: {computador}");
                    Console.WriteLine("Você Perdeu!");
                }
                else;
            }

        }   
    }
}
