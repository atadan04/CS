using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using FirstAppXamarin.Service;
using Xamarin.Forms;

namespace FirstAppXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        Nums nums = new Nums();

        List<string> list = new List<string>();
      

        private void button_Clicked(object sender, EventArgs e)
        {
            Label label = DisplayOut;
            


            
            if (sender is Button)
            {
                
                Button button1 = (Button)sender;
                
                if (button1==buttonOne||
                    button1 == buttonTwo||
                    button1 == buttonThree|| 
                    button1 == buttonFour||
                    button1 == buttonFive|| 
                    button1 == buttonSix||
                    button1 == buttonSeven||
                    button1 == buttonEight||
                    button1 == buttonNine|| 
                    button1 == buttonZero)
                {
                    list.Add(button1.Text);
                    
                    label.Text += button1.Text;
                }
                else if (button1==buttonAdd)    //операция сложения
                {
                    if (!string.IsNullOrWhiteSpace(label.Text))
                    {
                        

                        nums.Num1 = double.Parse(label.Text);
                        label.Text = "";
                        Operation.flag = "+";
                    }
                    
                    
                }

                else if (button1 == buttonDifference)
                {
                    if (!string.IsNullOrWhiteSpace(label.Text))
                    {
                        nums.Num1 = double.Parse(label.Text); //операция вычитания
                        label.Text = "";
                        Operation.flag = "-";
                    }
                    
                }

                else if (button1 == buttonMultiply)  //операция умножения
                {
                    if (!string.IsNullOrWhiteSpace(label.Text))
                    {
                         nums.Num1 = double.Parse(label.Text);
                        label.Text = "";
                        Operation.flag = "*";
                    }
                }

                else if (button1 == buttonDivide) //операция деления 
                {
                    if (!string.IsNullOrWhiteSpace(label.Text))
                    {
                        nums.Num1 = double.Parse(label.Text);
                        label.Text = "";
                        Operation.flag = "/";
                    }
                }
                else if (button1 == buttonBackspace) //стереть последний символ
                {
                    label.Text = "";
                    if (list.Count!=0)
                    {
                        list.RemoveAt(list.Count - 1);
                        for (int i = 0; i < list.Count; i++)
                        {
                            label.Text += list[i];
                        }
                    }
                    
                    
                    
                    
                }
                else if (button1==buttonClear)          //очистить
                {
                    label.Text = "";
                    list.Clear();
                }


                else if (button1==buttonDot)
                {
                    if (!string.IsNullOrWhiteSpace(label.Text))
                    {
                        label.Text += ",";
                        list.Add(",");
                    }
                    else
                    {
                        label.Text += "0,";
                        list.Add("0");
                        list.Add(",");
                    }
                    
                }
                else if (button1==buttonNegative)
                {
                    if (!string.IsNullOrWhiteSpace(label.Text))
                    {
                        double result = double.Parse(label.Text);
                        result *= -1;
                        label.Text = result.ToString();
                    }
                }
                else if(button1==buttonEqually) //выбор метода 
                {   if (!string.IsNullOrWhiteSpace(label.Text))
                    {
                        nums.Num2 = double.Parse(label.Text);
                        label.Text = "";
                        double result = 0;
                        if (Operation.flag == "*")
                        {
                            result = Operation.Multiply(nums.Num1, nums.Num2);
                            

                        }
                        if (Operation.flag == "/")
                        {
                            result = Operation.Divide(nums.Num1, nums.Num2);
                            
                        }
                        if (Operation.flag == "+")
                        {
                            result = Operation.Add(nums.Num1, nums.Num2);
                            
                        }
                        if (Operation.flag == "-")
                        {
                            result = Operation.Difference(nums.Num1, nums.Num2);
                            
                        }
                        label.Text += result.ToString();
                        list.Clear();
                        list.Add(label.Text);
                    }
                   
                    

                }
            }
        }

        
    }
}
