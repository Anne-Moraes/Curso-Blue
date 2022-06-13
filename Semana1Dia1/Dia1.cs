using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //x01Cadastro();
            //ex02Pesquisa();
            //ex03Musica();
            //ex04Frase();
        }

        static void ex01Cadastro()
        {
            /*Elabore um programa que escreve seu nome completo, 
             seu endereço, o CEP e telefone em linhas separadas.*/


            Console.WriteLine("Insira seus Dados para realizar o cadatro:");

            string nome, endereço;
            int telefone, CEP;

            Console.WriteLine("Digite seu nome completo:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu endereço:");
            endereço = Console.ReadLine();

            Console.WriteLine("Digite os números do seu CEP:");
            CEP = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu número de telefone:");
            telefone = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome completo é: {nome} \nSeu enereço é: {endereço} \nSeu CEP é: {CEP} \nSeu telefone é: {telefone}");

            Console.ReadLine();
        }
        static void ex02Pesquisa()
        {
            /* Escolha uma mulher famosa na história da tecnologia e implemente um 
            programa que escreve seu nome, sua formação e uma contribuição feita por ela 
            dentro da tecnologia em linhas separadas. */


            Console.WriteLine("Você será apresentado a uma mulher incrível! Você tem interesse?");

            String resposta;
            resposta = Console.ReadLine();

            if (resposta == "S" || resposta == "s")
            {
                string nome, formação, contribuição;

                nome = "Ada Lovelace";
                formação = "Sem nenhuma";
                contribuição = "Criação do primeiro algoritmo da história em 1843";

                Console.WriteLine($"{nome} \n{formação} formação \nteve como uma de suas contribuições a tecnologia há {contribuição}.");

                Console.ReadLine();
            }
            else;
        }
        static void ex03Musica()
        {
            //Elabore um programa que mostre na tela uma letra de música que você gosta, o compositor e o gênero musical em linhas separadas.

            Console.WriteLine("Já conhece essa música?:");

            string letra;

            letra = @"
            
            Nome da Música: Up Down
            Nome do Cantor: Boy Epic
            Gênero = Rock alternativo

            I'll be stuck chasing time
            Running all my life
            Trying not to lose a fight
            Burning in my eyes
            In mad mad world
            I'm falling in
            Little lost to go
            Tryna start again
            Tick tock don't stop
            I'm breathing

            Harder that I see it's
            Up down
            Up down
            And barely breathing
            But I follow
            Follow you down
            And put my knees in
            Spinning
            Up down
            Up down
            Still fighting my demons
            But I follow
            Follow you down

            Through the glass I lose myself
            In the darkest deep
            Time is just a memory
            With its sun's on me

            It's a mad mad world
            I'm drowning in
            Does anybody know
            How to start again
            Tick tock don't stop
            I'm breathing

            Harder that I see it's
            Up down
            Up down
            And barely breathing
            But I follow
            Follow you down
            And put my knees in
            Spinning
            Up down
            Up down
            Still fighting my demons
            But I follow
            Follow you

            Falling
            Faster
            Than heart's beating
            Tick tock don't stop
            I'm still breathing

            Falling
            Faster
            Than heart's beat
            Tick tock don't stop
            I'm still breathing
            Yea, I'm still breathing

            Harder that I see it's
            Up down
            Up down
            And barely breathing
            But I follow
            Follow you down
            And put my knees in
            Spinning
            Up down
            Up down
            Still fighting my demons
            But I follow
            Follow you down

            But I follow
            Follow you down";



            Console.WriteLine(letra);

            Console.ReadLine();
        }
        static void ex04Frase()
        {
            //Elabore um programa que exibe uma mensagem que incentive outras mulheres a entrar na tecnologia.

            Console.WriteLine("Você é uma mulher interessada em Tecnologia? S/N?");
            
            String resposta;

            resposta = Console.ReadLine();

            if (resposta == "S" || resposta == "s")
            {
                Console.WriteLine("E o mais bonito disso é que também é possível mudar o mundo escrevendo software 'Ana Paula Gomes'");
            }
            else;
        }
    }
}


