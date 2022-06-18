
namespace Semana1Dia5Ex1
{
    public class Alunos
    {
        /*@"
        Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. 
        Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 2 notas de prova e 1 nota de trabalho. 
        Escreva os seguintes métodos para esta classe:
            Calcular média: calcula e exibe a média final do aluno com base em suas notas;
            Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado."*/

        //Atributos
        public string Nome;
        public int Matricula;
        public double Nota1;
        public double Nota2;
        public double Trabalho;

        //Construtor
        /*public Alunos(string nome, int matricula, double nota1, double nota2, double trabalho)
        {
            Nome = nome;
            Matricula = matricula;
            Nota1 = nota1;
            Nota2 = nota2;
            Trabalho = trabalho;
        }*/


        //Metodos
        public double MediaFinal()
        {
            double media = (Nota1 + Nota2 + Trabalho) / 3;

            return media;
        }

        public double ProvaFinal()
        {
            double prova = (MediaFinal() - 10) * -1;

            return prova;
        }
    }
}
