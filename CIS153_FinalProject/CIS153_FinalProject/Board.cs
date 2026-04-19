using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        public Board(int rows, int cols, char openSpace, Player player1, Player player2)
        {
            this.rows = rows;
            this.cols = cols;
            this.openSpace = openSpace;
            this.player1 = player1;
            this.player2 = player2;
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
        public bool checkWinRow(int row, int playerId)
        {
            //Checks for a win in the specified row when given a player id
            int chipCount = 0;
            if (playerId == player1.getId())
            {
                for (int i = 0; i < cols; i++)
                {
                    if (board[row, i].getChip() == player1.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
            }
            else if (playerId == player2.getId())
            {
                for (int i = 0; i < cols; i++)
                {
                    if (board[row, i].getChip() == player2.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool checkWinCol(int col, int playerId)
        {
            //Checks for a win in the specified col when given a player id
            int chipCount = 0;
            if (playerId == player1.getId())
            {
                for (int i = 0; i < rows; i++)
                {
                    if (board[i, col].getChip() == player1.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
            }
            else if (playerId == player2.getId())
            {
                for (int i = 0; i < rows; i++)
                {
                    if (board[i, col].getChip() == player2.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool checkWinDiagonal(int playerId)
        {
            int chipCount = 0;
            //============================================
            //Player 1 win conditions
            //============================================
            //---------------------------------
            //4 length diagonal win conditions
            //---------------------------------
            if (playerId == player1.getId())
            {
                //diagonal win condition from cell 2,0 to 5,3
                for (int i = 0; i < 4; i++)
                {
                    if (board[(2 + i), (i)].getChip() == player1.getChip())
                    {
                        chipCount++;
                    }
                    else 
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
                //diagonal win condition from cell 0,3 - 3,6
                for (int i = 0; i < 4; i++)
                {
                    if (board[(i), (3 + i)].getChip() == player1.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
                //---------------------------------
                //5 length diagonal win conditions
                //---------------------------------
                //diagonal win condition from cell 1,0 to 5,4
                for (int i = 0; i < 5; i++)
                {
                    if (board[(1 + i), (i)].getChip() == player1.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
                //diagonal win condition from cell 0,2 to 4,6
                for (int i = 0; i < 5; i++)
                {
                    if (board[(i), (2 + i)].getChip() == player1.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
                //---------------------------------
                //6 length diagonal win conditions
                //---------------------------------
                //diagonal win condition from cell 0,0 to 5,5
                for (int i = 0; i < 6; i++)
                {
                    if (board[(i), (i)].getChip() == player1.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
                //diagonal win condition from cell 0,1 to 5,6
                for (int i = 0; i < 6; i++)
                {
                    if (board[(i), (1 + i)].getChip() == player1.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
            }
            //============================================
            //Player 2 win conditions
            //============================================
            if (playerId == player2.getId())
            {
                //diagonal win condition from cell 2,0 to 5,3
                for (int i = 0; i < 4; i++)
                {
                    if (board[(2 + i), (i)].getChip() == player2.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
                //diagonal win condition from cell 0,3 - 3,6
                for (int i = 0; i < 4; i++)
                {
                    if (board[(i), (3 + i)].getChip() == player2.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
                //---------------------------------
                //5 length diagonal win conditions
                //---------------------------------
                //diagonal win condition from cell 1,0 to 5,4
                for (int i = 0; i < 5; i++)
                {
                    if (board[(1 + i), (i)].getChip() == player2.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
                //diagonal win condition from cell 0,2 to 4,6
                for (int i = 0; i < 5; i++)
                {
                    if (board[(i), (2 + i)].getChip() == player2.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
                //---------------------------------
                //6 length diagonal win conditions
                //---------------------------------
                //diagonal win condition from cell 0,0 to 5,5
                for (int i = 0; i < 6; i++)
                {
                    if (board[(i), (i)].getChip() == player2.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
                //diagonal win condition from cell 0,1 to 5,6
                for (int i = 0; i < 6; i++)
                {
                    if (board[(i), (1 + i)].getChip() == player2.getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= 4)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool checkWin(int playerId)
        {
            for (int i = 0; i < 6; i++)
            {
                if (checkWinRow(i, playerId))
                {
                    return true;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                if (checkWinCol(i, playerId))
                {
                    return true;
                }
            }
            if (checkWinDiagonal(playerId))
            {
                return true;
            }
            reverseBoard();
            if (checkWinDiagonal(playerId))
            {
                reverseBoard();
                return true;
            }
            reverseBoard();
            return false;
        }

        public bool checkDirection(int row, int col, int dRow, int dCol, Chip chip)
        {
            //this function calls in one direction only, it'll need to be called more than once
            //to check everything

            //we know there's at least one chip, so start at 1 not 0
            int count = 1;

            //dRow and dCol are like instructions.
            //(0, 1) to move one cell right
            //(1, 0) to move one cell down
            //(assuming top left cell is (0,0)
            int r = row + dRow;
            int c = col + dCol;

            //first bit makes sure we stay within the board's confines by not going past rows or cols
            //second bit checks if there's a chip, if the spot is empty, stop checking
            //las bit checks if they're the same color, I opted to check like this since we don't
            //really keep track of the chips any other way
            while (r >= 0 && r < rows && c >= 0 && c < cols && board[r, c].getChip() != null && board[r, c].getChip().getColor() == chip.getColor())
            {
                count++;
                if (count == 4)
                {
                    return true;
                }
                else
                { 
                    r += dRow;
                    c += dCol;
                }
            }
            return false;
        }
    }
}
