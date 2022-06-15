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
            //ex1MultiplicaçãoDe5();
            //ex2NParesNImpares();
            //ex3Palavras();
            ex4Jokempo();          
        }
        static void ex1MultiplicaçãoDe5()
        {
            /*Crie um programa que solicite a entrada de 10 números pelo usuário, 
             *armazenando-os em um vetor, e então monte outro vetor com os valores do primeiro multiplicados por 5.
             *Exiba os valores dos dois vetores na tela, um em cada linha.*/

            Console.WriteLine("Digite para serem multiplicados por 5:");

            int[] nUsuarios, multiplicacao;
            nUsuarios = new int[10];
            multiplicacao = new int[10];
           
            for (int i = 0; i < 10; i++)
            {
                nUsuarios[i] = int.Parse(Console.ReadLine());
                
                for (int j = 0; j < nUsuarios.Length; j++)
                {
                    multiplicacao[j] = nUsuarios[j] * 5;
                }
            }

            Console.WriteLine("\n\n Números inseridos :{ " + String.Join(",", nUsuarios) + " } ");
            //String.Join identifica no array os elementos e printa

            foreach (int num in multiplicacao)
            {
                if (num >= 0) Console.Write(num + " ");
            }            
        }
        static void ex2NParesNImpares()
        {
            /* 2.Crie um programa que armazene 10 números digitados pelo usuário em dois vetores: 
             * um somente para números pares, e outro somente para números ímpares. 
             * Após, exiba os valores dos dois vetores na tela, um vetor em cada linha.*/

            Console.WriteLine($"Vamos separar rapidamente os números pares dos números impares? \ndigite 10 números:");

            int[] nPares, nImpares, nUsuarios;

            nUsuarios = new int[10];
            nPares = new int[10];
            nImpares = new int[10];

            for (int i = 0; i < nUsuarios.Length; i++)
            {
                nUsuarios[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < nUsuarios.Length; i++)
            {
                if (nUsuarios[i] % 2 == 0)
                {
                    nPares[i] = nUsuarios[i];
                }
                else
                {
                    nImpares[i] = nUsuarios[i];
                }
            }

            Console.WriteLine("Os números Pares que você digitou foram:");
            foreach (int num in nPares )
            {
	            if (num != 0) Console.Write(num + " ");                
            }

            Console.WriteLine("Os números Impares que você digitou foram:");
            foreach (int num in nImpares)
            {              
                if (num != 0) Console.Write(num + " ");
            }
        }            
        static void ex3Palavras()
        {


            /*3.Crie um programa que lê 5 palavras e as ordena em um vetor de strings pelo seu tamanho. 
             * Se o tamanho das strings for igual, deve - se manter a ordem inserida pelo usuário.*/

            string[] conjuntoPalavras, conjuntoPalavrasCrescente;
            
            conjuntoPalavras = new string[5];
            conjuntoPalavrasCrescente = new string[5];

            Console.WriteLine("Organize suas palavras por tamanho! \nDigite 5 palavras: \n");

            for (int i = 0; i < conjuntoPalavras.Length; i++)
            {               
                conjuntoPalavras[i] = Console.ReadLine();
            }

            Array.Sort(conjuntoPalavras, (x, y) => x.Length.CompareTo(y.Length));
            //tras em ordem alfabetica
            //.Length.CompareTo compara os dois em ordem de tamanho(Length)

            Console.WriteLine($"\n\n");

            foreach (string palavras in conjuntoPalavras)
            {
                Console.WriteLine($"{palavras}");
            }

        }
        static void ex4Jokempo()
        {
            /*
        Regras:
        [1]Pedra   ganha de [3]Tesoura
        [2]Papel   ganha de [1]Pedra
        [3]Tesoura ganha de [2]Papel
        */

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
                    Console.WriteLine("Você Empatou!");
                }
                else if (escolha == "tesoura" && computador == jokempo[0] || escolha == "pedra" && computador == jokempo[1] || escolha == "papel" && computador == jokempo[2])
                {
                    Console.WriteLine($"Você escolheu: {escolha}");
                    Console.WriteLine($"Seu oponente escolheu: {computador}");
                    Console.WriteLine("Você Perdeu!");
                }
                else 
                {
                    Console.WriteLine($"Você escolheu: {escolha}");
                    Console.WriteLine($"Seu oponente escolheu: {computador}");
                    Console.WriteLine("Você Ganhou!");

                    //if (escolha == "tesoura" && computador == jokempo[1] || escolha == "pedra" && computador == jokempo[2] || escolha == "papel" && computador == jokempo[0])
                }
            }

        }

           
    }
}
