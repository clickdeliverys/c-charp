using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
    internal class Funcionario
    {
        private int matricula;
        private string nome;
        public Funcionario()
        {
            matricula = 00;
            nome = "Nome";
        }
        public Funcionario(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public int getMatricula()
        {
            return this.matricula;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void ImprimeValores()
        {
            Console.WriteLine("Nome Funcionário: " + nome);
            Console.WriteLine("Matricula funcionário: " + matricula);
        }
        ~Funcionario()
        {
            //Método Destrutor
        }
    }
}
