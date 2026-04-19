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
        private Player player1;
        private Player player2;

        public Cell[,] board; //objects not varables
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
        public void setPlayer1(Player p)
        {
            this.player1 = p;
        }
        public void setPlayer2(Player p)
        {
            this.player2 = p;
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
        public Player getPlayer1()
        {
            return player1;
        }
        public Player getPlayer2()
        {
            return player2;
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

        public void placePiece(int col, Player player)
         //'user' is to signify which user is placing the piece
         //doesn't have to be a char, coul be int 1 & 2
         //or char 'Y' & 'R' (yellow/red), anything works
        {
            for (int row = 0; row < 6; row++)
            {
                if (board[row, col].isOpen())
                    //if row at 0 of the chosen column is NOT open,
                    //increment by 1 and check the next space until one is open
                {
                    board[row, col].setCharacter((char)player.getId());
                    board[row, col].setChip(player.getChip());
                    return;
                }
            }
        }
        public void reverseBoard()
        //reverses board around so that it looks like how
        //it would look from the second players perspective
        {
            Cell[,] temp = new Cell[rows,cols];
            int k;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    temp[i,j] = board[i,j];
                }
            }
            for (int i = 0; i < rows; i++)
            {
                k = cols - 1;
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = temp[i,k];
                    k--;
                }
            }
        }
        public void displayBoardConsole()
        //displays the behind the scenes board looks in the console
        {
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(board[i, j].getCharacter());
                }
                Console.WriteLine();
            }
        }
    }
}
