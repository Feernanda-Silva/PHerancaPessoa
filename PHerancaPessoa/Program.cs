using System;

namespace PHerancaPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Para Pessoa 1: 
            Console.Write("Nome: "); 
            String Nome = Console.ReadLine();
            Console.Write("\nData de nascimento: ");
            DateTime DatadeNasc= DateTime.Parse(Console.ReadLine());
            Console.Write("\nCpf: ");
            string Cpf = Console.ReadLine();

            Console.WriteLine();

            Pessoa pessoa1 = new Pessoa(Nome, DatadeNasc, Cpf);
            Console.WriteLine(pessoa1.ToString());

            Console.WriteLine();

            //Para Aluno: 
            Console.Write("Nome aluno: ");
            String Nome2 = Console.ReadLine();
            Console.Write("\nData de nascimento aluno: ");
            DateTime DatadeNasc2 = DateTime.Parse(Console.ReadLine());
            Console.Write("\nCpf aluno: ");
            string Cpf2 = Console.ReadLine();
            Console.Write("\nRegistro aluno: ");
            int Registro = int.Parse(Console.ReadLine());
            Console.Write("\nData de matricula aluno: ");
            DateTime dataMat= DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine();

            Aluno Aluno = new Aluno(Nome2,DatadeNasc2, Cpf2,Registro, dataMat);
            Console.WriteLine(Aluno.ToString());

            Console.WriteLine();

            //Para funcionário:
            Console.Write("Nome aluno: ");
            String Nome3 = Console.ReadLine();
            Console.Write("\nData de nascimento aluno: ");
            DateTime DatadeNasc3 = DateTime.Parse(Console.ReadLine());
            Console.Write("\nCpf aluno: ");
            string Cpf3 = Console.ReadLine();
            Console.Write("\nRegistro aluno: ");
            int Registro2 = int.Parse(Console.ReadLine());
            Console.Write("\nData de matricula aluno: ");
            DateTime dataMat2 = DateTime.Parse(Console.ReadLine());
            Console.Write("\nNumero do Pis: ");
            String Numero_Pis= Console.ReadLine();
            Console.Write("\nSalario: ");
            float Salario = float.Parse(Console.ReadLine());
            Console.WriteLine("\nSetor: ");
            String Setor= Console.ReadLine();

            Console.WriteLine();

            Funcionarios Funcionario = new Funcionarios(Nome3, DatadeNasc3, Cpf3, Registro2, 
            dataMat2, Numero_Pis,Salario, Setor);
            Console.WriteLine(Funcionario.ToString());

        }
    }
}
