using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    internal class Bot
    {
        public Board tempBoard = new Board();

        public void play(Board board)
        {
            int imediatePlayNum = imediatePlayCheck(board);
            tempBoard = board;
            
            if (imediatePlayNum != -1) //if a play is nessicery then play peice
            {
                board.placePiece(imediatePlayNum, board.getPlayer2());
                return;
            }

            if (board.board[4, 0].isOpen()) // the middle is the best play at the start
            {
                board.placePiece(4, board.getPlayer2());
                return;
            }

            for(int j = 0; j < 2; j++) //checks if groups of 3 can be created then groups of 2
            {
                int check3sInt = checkNum(board, 3 - j);
                if (check3sInt != -1)
                {
                    board.placePiece(check3sInt, board.getPlayer2());
                    return;
                }
            }
            //if those dont retrun then it places at random
            board.placePiece(randomLocation(board), board.getPlayer2());


        }
        int imediatePlayCheck(Board board)
        {
            for (int i = 0; i < 7; i++)
            { // checks win first
                tempBoard = board;
                tempBoard.placePiece(i, tempBoard.getPlayer2());
                //board.displayBoardConsole(); testing purposes
                if (tempBoard.checkWin(tempBoard.getPlayer2().getId()))
                {
                    return i;
                }
            }
            for (int i = 0; i < 7; i++)
            { // if win is not posible in turn then it checks for a block 
                tempBoard = board;
                tempBoard.placePiece(i, board.getPlayer1());
                if (tempBoard.checkWin(tempBoard.getPlayer1().getId()))
                {
                    return i;
                }
            }
            return -1; //if neither then it returns -1 meaning no exact play is nessicery
        }

        //bellow is the same logic as win check but for finding groupings of 3
        int checkNum(Board board, int num)
        {
            for (int i = 0; i < 7; i++)
            {
                tempBoard = board;
                tempBoard.placePiece(i, board.getPlayer2());
                int row = 0;

                for (int j = 0; j < 6; j++)
                {
                    if (!board.board[i, j].isOpen())
                    {
                        break;
                    }
                    else
                        row = j;
                }

                if (checkNumInCol(tempBoard, i, board.getPlayer2().getId(), num))
                    return i;
                if (checkNumInDiag(tempBoard, tempBoard.getPlayer2().getId(), num))
                    return i;
                if (checkNumInRow(tempBoard, row, tempBoard.getPlayer2().getId(), num))
                    return i;
            }
            for (int i = 0; i < 7; i++)
            {
                tempBoard = board;
                tempBoard.placePiece((int)i, board.getPlayer1());
                int row = 0;

                for (int j = 0; j < 6; j++)
                {
                    if (!board.board[i, j].isOpen())
                    {
                        break;
                    }
                    else
                        row = j;
                }

                if (checkNumInCol(tempBoard, i, board.getPlayer1().getId(), num))
                    return i;
                if (checkNumInDiag(tempBoard, tempBoard.getPlayer1().getId(), num))
                    return i;
                if (checkNumInRow(tempBoard, row, tempBoard.getPlayer1().getId(), num))
                    return i;
            }

            return -1;
        }
        bool checkNumInCol(Board board, int col, int playerId, int num)
        {
            int chipCount = 0;
            if (playerId == board.getPlayer1().getId())
            {
                for (int i = 0; i < board.getRows(); i++)
                {
                    if (board.board[i, col].getChip() == board.getPlayer1().getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= num)
                    {
                        return true;
                    }
                }
            }
            else if (playerId == board.getPlayer2().getId())
            {
                for (int i = 0; i < board.getRows(); i++)
                {
                    if (board.board[i, col].getChip() == board.getPlayer2().getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool checkNumInDiag(Board board, int playerId, int num)
        {
            int chipCount;
            Player player;
            bool found3 = false;
            if (playerId == board.getPlayer1().getId())
            {
                player = board.getPlayer1();
            }
            else
            {
                player = board.getPlayer2();
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <= (board.getRows() - 4); j++)
                {
                    chipCount = 0;
                    for (int k = 0; k < (board.getRows() - j); k++)
                    {
                        if ((board.board[j + k, k].getChip() == player.getChip()))
                        {
                            chipCount++;
                        }
                        else
                        {
                            chipCount = 0;
                        }
                        if (chipCount >= num)
                        {
                            found3 = true;
                        }
                    }
                }
                for (int j = 1; j <= (board.getCols() - 4); j++)
                {
                    chipCount = 0;
                    for (int k = 0; k < (board.getCols() - j); k++)
                    {
                        if ((board.board[k, j + k].getChip() == player.getChip()))
                        {
                            chipCount++;
                        }
                        else
                        {
                            chipCount = 0;
                        }
                        if (chipCount >= num)
                        {
                            found3 = true;
                        }
                    }
                }
                //reverseBoard(); //code that was taken over that I dont know is nessicery
            }
            if (found3)
            {
                return true;
            }
            return false;
        }
        bool checkNumInRow(Board board, int r, int playerId, int num)
        {
            int chipCount = 0;
            if (playerId == board.getPlayer1().getId())
            {
                for (int i = 0; i < board.getCols(); i++)
                {
                    if (board.board[r, i].getChip() == board.getPlayer1().getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= num)
                    {
                        return true;
                    }
                }
            }
            else if (playerId == board.getPlayer2().getId())
            {
                for (int i = 0; i < board.getCols(); i++)
                {
                    if (board.board[r, i].getChip() == board.getPlayer2().getChip())
                    {
                        chipCount++;
                    }
                    else
                    {
                        chipCount = 0;
                    }
                    if (chipCount >= num)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //random placement

        int randomLocation(Board board)
        {
            Random rnd = new Random();
            List<int> aviableSpaces = new List<int>();
            int amount = 0;
            for (int i = 0;i < board.getCols();i++)
            {
                if (board.board[i,5].isOpen())
                {
                    aviableSpaces.Add(i);
                    amount++;
                }
            }
            
            return aviableSpaces.ElementAt(rnd.Next(0, amount));
            
        }
    }
    

}