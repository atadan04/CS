using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppXamarin.Service
{
    static class Operation
    {
        public static string flag = "";
        
       static  public double Add(double firstNum, double secondNum)
        {
            flag = "+";
            return firstNum + secondNum;
        }
        static public double Difference(double firstNum, double secondNum)
        {
            flag = "-";
            return firstNum - secondNum;
        }
        static public double Multiply(double firstNum, double secondNum)
        {
            flag = "*";
            return firstNum * secondNum;
        }
        static public double Divide(double firstNum, double secondNum)
        {
            double result ;
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
