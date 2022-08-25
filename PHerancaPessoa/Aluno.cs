using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHerancaPessoa
{
    internal class Aluno : Pessoa
    {
        int Registro;
        DateTime DataMat;

        public Aluno()
        {

        }
        public Aluno(string nome, DateTime dataDeNasc, string cpf, int registro, DateTime dataMat) : base(nome, dataDeNasc, cpf)
        {

            this.Registro = registro;
            this.DataMat = dataMat;
        }

        public void setRegistro()
        {
            Console.WriteLine("Digite o registro do aluno: ");
            this.Registro = int.Parse(Console.ReadLine());
        }

        public int getRegistro()
        {
            return Registro; 
        }

        public void setDataMat()
        {
            Console.WriteLine("Digite a data da matricula: ");
            this.DataMat = DateTime.Parse(Console.ReadLine());
        }

        public DateTime getDataMat()
        {
            return DataMat;
        }

        public override string ToString()
        {
            return "Nome: " + getNome() + "\nData de nascimento: " + getDatadeNasc() + "\nCpf: " + getCpf() +
            "\nRegistro: " + this.Registro + "\nData de matrícula: " + this.DataMat;
        }
    }

}





