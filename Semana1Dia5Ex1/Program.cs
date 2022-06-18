namespace Semana1Dia5Ex1
{
    internal class Program
    {
        static void Main()
        {
            /*
            Console.WriteLine("Digite em ordem \no nome do aluno, \na matricula do aluno \na nota da primeira prova do aluno \na nota de trabalho do aluno?");

            var aluno1 = new Alunos(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            */

            Alunos aluno1 = new Alunos();

            Console.WriteLine("Qual o nome do aluno?");
            string nomeDoAluno = Console.ReadLine();

            Console.WriteLine("Qual o número da matrícula?");
            aluno1.Matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota da primeira prova do aluno?");
            aluno1.Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota da segunda prova do aluno?");
            aluno1.Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota de trabalho do aluno?");
            aluno1.Trabalho = double.Parse(Console.ReadLine());

            Console.WriteLine($"A matricula do aluno é: {aluno1.Matricula} \nA nota da primeira prova do aluno é: {aluno1.Nota1.ToString("F2")} \nA nota da segunda prova do aluno é: {aluno1.Nota2.ToString("F2")} \nA nota de trabalho do aluno é: {aluno1.Trabalho.ToString("F2")}");

            Console.WriteLine($"A Media final do aluno é {aluno1.MediaFinal().ToString("F2")}"); */

            aluno1.ProvaFinal();

            if (aluno1.ProvaFinal() >= 7)
            {
                Console.WriteLine("O Aluno já está aprovado");
            }
            else
            {
                double falta = (aluno1.MediaFinal() - 7) * -1;
                Console.WriteLine($"O Aluno precisa tirar {falta.ToString("F2")} para ser aprovado");
            }
        }
    }
}
