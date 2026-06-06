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
    public partial class QuizForm : Form
    {
        GameEngine game;
        int TimeLeft = 10;
        public QuizForm()
        {
            InitializeComponent();
         
        }

        public QuizForm(GameEngine gameEngine)
        {
            InitializeComponent();
            game = gameEngine;
        }
       

        private void SettingTheGameQuestion()
        {
            game.GenerateQuestion();

            lblNum1.Text = game.CurrentQuestion.Num1.ToString();
            lblNum2.Text = game.CurrentQuestion.Num2.ToString();
            lblOperationType.Text = game.CurrentQuestion.OperationType.ToString();

            txbAnswer.Focus();



        }
        private void QuizForm_Load(object sender, EventArgs e)
        {
        
            lblCurrentRound.Text = game.CurrentRound.ToString();
            SettingTheGameQuestion();

            TimeLeft = 10;
            lblTimeLeft.Text = TimeLeft.ToString();
            QuizTimer.Start();


        }

        private void MoveToNextRound()
        {

            QuizTimer.Stop();

            game.CurrentRound++;
            lblCurrentRound.Text = game.CurrentRound.ToString();
            txbAnswer.Clear();
            SettingTheGameQuestion();
            TimeLeft = 10;
            lblTimeLeft.Text = TimeLeft.ToString();
            QuizTimer.Start();

        }
        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
          

            if (txbAnswer.Text=="")
            {
                MessageBox.Show("Please type your answer");
                return;
            }

            QuizTimer.Stop();

            int UserAnswer = Convert.ToInt32(txbAnswer.Text);
           

                bool Result = game.CheckAnswer(UserAnswer);
                if (Result)
                {
                    MessageBox.Show("Correct Answer");
                }
                else
                    MessageBox.Show("Wrong Answer");

             if (game.CurrentRound < game.TotalRounds)
               {
                  MoveToNextRound( );
                     
                } 
                 
               else 
                {
                 this.Hide();

                SummaryForm frm1 = new SummaryForm(game);
                frm1.ShowDialog();

                }

          

        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {

            TimeLeft--;

            lblTimeLeft.Text = TimeLeft.ToString();

            if(TimeLeft==0)
            {
                QuizTimer.Stop();

                game.NumberOfWrongAnswers++;
                MessageBox.Show("Time Over");


                if (game.CurrentRound < game.TotalRounds)
                {
                    MoveToNextRound();
                }
                else
                {
                    this.Hide();

                    SummaryForm frm1 = new SummaryForm(game);
                    frm1.ShowDialog();
                }




            }



            

        }
    }


}
