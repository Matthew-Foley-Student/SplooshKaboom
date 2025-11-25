using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplooshKaboom
{
    public partial class frmWinOrLost : Form
    {
        public frmWinOrLost(string condition)
        {
            InitializeComponent();
            if (condition == "win")
            {
                lblWinOrLost.Text = "You Win!!";
                lblWinOrLost.ForeColor = Color.Green;
            }
            else
            {
                lblWinOrLost.Text = "You Have Lost :(";
                lblWinOrLost.ForeColor = Color.Red;
            }
        }

        private void endEvereything(object sender, FormClosingEventArgs e)
        {
        }

        private void endit(object sender, FormClosedEventArgs e)
        {
            frmPlayerForm.sharedata = "close";
        }
    }
}
