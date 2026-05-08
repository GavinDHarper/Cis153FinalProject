using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    internal class Play
    {
        private int row;
        private int col;
        private int turnNum;

        //--------------------------------------
        //          Setters
        //--------------------------------------
        public void setRow(int r)
        {
            row = r;
        }
        public void setCol(int c)
        {
            col = c;
        }
        public void setTurnNum(int t)
        {
            turnNum = t;
        }
        //--------------------------------------
        //          Getters
        //--------------------------------------
        public int getRow()
        {
            return row;
        }
        public int getCol()
        {
            return col;
        }
        public int getTurnNum()
        {
            return turnNum;
        }
        //--------------------------------------
        //          Constructors
        //--------------------------------------
        public Play()
        {
        }
        public Play(int r, int c, int t)
        {
            row = r;
            col = c;
            turnNum = t;
        }
    }
}
