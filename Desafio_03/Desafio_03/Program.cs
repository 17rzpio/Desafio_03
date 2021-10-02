using System;

namespace Desafio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeCadastro; // primeiro passo é declarar variáveis
            double maiorNota=0;
            string alunoMaiorNota="";

            Console.WriteLine("Digite quantos alunos quer cadastrar: "); // Perguntar quantos cadastros
            quantidadeCadastro = int.Parse(Console.ReadLine()); // armazenar a informação

            string[] nome = new string[quantidadeCadastro]; //criar arrays para comparar maior valor de nota
            double[] nota = new double[quantidadeCadastro];

            for(int count=0;count<quantidadeCadastro;count++)//estrutura de repetição para atribuir todos valores
            {
                Console.WriteLine("Insira nome do aluno numero "+(count + 1).ToString()+" : ");
                nome[count] = Console.ReadLine();//o indice do vetor vai mudando conforme incrementar contador do laço for
                Console.WriteLine("Insira a nota do aluno "+nome[count]+" : ");
                nota[count] = double.Parse(Console.ReadLine());
            }

            for(int count=0;count<quantidadeCadastro;count++)//estrutura de repetição para descobrir maior nota
            {
                if (nota[count] > maiorNota)//compara para ver se é maior nota
                {
                    maiorNota = nota[count];//se for maior nota salvará nessa variavel maiorNota
                    alunoMaiorNota = nome[count];//o indice corresponderá na outra variável indexada e será salvo na variável alunoMaiorNota
                }
            }

            Console.WriteLine("O aluno com maior nota foi: "+ alunoMaiorNota +" e sua nota maior eh: "+maiorNota.ToString());//imprime aluno com sua nota maior
        }
    }
}
