using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    internal class Cell
    {
        private int row;
        private int col;
        private char character;
        private char openSpace;

        public PictureBox pictureBox; // object not var
        
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
        public void setCharacter(char c)
        {
            character = c;
        }
        public void setOpenSpace(char o)
        {
            openSpace = o;
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
        public char getCharacter()
        {
            return character;
        }
        public char getOpenSpace()
        {
            return openSpace;
        }
        //--------------------------------------
        //          Constructors
        //--------------------------------------
        public Cell()
        {
        }
        public Cell(int row, int col, char openSpace)
        {
            this.row = row;
            this.col = col;
            this.character = openSpace;
            this.openSpace = openSpace;
        }
        //--------------------------------------
        //          Functions
        //--------------------------------------
        public bool isOpen()
        {
            if (character == openSpace)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
