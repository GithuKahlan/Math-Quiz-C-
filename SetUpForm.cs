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
    public partial class SetUpForm : Form
    {

       

        GameEngine game = new GameEngine();
        public SetUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            short rounds = (short)RoundsControl.Value;
            enOperationsType OperationType = (enOperationsType)(comboxOperation.SelectedIndex+1);
            enDifficultyLevels Difficulty = (enDifficultyLevels)(comboxDifficuity.SelectedIndex+1);

         
            if(rounds==0|| comboxOperation.SelectedIndex <0 || comboxDifficuity.SelectedIndex<0)
            {
                MessageBox.Show("Please set your game instructions");
                return;

            }

               
            
            
            game.StartGame(rounds,OperationType,Difficulty);

            this.Hide();
            QuizForm frm1 = new QuizForm(game);
            frm1.ShowDialog();
            try
            {
                this.Show();
            }
            catch
            {
            }

            RoundsControl.Value = 0;
            comboxOperation.SelectedIndex = -1;
            comboxDifficuity.SelectedIndex = -1;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
           
        }
    }
}
