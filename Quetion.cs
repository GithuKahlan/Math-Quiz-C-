using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Quiz_C_
{
    public class Question
    {
        public short Num1 { get; set; }

        public short Num2 { get; set; }


        public int CorrectAnswer { get; set; } = 0;
       public enOperationsType OperationType { get; set;}
    }


}
