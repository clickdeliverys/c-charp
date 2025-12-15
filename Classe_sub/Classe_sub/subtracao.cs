using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_sub
{
    internal class subtracao
    {
        private int n1;
        private int n2;
        private int sub;

        public void setN1(int n1)
        {
            this.n1 = n1;
        }
        public void setN2(int n2)
        {
            this.n2 = n2;
        }
        public void setSub(int sub)
        {
            this.sub = sub;
        }
        public int getN1()
        {
            return this.n1;
        }
        public int getN2()
        {
            return this.n2;
        }
        public int getSub()
        {
            return this.sub;
        }
    }
}
