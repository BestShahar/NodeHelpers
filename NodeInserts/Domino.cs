using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    public class Domino
    {
        private int firstnum;
        private int secnum;
        public Domino(int firstnum, int secnum)
        {
            this.firstnum = firstnum;
            this.secnum = secnum;
        }
        public int getFirstnum() { return firstnum; }
        public int getSecondnum() {  return secnum; }
        public void setFirstnum(int firstnum) {  this.firstnum = firstnum; }
        public void setSecondnum(int secnum) {  this.secnum = secnum; }

        public bool IsDomino(int num, Domino domino)
        {
            if(num==domino.firstnum) return true;
            if(num==domino.secnum) return true;
            return false;
        }
    }

}