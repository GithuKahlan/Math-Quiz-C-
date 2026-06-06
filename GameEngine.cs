using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Math_Quiz_C_
{
    public class GameEngine
    {
        public short CurrentRound { get; set; }
        public short NumberOfCorrectAnswers { get; set;}
        public short NumberOfWrongAnswers { get; set;}
        public enDifficultyLevels Difficulty { get; set; }
       public short TotalRounds { get; set;}
       public enOperationsType Operation { get; set;}

        public Question CurrentQuestion { get; set;}

        Random rand = new Random();

        private short GenerateRandomNumber()
        {
            int min = 0;
            int max = 0;

            switch(Difficulty)
            {

                case enDifficultyLevels.Easy:
                    min = 1;
                    max = 10;
                    break;

                case enDifficultyLevels.Medium:
                    min = 10;
                    max = 50;
                    break;

                case enDifficultyLevels.Hard:
                    min = 50;
                    max = 100;
                    break;

                case enDifficultyLevels.MixLevel:

                    int pick = rand.Next(1, 4);

                    if(pick==1)
                    {
                        min = 1;max = 10;
                    }

                    if (pick == 2)
                    {
                        min = 10; max = 50;
                    }
                    if (pick == 3)
                    {
                        min = 50; max = 100;
                    }
                    break;

            }

            return (short)rand.Next(min, max+1);



        }


        public bool CheckAnswer(int userAnswer)
        {
            if (userAnswer == CurrentQuestion.CorrectAnswer)
            {

                NumberOfCorrectAnswers++;
                return true;
            }

            else
            {
                NumberOfWrongAnswers++;
                return false;
            }
 
        }

        public int CalculatecorrectAnswer(int Num1,int Num2,enOperationsType Operation)
        {

            switch(Operation)
            {
                case enOperationsType.Add:
                    return Num1 + Num2;


                case enOperationsType.Substract:
                    return Num1 - Num2;

                case enOperationsType.Multiply:
                    return Num1 * Num2;

                case enOperationsType.Divide:

                    if (Num2 != 0)
                    {
                        return Num1 / Num2;
                    }
                    else
                        return 0;
                default:
                    return 0;

            }
        }

        public void GenerateQuestion()
        {

            
            enOperationsType ChosenOperation;

            Question Q = new Question();

           Q.Num1 = GenerateRandomNumber();
           Q.Num2 = GenerateRandomNumber();

            int num1 = Q.Num1;
            int num2 = Q.Num2;


            if (Operation!= enOperationsType.Mix)
            {
                ChosenOperation = Operation;

            }

            else
            {

                ChosenOperation = (enOperationsType)rand.Next(1, 5);
            }

            Q.OperationType = ChosenOperation;


          Q.CorrectAnswer= CalculatecorrectAnswer(num1, num2, ChosenOperation);


            CurrentQuestion = Q;

        }

        public void StartGame(short rounds,enOperationsType operation,enDifficultyLevels difficulty)
        {

            this.CurrentRound = 1;
            this.NumberOfCorrectAnswers = 0;
            this.NumberOfWrongAnswers = 0;
            this.Difficulty = difficulty;
            this.TotalRounds = rounds;
            this.Operation = operation;

        }


    }



}
