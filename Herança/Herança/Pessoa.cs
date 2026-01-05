using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private string sexo;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }
        public string getNome()
        {
            return this.nome;
        }
        public int getIdade()
        {
            return this.idade;
        }
        public string getSexo()
        {
            return this.sexo;
        }
    }
}
