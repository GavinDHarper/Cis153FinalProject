using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    internal class Game
    {
        private List<Play> plays;
        private string player1;
        private string player2;
        private int winner;

        //--------------------------------------
        //          Setters
        //--------------------------------------
        public void setPlays(List<Play> p)
        {
            plays = p;
        }
        public void setPlayer1(string p)
        {
            player1 = p;
        }
        public void setPlayer2(string p)
        {
            player2 = p;
        }
        public void setWinner(int w)
        {
            winner = w;
        }
        //--------------------------------------
        //          Getters
        //--------------------------------------
        public List<Play> getPlays()
        {
            return plays;
        }
        public string getPlayer1()
        {
            return player1;
        }
        public string getPlayer2()
        {
            return player2;
        }
        public int getWinner()
        {
            return winner;
        }
        //--------------------------------------
        //          Constructors
        //--------------------------------------
        public Game()
        {
        }
        public Game(List<Play> plays, string player1, string player2, int winner)
        {
            this.plays = plays;
            this.player1 = player1;
            this.player2 = player2;
            this.winner = winner;
        }
        //--------------------------------------
        //          Functions
        //--------------------------------------
        public void addPlay(Play p)
        {
            plays.Add(p);
        }
    }
}
