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
            //ex4Jokempo();
            ex5JogoDaVelha();

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

            //Cria os vetores;
            int[] nPares, nImpares, nUsuarios;

            //Determina o número de elementos do vetor;
            nUsuarios = new int[10];
            nPares = new int[10];
            nImpares = new int[10];

            //Preenche o vetor, com as informações dadas pelo úsuario.
            for (int i = 0; i < nUsuarios.Length; i++)
            {
                nUsuarios[i] = int.Parse(Console.ReadLine());
            }

            //Separa os valores pelo resultado do resto;
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
            foreach (int num in nPares)
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

                string[,] tabuleiro = new string[3, 3];

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
        static void ex5JogoDaVelha()
        {
            Console.WriteLine("Vamos jogar Jogo da velha?");
            Console.WriteLine("Ganhe do Computador em até6 jogadas");

            int p1, p2, p3, p4, p5, p6, p7, p8, p9, jogador1, jogador2, jogadorP1, jogadorP2;

            jogador1 = int.Parse(Console.ReadLine());
            jogador2 = int.Parse(Console.ReadLine());

            jogadorP1 = int.Parse(Console.ReadLine());
            jogadorP2 = int.Parse(Console.ReadLine());

            int[] bola, x;
            bola = new int[2];
            x = new int[2];


            int[,] tabuleiro = new int[3, 3];

            p1 = tabuleiro[0, 0];
            p2 = tabuleiro[0, 1];
            p3 = tabuleiro[0, 2];
            p4 = tabuleiro[1, 0];
            p5 = tabuleiro[1, 1];
            p6 = tabuleiro[1, 2];
            p7 = tabuleiro[2, 0];
            p8 = tabuleiro[2, 1];
            p9 = tabuleiro[2, 2];


            for (int j = 0; j <= 9; j++)
            { 

                if (jogador1 == 1 || jogador2 == 1)
                {
                    jogador1 = bola[0];
                    jogador2 = bola[1];
                }
                else if (jogador1 == 2 || jogador2 == 2)
                {
                    jogador1 = x[0];
                    jogador2 = x[1];
                }
                else
                {
                    Console.WriteLine("Você digitou errado");
                }
            }
        for (int j = 0; j <= 9; j++) {  

            if (bola[1] == p1 && bola[1] == p2 && bola[1] == p3 || bola[1] == p4 && bola[1] == p5 && bola[1] == p6 || bola[1] == p7 && bola[1] == p8 && bola[1] == p9)
                {
                    Console.WriteLine("Jogador 1 Ganhou!");
                }
                else if (bola[2] == p1 && bola[2] == p2 && bola[2] == p3 || bola[2] == p4 && bola[2] == p5 && bola[2] == p6 || bola[2] == p7 && bola[2] == p8 && bola[2] == p9)

                {
                    Console.WriteLine("Jogador 1 Ganhou!");
                }

            }


            /* for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 6; j++)

                        if (jogador1 == 1 || jogador2 == 1)
                    {
                        jogador1 = bola[0];
                        jogador2 = bola[1];
                    }
                    else if (jogador1 == 2 || jogador2 == 2)
                    {
                        jogador1 = x[0];
                        jogador2 = x[1];
                    }
                    else
                    {
                        Console.WriteLine("Você digitou errado");
                    }
                while (i < 6) 
                {
                    p1 == tabuleiro[i] == jogadorP1 == 1
                }
            }*/

            /*for (int j = 0; j <= 6; j++)
                {
                if (bola[1] == p1 && bola[1] == p2 && bola[1] == p3 || bola[1] == p4 && bola[1] == p5 && bola[1] == p6 || bola[1] == p7 && bola[1] == p8 && bola[1] == p9)
                {
                    Console.WriteLine("Jogador 1 Ganhou!");
                }
                    else if (bola[2] == p1 && bola[2] == p2 && bola[2] == p3 || bola[2] == p4 && bola[2] == p5 && bola[2] == p6 || bola[2] == p7 && bola[2] == p8 && bola[2] == p9)
               
                    {
                        Console.WriteLine("Jogador 1 Ganhou!");
                    } 
                }*/

                 /* string[,] matriz = new string[3, 3];
                 string turno = "X";

                 List<string> indexNumeros = new List<string> { };

                 int index = 1;

                 int tentativas = 1;

                 Console.WriteLine("oxoxoxoxoxoxoxoxoxo");
                 Console.WriteLine("   JOGO DA VELHA   ");
                 Console.WriteLine("xoxoxoxoxoxoxoxoxox");

                 // Alimentando a Matriz.
                 for (int i = 0; i < matriz.GetLength(0); i++)
                 {
                     for (int j = 0; j < matriz.GetLength(1); j++)
                     {
                         matriz[i, j] = index.ToString();
                         indexNumeros.Add(index.ToString());
                         index++;
                     }
                 }

                 // Imprimir a matriz.
                 for (int i = 0; i < matriz.GetLength(0); i++)
                 {
                     for (int j = 0; j < matriz.GetLength(1); j++)
                     {
                         Console.Write($" [{matriz[i, j]}] ");
                     }
                     Console.WriteLine();
                 }

                 Console.Write($"\nVocê quer jogar [{turno}] em qual posição? ");
                 string jogada = Console.ReadLine();

                 Console.Clear();

                 // Começa o jogo.
                 while (tentativas < 9)
                 {
                     Console.WriteLine("xoxoxoxoxoxoxoxoxox");
                     Console.WriteLine("   JOGO DA VELHA   ");
                     Console.WriteLine("oxoxoxoxoxoxoxoxoxo");


                     // Substituir o valor na sua respectiva casa.
                     for (int i = 0; i < matriz.GetLength(0); i++)
                     {
                         for (int j = 0; j < matriz.GetLength(1); j++)
                         {
                             if (matriz[i, j] == jogada && indexNumeros.Contains(jogada))
                             {
                                 matriz[i, j] = turno;
                                 indexNumeros.Remove(jogada);
                             }
                         }
                     }

                     // Imprimir a matriz.
                     for (int i = 0; i < matriz.GetLength(0); i++)
                     {
                         for (int j = 0; j < matriz.GetLength(1); j++)
                         {
                             Console.Write($" [{matriz[i, j]}] ");
                         }
                         Console.WriteLine();
                     }

                     // Condição de vitória nas Diagonais.
                     if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||
                         matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                     {

                         Console.WriteLine("\n--------------");
                         Console.WriteLine("Fim de Jogo!!!");
                         Console.WriteLine("--------------");
                         Console.WriteLine($"\nParabéns!!! O ganhador é [{turno}].");
                         break;
                     }
                     // Condição de vitória nas Linhas.
                     if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] ||
                         matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
                         matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
                     {
                         Console.WriteLine("\n--------------");
                         Console.WriteLine("Fim de Jogo!!!");
                         Console.WriteLine("--------------");
                         Console.WriteLine($"\nParabéns!!! O ganhador é [{turno}].");
                         break;
                     }
                     // Condição de vitória nas Colunas.
                     if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
                         matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
                         matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])
                     {

                         Console.WriteLine("\n--------------");
                         Console.WriteLine("Fim de Jogo!!!");
                         Console.WriteLine("--------------");
                         Console.WriteLine($"\nParabéns!!! O ganhador é [{turno}].");
                         break;
                     }

                     if (turno == "X")
                     {
                         turno = "O";
                     }
                     else
                     {
                         turno = "X";
                     }

                     var dataAt = DateTime.Now;
                     Console.WriteLine();
                     Console.WriteLine(dataAt);


                     Console.WriteLine();
                     Console.Write($"Você quer jogar [{turno}] em qual posição? ");
                     jogada = Console.ReadLine();


                     while (!indexNumeros.Contains(jogada))
                     {

                         Console.WriteLine();
                         Console.Write("Sua jogada foi invalida! Por favor, tente novamente: ");
                         jogada = Console.ReadLine();
                     }

                     tentativas++;

                     Console.Clear();
                 }

                 if (tentativas == 9)
                 {
                     Console.WriteLine("-------------------");
                     Console.WriteLine("   JOGO DA VELHA   ");
                     Console.WriteLine("-------------------");

                     for (int i = 0; i < matriz.GetLength(0); i++)
                     {
                         for (int j = 0; j < matriz.GetLength(1); j++)
                         {
                             Console.Write($" [{matriz[i, j]}] ");
                         }
                         Console.WriteLine();
                     }

                     Console.WriteLine("\n--------------");
                     Console.WriteLine("Fim de Jogo!!!");
                     Console.WriteLine("--------------");
                     Console.WriteLine($"\nQue triste!!! Ninguém ganhou.");
                 }

                 Console.ReadLine();
             }*/
        }
    }
}

