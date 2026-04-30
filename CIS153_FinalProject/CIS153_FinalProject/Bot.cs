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

        public bool play(Board board)
        {
            int imediatePlayNum = imediatePlayCheck(board);
            tempBoard = (Board)board.Clone();
            bool played = false;
            Console.WriteLine("imediate Play");
            Console.WriteLine(board.getCols() + " " + board.getRows());
            if (imediatePlayNum != -1 && played == false) //if a play is nessicery then play peice
            {
                played = board.placePiece(imediatePlayNum, board.getPlayer2());
            }
            Console.WriteLine("mid Play");
            if (board.board[0, 3].isOpen() && played == false) // the middle is the best play at the start
            {
                played = board.placePiece(3, board.getPlayer2());
            }
            Console.WriteLine("check3s");
            for (int j = 0; j < 2; j++) //checks if groups of 3 can be created then groups of 2
            {
                int check3sInt = checkNum(board, 3 - j);
                Console.WriteLine("check3s returned " + check3sInt + " " + (3- j));
                if (check3sInt != -1 && played == false)
                {
                    played = board.placePiece(check3sInt, board.getPlayer2());
                }
            }
            Console.WriteLine("random");
            //if those dont retrun then it places at random
            if (!played)
            { 
                played = board.placePiece(randomLocation(board), board.getPlayer2());
            }
            return played;
        }
        int imediatePlayCheck(Board board)
        {
            for (int i = 0; i < 7; i++)
            { // checks win first
                tempBoard = (Board)board.Clone();
                tempBoard.placePiece(i, tempBoard.getPlayer2());
                //board.displayBoardConsole(); testing purposes
                if (tempBoard.checkWin(tempBoard.getPlayer2().getId()))
                {
                    return i;
                }
            }
            for (int i = 0; i < 7; i++)
            { // if win is not posible in turn then it checks for a block 
                tempBoard = (Board)board.Clone();
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
                
                tempBoard = (Board)board.Clone();
                if (!tempBoard.board[5, i].isOpen()) //makes sure the bot doesnt play out of bounds
                    i++;
                if (i >= 7)
                    return -1;

                tempBoard.placePiece(i, board.getPlayer2());
                int row = 0;
                
                for (int j = 0; j < 6; j++)
                {
                    if (!tempBoard.board[j, i].isOpen())
                    {
                        row = j;
                    }
                }
                
                if (row > num - 1)
                {
                    Console.WriteLine("check col" + i);
                    if (checkNumInCol(tempBoard, i, row, board.getPlayer2().getId(), num))
                        return i;
                }

                Console.WriteLine("check diag" + i);

                if (checkNumInDiag(tempBoard, tempBoard.getPlayer2().getId(), num, row, i))
                    return i;
                Console.WriteLine("check row" + i);
                if (checkNumInRow(tempBoard, row, i, tempBoard.getPlayer2().getId(), num))
                    return i;
            }

            for (int i = 0; i < 7; i++)
            {
                tempBoard = (Board)board.Clone(); ;
                tempBoard.placePiece(i, board.getPlayer1());
                int row = 0;

                for (int j = 0; j < 6; j++)
                {
                    if (!tempBoard.board[j, i].isOpen())
                    {
                        Console.WriteLine(tempBoard.board[j,i].isOpen());
                        row = j;
                    }
                }
                
                if (row >= num - 1)
                {
                    Console.WriteLine("check col" + i);
                    if (checkNumInCol(tempBoard, i, row, board.getPlayer1().getId(), num))
                        return i;
                }

                Console.WriteLine("check diag" + i);

                if (checkNumInDiag(tempBoard, tempBoard.getPlayer1().getId(), num, row, i))
                    return i;
                Console.WriteLine("check row" + i);
                if (checkNumInRow(tempBoard, row, i, tempBoard.getPlayer1().getId(), num))
                    return i;
            }

            return -1;
        }

        bool checkNumInCol(Board board, int col, int row, int playerId, int num) //checks down from temp block
        {
            //Console.WriteLine("looking at col for player " + playerId + " ");
            for (int i = 0; i < num - 1; i++)
            {
                //Console.Write(board.board[row - i, col].getCharacter() + ", ");
                if (board.board[row - i, col].getCharacter() != (char)playerId)
                {
                    //Console.WriteLine();
                    return false;
                }
                    
            }
            Console.WriteLine();
            return true;
            
        }
        bool checkNumInDiag(Board board, int playerId, int num, int row, int col)
        {
            int numCount = 0;
            
            for (int i = 0; i < num; i++) // checks all 4 posible placements
            {
                numCount = 0;
                int tempRow;
                int tempCol;
                if (row - num + i >= 0 && row - num + i <= 3 && col - num + i <= 4 && col - num + i >= 0) //moves the row down 4
                {
                    tempRow = row - num + i;
                    tempCol = col - num + i;
                    for (int j = 0; j < num; j++)
                    {
                        if (board.board[tempRow, tempCol].getCharacter() == (char)playerId)
                            numCount++;
                        else
                            numCount = 0;
                        if (numCount == num)
                            return true;
                        tempRow++;
                        tempCol++;
                    }
                }
            }
            for (int i = 0; i < num; i++) // checks all 4 posible placements
            {
                numCount = 0;
                int tempRow = row - num + i;
                int tempCol = col + num - i;
                if (tempRow >= 0 && tempRow <= 3 && tempCol <= 4 && tempCol - i >= 0) //moves the row down 4
                {
                    
                    for (int j = 0; j < num; j++)
                    {
                        if (board.board[tempRow, tempCol].getCharacter() == (char)playerId)
                            numCount++;
                        else
                            numCount = 0;
                        if (numCount == num)
                            return true;
                        tempRow++;
                        tempCol--;
                    }
                }
            }
            return false;
        }
        bool checkNumInRow(Board board, int row, int col, int playerId, int num)
        {
            int numCount;
            for (int i = 0; i < 4; i++) //checks all posible states
            {
                //Console.WriteLine();
                numCount = 0;
                int tempCol = col - num + i;
                if (tempCol >= 0 && tempCol <= 4)
                    for (int j = 0;j < num; j++)
                    {
                        //Console.Write(board.board[row, tempCol].getCharacter());
                        if (board.board[row, tempCol].getCharacter() == (char)playerId)
                            numCount++;
                        else
                            numCount = 0;
                        if (numCount >= num)
                            return true;
                        tempCol++;
                    }
            }
            return false;
        }

        

        int randomLocation(Board board)
        {
            Random rnd = new Random();
            List<int> aviableSpaces = new List<int>();
            int amount = 0;
            for (int i = 0;i < board.getCols();i++)
            {
                if (board.board[5,i].isOpen())
                {
                    aviableSpaces.Add(i);
                    amount++;
                }
            }
            
            return aviableSpaces.ElementAt(rnd.Next(0, amount));
            
        }
    }
    

}