using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHerancaPessoa
{
    internal class Pessoa
    {
        String Nome;
        DateTime DataDeNasc;
        String Cpf; 

        //metodo construtor 

        public Pessoa ()
        {

        }
        public Pessoa(string nome, DateTime dataDeNasc, string cpf)
        {
            this.Nome = nome;
            this.DataDeNasc = dataDeNasc;
            this.Cpf = cpf;
        }   

  
        public void setNome()
        {
            Console.WriteLine("Escreva seu nome: "); 
            this.Nome = Console.ReadLine();
        }

        public string getNome()
        {
            return Nome;
        }

        public void setDatadeNasc()
        {
            Console.WriteLine("Escreva a data: ");
            this.DataDeNasc = DateTime.Parse(Console.ReadLine()); 
        }

        public DateTime getDatadeNasc()
        {
            return DataDeNasc;
        }

        public void setCpf()
        {
            Console.WriteLine("Escreva o Cpf: ");
            this.Cpf= Console.ReadLine();   
        }

        public String getCpf()
        {
            return Cpf;
        }

        public override string ToString()
        {
            return "Nome: " + this.Nome + "\nData de nascimento: " + this.DataDeNasc + "\nCpf: " + this.Cpf;
        }
    }
}
