/*
 * Created by: Allison Cook
 * Created on: 17 February, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program displays a different image in a picture box when a menu item is clicked
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

namespace MovingCatAllisonC
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void frmMovingCat_Load(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //When Exit clicked close program
            this.Close();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            //when Cat1 clicked change image to cat 1
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            //when Cat2 clicked change image to cat 2
            this.picCat.Image = Properties.Resources.cat2;
        }
    }
}
