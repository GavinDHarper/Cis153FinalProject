using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    internal class Chip
    {
        private string imagePath;
        private Image chipImage;
        private Color chipColor;
        //--------------------------------------
        //          Setters
        //--------------------------------------
        public void setImage(string imagePath)
        {
            chipImage = Image.FromFile(imagePath);
        }
        public void setColor(Color color)
        {
            chipColor = color;
        }
        //--------------------------------------
        //          Getters
        //--------------------------------------
        public Image getImage()
        {
            return chipImage;
        }
        public Color getColor()
        {
            return chipColor;
        }
        //--------------------------------------
        //          Constructors
        //--------------------------------------
        public Chip()
        {
        }

        public Chip(string imagePath, Color color)
        {
            chipImage = Image.FromFile(imagePath);
            chipColor = color;
        }
    }
}
