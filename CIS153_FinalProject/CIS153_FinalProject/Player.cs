using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    internal class Player
    {
        private int id;
        private string name;
        private Chip chip;

        //--------------------------------------
        //          Setters
        //--------------------------------------
        public void setId(int i)
        {
            id = i;
        }
        public void setName(string n)
        {
            name = n;
        }
        public void setChip(Chip c)
        {
            chip = c;
        }
        //--------------------------------------
        //          Getters
        //--------------------------------------
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public Chip getChip()
        {
            return chip;
        }
        public Image getChipImage()
        {
            if(chip != null)
            { 
                return this.chip.getImage();
            }
            else
            {
                return Image.FromFile("../../Resources/emptyCell.png");
            }
        }
        public Color getChipColor()
        {
            return this.chip.getColor();
        }
        //--------------------------------------
        //          Constructors
        //--------------------------------------
        public Player()
        {
        }
        public Player(int id, string name, Chip chip)
        {
            this.id = id;
            this.name = name;
            this.chip = chip;
        }
        //--------------------------------------
        //          Functions
        //--------------------------------------
    }
}
