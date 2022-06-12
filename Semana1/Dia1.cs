using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1
{
    internal class Dia1
    {
        static void Main(string[] args)
        {
            //ex01Cadastro();
            //ex02Imprimir();
            //ex03LetraMusica();
            //ex04Frase();
        }
        static void ex01Cadastro()
        {
            string nome, endereço;
            int telefone, CEP;

            Console.WriteLine("Digite seu nome completo:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu endereço:");
            endereço = Console.ReadLine();
            Console.WriteLine("Digite seu CEP:");
            CEP = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu telefone:");
            telefone = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome completo é: {nome} \nSeu enereço é: {endereço} \nSeu CEP é: {CEP} \nSeu telefone é: {telefone}");

            Console.ReadLine();
        }

        static void ex02Imprimir() 
        {
            string nome, formação, contribuição;

            nome = "Ada Lovelace";
            formação = "Sem nenhuma";
            contribuição = "Criação do primeiro algoritmo da história em 1843";

            Console.WriteLine($"{nome}, {formação} formação, teve como uma de suas contribuições há tecnologia a {contribuição}");

            Console.ReadLine();
        }
        static void ex03LetraMusica()
        {
            string letra, compositor, genero;

            letra = $"I've got this feeling \nThat there's something that I missed \nI could do most anything to you \nDon't you breathe, don't you breathe \nI could do most anything to you \n Something happened \nThat I never understood \nI could do most anything to you \nYou can't leave, you can't leave \nI could do most anything to you" +
            $" Every second \nDripping off my fingertips \nI could do most anything to you \nWage your war, wage your war \nI could do most anything to you \n Another soldier \nSays hes not afraid to die \nI could do most anything to you \nI am scared, I'm so scared \nI could do most anything to you \nIn slow motion \n The blast is beautiful" +
            $" \nI could do most anything to you \nDoor slammed shut, Door slammed shut \nI could do most anything to you \nA clock is ticking \nBut it's hidden far away \nI could do most anything to you \nSafe and sound, safe and sound";
            compositor = "Snow Patrol";
            genero = "Rock alternativo";

            Console.WriteLine($"letra da música: {letra} \n\nCompositor: {compositor} \nGênero: {genero}");
            Console.ReadLine();
        }
        static void ex04Frase()
        {
            Console.WriteLine("E o mais bonito disso é que também é possível mudar o mundo escrevendo software 'Ana Paula Gomes'");

            Console.ReadLine();
        }
    }
}
