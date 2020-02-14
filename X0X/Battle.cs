using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace X0X
{
     class Battle:MainWindow
    {
        private Random rnd = new Random(DateTime.Now.Millisecond);
        
        public void Fight()
        {

            if (!IsMovePlayer)
            {
                Button button = buttonsLocation[rnd.Next(0, 2), rnd.Next(0, 2)];


                if (button.Content == null)
                {
                    button.Content = DrawCircle();
                    IsMovePlayer = true;
                }
                else
                {
                    button = buttonsLocation[rnd.Next(0, 2), rnd.Next(0, 2)];
                }


            }



        }
        
        //public void WhoWin()
        //{
        //    if (btn1.Content is Path && btn4.Content is Path && btn7.Content is Path)
        //    {
        //        WhoWinText.Foreground = System.Windows.Media.Brushes.DarkGreen;
        //        WhoWinText.Text = "YOU WIN";
        //        //if (btn1.Content == DrawX())
        //        //{
        //        //    WhoWinText.Foreground = System.Windows.Media.Brushes.DarkGreen;
        //        //    WhoWinText.Text = "YOU WIN";
        //        //}
        //        //else 
        //        //{
        //        //    WhoWinText.Foreground = System.Windows.Media.Brushes.DarkRed;
        //        //    WhoWinText.Text = "YOU LOSE";
        //        //}

        //    }
        //}
        

    }
}
