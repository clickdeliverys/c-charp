using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    internal class Aluno : Pessoa    
    {
        private int registro;
        private string curso;

        public void setRegistro(int registro)
        {
            this.registro = registro;
        }
        public void setCurso(string curso)
        {
            this.curso = curso;
        }
        public int getRegistro()
        {
            return this.registro;
        }
        public string getCurso()
        {
            return this.curso;
        }
    }
}
