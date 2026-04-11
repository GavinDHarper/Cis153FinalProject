using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    internal class Board
    {
        private int rows;
        private int cols;
        private char openSpace;
        private Cell[,] board;
        //--------------------------------------
        //          Setters
        //--------------------------------------
        public void setRows(int r)
        {
            rows = r;
        }
        public void setCols(int c)
        {
            cols = c;
        }
        //--------------------------------------
        //          Getters
        //--------------------------------------
        public int getRows()
        {
            return rows;
        }
        public int getCols()
        {
            return cols;
        }
        //--------------------------------------
        //          Constructors
        //--------------------------------------
        public Board()
        {
        }
        public Board(int rows, int cols, char openSpace)
        {
            this.rows = rows;
            this.cols = cols;
            this.openSpace = openSpace;
            board = new Cell[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = new Cell(i, j, openSpace);
                }
            }
        }
        //--------------------------------------
        //          Functions
        //--------------------------------------
    }
}
