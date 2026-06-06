using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz_C_
{
    public partial class SummaryForm : Form
    {
        GameEngine game;
        public SummaryForm(GameEngine gameEngine)
        {
            InitializeComponent();
            game = gameEngine;
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {

            lblCorrectAnswers.Text = game.NumberOfCorrectAnswers.ToString();
            lblWrongAnswers.Text = game.NumberOfWrongAnswers.ToString();
            lblTotalRounds.Text = game.TotalRounds.ToString();
            if (game.NumberOfCorrectAnswers >= game.NumberOfWrongAnswers)
            {
                lblResult.Text = "Pass";

            }
            else
                lblResult.Text = "Fail";
      

        }

        private void btnReStart_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
