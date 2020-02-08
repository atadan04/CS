using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppXamarin.Service
{
    static class Operation
    {
        public static string flag = "";
        
       static  public int Add(int firstNum, int secondNum)
        {
            flag = "+";
            return firstNum + secondNum;
        }
        static public int Difference(int firstNum, int secondNum)
        {
            flag = "-";
            return firstNum - secondNum;
        }
        static public int Multiply(int firstNum, int secondNum)
        {
            flag = "*";
            return firstNum * secondNum;
        }
        static public int Divide(int firstNum, int secondNum)
        {
            int result ;
            flag = "/";
            try
            {
                result = firstNum / secondNum;
            }
            catch (DivideByZeroException)
            {

                result = 0;
            }
            
            return result;
            
            
        }
        
    }
}
