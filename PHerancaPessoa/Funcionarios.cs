using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHerancaPessoa
{
    internal class Funcionarios : Aluno
    {
        String Numero_Pis;
        float Salario;
        String Setor;

        public Funcionarios(string nome, DateTime dataDeNasc, string cpf, int registro, DateTime dataMat, string numero_pis, float salario, string setor)
            : base(nome, dataDeNasc, cpf, registro, dataMat)
        {
            this.Numero_Pis = numero_pis;
            this.Salario = salario;
            this.Setor = setor;
        }

        public void setNumero_Pis()
        {
            Console.WriteLine("Escreva o numero do pis: ");
            this.Numero_Pis = Console.ReadLine();
        }

        public String getNumero_Pis()
        {
            return Numero_Pis;
        }

        public void setSalario()
        {
            Console.WriteLine("Escreva o salario: ");
            this.Salario = float.Parse(Console.ReadLine());
        }

        public float getsalario()
        {
            return Salario;

        }

        public void setSetor ()
        {
            Console.WriteLine("Escreva o setor: ");
            this.Setor = Console.ReadLine(); 
        }


        public override string ToString()
        {
            return "Nome: " + getNome() + "\nData de nascimento: " + getDatadeNasc() + "\nCpf: " + getCpf() +
            "\nRegistro: " + getRegistro() + "\nData de matrícula: " + getDataMat() +"\nNumero Pis: "+this.Numero_Pis+
            "\nSalario: "+ this.Salario + "\nSetor: "+ this.Setor;
        }
    }
}
