/*
 * Assignment 01
 * Name: Parth Vinodbhai Darji
 * Purpose: creating Tic Tac Toe game
 * Revision History
 *      created by Parth Darji at Oct 02, 2021
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDarjiAssignment1
{
    public partial class Tic_Tac_Toe : Form
    {
        //global variables
        bool turnImage = true;
        int counter = 0;
        Image noneImage = Properties.Resources.none;
        Image xImage = Properties.Resources.XImage;
        Image oImage = Properties.Resources.OImage;
        public Tic_Tac_Toe()
        {
            InitializeComponent();
        }

        private void Tic_Tac_Toe_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            foreach (Control item in Controls)
            {
                if (item is PictureBox)
                {
                    PictureBox tile = (PictureBox)item;
                    tile.Image = noneImage;
                    tile.SizeMode = PictureBoxSizeMode.StretchImage;
                    tile.Enabled = true;
                }
            }
            counter = 0;
            turnImage = true;
        }

        private void Image_Click(object sender, EventArgs e)
        {
            PictureBox tile = (PictureBox)sender;
            if (turnImage)
            {
                tile.Image = xImage;
            }
            else
            {
                tile.Image = oImage;
            }

            turnImage = !turnImage;
            tile.Enabled = false;
            counter++;
            CheckForWinner(); //calling method to the the winner
        }
        private void CheckForWinner()
        {
            bool winnerCheck = false;

            //Horizontally 
            if ((pictureBoxA1.Image == xImage) && (pictureBoxA2.Image == xImage) && (pictureBoxA3.Image == xImage)
                || (pictureBoxA1.Image == oImage) && (pictureBoxA2.Image == oImage) && (pictureBoxA3.Image == oImage))
            {
                winnerCheck = true;
            }
            else if ((pictureBoxB1.Image == xImage) && (pictureBoxB2.Image == xImage) && (pictureBoxB3.Image == xImage)
                || (pictureBoxB1.Image == oImage) && (pictureBoxB2.Image == oImage) && (pictureBoxB3.Image == oImage))
            {
                winnerCheck = true;
            }
            else if ((pictureBoxC1.Image == xImage) && (pictureBoxC2.Image == xImage) && (pictureBoxC3.Image == xImage)
                || (pictureBoxC1.Image == oImage) && (pictureBoxC2.Image == oImage) && (pictureBoxC3.Image == oImage))
            {
                winnerCheck = true;
            }
            //Vertically
            else if ((pictureBoxA1.Image == xImage) && (pictureBoxB1.Image == xImage) && (pictureBoxC1.Image == xImage)
               || (pictureBoxA1.Image == oImage) && (pictureBoxB1.Image == oImage) && (pictureBoxC1.Image == oImage))
            {
                winnerCheck = true;
            }
            else if ((pictureBoxA2.Image == xImage) && (pictureBoxB2.Image == xImage) && (pictureBoxC2.Image == xImage)
               || (pictureBoxA2.Image == oImage) && (pictureBoxB2.Image == oImage) && (pictureBoxC2.Image == oImage))
            {
                winnerCheck = true;
            }
            else if ((pictureBoxA3.Image == xImage) && (pictureBoxB3.Image == xImage) && (pictureBoxC3.Image == xImage)
               || (pictureBoxA3.Image == oImage) && (pictureBoxB3.Image == oImage) && (pictureBoxC3.Image == oImage))
            {
                winnerCheck = true;
            }
            //Diagonally
            else if ((pictureBoxA1.Image == xImage) && (pictureBoxB2.Image == xImage) && (pictureBoxC3.Image == xImage)
               || (pictureBoxA1.Image == oImage) && (pictureBoxB2.Image == oImage) && (pictureBoxC3.Image == oImage))
            {
                winnerCheck = true;
            }
            else if ((pictureBoxA3.Image == xImage) && (pictureBoxB2.Image == xImage) && (pictureBoxC1.Image == xImage)
               || (pictureBoxA3.Image == oImage) && (pictureBoxB2.Image == oImage) && (pictureBoxC1.Image == oImage))
            {
                winnerCheck = true;
            }


            if (winnerCheck)
            {

                string winner = "";

                if (turnImage)
                {
                    winner = "O";
                    winnerCheck = false;


                }
                else
                {
                    winner = "X";
                    winnerCheck = false;


                }

                MessageBox.Show(winner + " wins!");
                Init();
            }
            else
            {
                if (counter == 9)
                {

                    MessageBox.Show("It's Draw!", "Do it again!");
                    winnerCheck = false;
                    Init();
                }
            }

        }
    }
}
