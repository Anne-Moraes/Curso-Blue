using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1Dia3
{
    internal class Dia3
    {
        static void Main(string[] args)
        {
            //ex01ContadorDeNotas();
            //ex02SomaDeNumeros();
            //ex03MediaDeNotas();
            //ex04NotaAmericana();
            //ex05AumentoSalarial();
        }
        static void ex01ContadorDeNotas()
        {

        }
        static void ex02ContadorDeNotas()
        {

        }
        static void ex03MediaDeNotas()
        {
            /* @"
            3.Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno. 
            Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal. 
            Imprima se o aluno foi aprovado ou reprovado considerando a média 7."
            */

            Console.WriteLine("Vamos saber sua nota final?");

            Console.WriteLine("Insira as 3 notas do semestre:");

            double nota1, nota2, nota3, notaFinal;

            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());

            notaFinal = (nota1 + nota2 + nota3) / 3;


            if (nota1 < 7)
            {
                Console.WriteLine($"Sua nota foi {notaFinal}, infelizmente você está de recuperação.");

            }
            else if (notaFinal > 7)
            {

                Console.WriteLine($"Sua nota foi {notaFinal}, parabéns você passou!");

            }
            else;
        }
        static void ex04NotaAmericana()
        {
            /* @"
            4.Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
            Se a nota for menor que 6.0, deve exibir a nota F.
            Se a nota for de 6.0 até 7.0, deve exibir a nota D.
            Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
            Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
            Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A.
            Não esqueça de adicionar uma mensagem após a nota, pode ser um simples parabéns para aprovação ou algo mais complexo."
            */

            Console.WriteLine("Vamos saber sua nota final?");

            Console.WriteLine("Insira as 3 notas do semestre:");

            double nota1, nota2, nota3, notaFinal;

            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());

            notaFinal = (nota1 + nota2 + nota3) / 3;


            if (nota1 < 6)
            {
                Console.WriteLine($"Sua nota foi F, infelizmente você está de recuperação.");

            }
            else if (notaFinal >= 6 && notaFinal < 7)
            {

                Console.WriteLine($"Sua nota foi D, parabéns você passou por pouco!");

            }
            else if (notaFinal >= 7 && notaFinal < 8)
            {

                Console.WriteLine($"Sua nota foi C, parabéns você na média! continue se esforçando.");

            }
            else if (notaFinal >= 8 && notaFinal < 9)
            {

                Console.WriteLine($"Sua nota foi B, parabéns você está acima da média! Continue se esforçando.");

            }
            else if (notaFinal >= 9 || notaFinal == 10)
            {

                Console.WriteLine($"Sua nota foi A, parabéns sua nota é excelente!");

            }
            else;

            Console.ReadLine();

        }
        static void ex05AumentoSalarial()
        {   /*
            @"A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
            Salário de 0 até 400.00 ganha 15% Salário de 400.01 até 800.00 ganha 12% Salário de 800.01 até 
            1200.00 ganha 10% Salário de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4%
            Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste 
            ganho e o índice reajustado, em percentual."
            */

            Console.WriteLine("Oba! Você recebeu um aumento, calcule seu novo salário!");

            Console.WriteLine("Insira o salário atual:");

            Double salario = double.Parse(Console.ReadLine());
            

            if (salario == 0 || salario <= 400.00)
            {
                double reajuste, novoSalario;
                reajuste = 0.15;
                novoSalario = salario * reajuste + salario;

                Console.WriteLine($"Seu salário é de: {salario} \nSeu novo salario é de: {novoSalario} \nSeu reajuste foi de: 15%");
                
            }
            else if (salario == 400.01 || salario <= 800.00)
            {
                double reajuste, novoSalario;
                reajuste = 0.12;
                novoSalario = salario * reajuste + salario;

                Console.WriteLine($"Seu salário é de: {salario} \nSeu novo salario é de: {novoSalario} \nSeu reajuste foi de: 12%");
            }
            else if (salario == 800.01 || salario <= 1200.00)
            {
                double reajuste, novoSalario;
                reajuste = 0.10;
                novoSalario = salario * reajuste + salario;

                Console.WriteLine($"Seu salário é de: {salario} \nSeu novo salario é de: {novoSalario} \nSeu reajuste foi de: 10%");
            }
            else if (salario == 1200.01 || salario <= 2000.00)
            {
                double reajuste, novoSalario;
                reajuste = 0.7;
                novoSalario = salario * reajuste + salario;

                Console.WriteLine($"Seu salário é de: {salario} \nSeu novo salario é de: {novoSalario} \nSeu reajuste foi de: 7%");
            }
            else if (salario == 2000.01 || salario > 2000.01)
            {
                double reajuste, novoSalario;
                reajuste = 0.4;
                novoSalario = salario * reajuste + salario;

                Console.WriteLine($"Seu salário é de: {salario} \nSeu novo salario é de: {novoSalario} \nSeu reajuste foi de: 4%");
            }
            else;

            Console.ReadLine();
        }
    }
}
