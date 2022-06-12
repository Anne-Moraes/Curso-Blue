using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Semana1Dia2
{
    internal class Dia2
    {
        static void Main(string[] args)
        {
            //ex01Idade();
            //ex02SomaDeNumeros();
            //ex3Salario();
            //ex04Idade();
            ex05Conversor();
        }
        static void ex01Idade()
        {
            int anoNascimento, anoAtual, idade;

            Console.WriteLine("Vamos calcular sua idade? Vamos começar.");

            Console.WriteLine("Digite seu ano de nascimento:");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atualmente vive:");
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
        static void ex3Salario()
        {

            int hrsTrabalhadas;
            Double valorHr, salario;

            Console.WriteLine("Digite o número total de horas trabalhadas:");
            hrsTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor recebido por hora:");
            valorHr = double.Parse(Console.ReadLine());

            salario = hrsTrabalhadas * valorHr;

            Console.WriteLine($"O número de horas trabalhadas foi: {hrsTrabalhadas} e o Salário é de: {salario.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
        static void ex04Idade()
        {
            //Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.

            int idade;

            Console.WriteLine("Vamos caucular sua idade em meses e dias? Vamos começar, digite a sua idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você tem 31 anos. Sua idade em meses é: {idade * 30} e a sua idade em dias é: {idade * 365}");

            Console.ReadLine();
        }
        static void ex05Conversor()
        {
            /*Crie um programa que solicite um um valor em real ao usuário e converta esse valor, para:
                DOLAR
                EURO
                LIBRA ESTERLINA
                DÓLAR CANADENSE
                PESO ARGENTINO
                PESO CHILENO
                Mostrar o resultado no formato símbolo da moeda e valor,
            */

            Console.WriteLine("Conversor de Moedas.");

            

            Double valor, cotaçãoDiaDolar, cotaçãoDiaEuro, cotaçãoDiaLibraEsterlina, cotaçãoDiaDolarCanadense, cotaçãoDiaPesoArgentino, cotaçãoDiaPesoChileno, dolar, euro, libraEsterlina, dolarCanadense, pesoArgentino, pesoChileno;
            
            Console.WriteLine("Digite um valor em Real Brasileiro para converter:");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Cotação do dia em Dolar:");
            cotaçãoDiaDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Cotação do dia em Euro:");
            cotaçãoDiaEuro = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Cotação do dia em Libra Esterlina:");
            cotaçãoDiaLibraEsterlina = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Cotação do dia em Dolar Canadense:");
            cotaçãoDiaDolarCanadense = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Cotação do dia em Peso Argentino:");
            cotaçãoDiaPesoArgentino = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Cotação do dia em Chileno:");
            cotaçãoDiaPesoChileno = double.Parse(Console.ReadLine());


            dolar = valor / cotaçãoDiaDolar;
            euro = valor / cotaçãoDiaEuro;
            libraEsterlina = valor / cotaçãoDiaLibraEsterlina;
            dolarCanadense = valor / cotaçãoDiaDolarCanadense;
            pesoArgentino = valor / cotaçãoDiaPesoArgentino;
            pesoChileno = valor / cotaçãoDiaPesoChileno;

            Console.WriteLine($"A conversão para dolar = US${dolar("F2", CultureInfo.InvariantCulture)} \nA conversão para euro = €{euro("F2", CultureInfo.InvariantCulture)} \nA conversão em libra esterlina = £{libraEsterlina("F2", CultureInfo.InvariantCulture)}  \nA conversão em dolar canadense = C${dolarCanadense("F2", CultureInfo.InvariantCulture)} \nA conversão em peso argentino = ${pesoArgentino("F2", CultureInfo.InvariantCulture)} \nA conversão em pesoChileno = ${pesoChileno("F2", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
