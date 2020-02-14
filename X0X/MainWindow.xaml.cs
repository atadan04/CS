using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace X0X
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static internal Button[,] buttonsLocation;

        static internal bool IsMovePlayer = true;
        private Random rnd = new Random(DateTime.Now.Millisecond);
        private string[] ScoreArr;
        static private string ScorePlayer;

        public MainWindow()
        {
            InitializeComponent();

            buttonsLocation = new Button[3, 3]
            {

                {btn1,btn2,btn3 },
                {btn4,btn5,btn6},
                {btn7,btn8,btn9 }
            };


        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsMovePlayer)
            {
                
                Button button = (Button)sender;
                if (button.Content == null)
                {
                    button.Content = DrawX();

                    WhoWin();


                }
                IsMovePlayer = false;
               
            }
            
            

            

        }
        public void WhoWin()
        {

            if (btn1.Content is Path && btn4.Content is Path && btn7.Content is Path)
            {
                WhoWinText.Foreground = System.Windows.Media.Brushes.DarkGreen;
                WhoWinText.Text = "YOU WIN";
                ScoreArr = Score.Text.Split(':');
                int temp = Convert.ToInt32(ScoreArr[0]);
                temp++;
                 ScoreArr[0] = temp.ToString();
                //if (btn1.Content == DrawX())
                //{
                //    WhoWinText.Foreground = System.Windows.Media.Brushes.DarkGreen;
                //    WhoWinText.Text = "YOU WIN";
                //}
                //else 
                //{
                //    WhoWinText.Foreground = System.Windows.Media.Brushes.DarkRed;
                //    WhoWinText.Text = "YOU LOSE";
                //}

            }
        }
        
        //public void WhoWin()
        //{

        //    if (btn1.Content.GetType() == btn4.Content.GetType() && btn1.Content.GetType() == btn7.Content.GetType())
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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!IsMovePlayer)
            {

                for (; ; )
                {
                    int x = rnd.Next(0, 3);
                    int y = rnd.Next(0, 3);
                    Button button = buttonsLocation[x, y];


                    if (button.Content == null)
                    {
                        button.Content = DrawCircle();

                        IsMovePlayer = true;
                        break;
                    }
                    //else if (btn1 != null & btn2 != null & btn3 != null &
                    //   btn4 != null & btn5 != null & btn6 != null &
                    //   btn7 != null & btn8 != null & btn9 != null)
                    //{
                    //    break;
                    //}
                    else if (button.Content != null)
                    {
                        continue;
                    }


                }


                WhoWin();

            }

        }

        public Ellipse DrawCircle()
        {
            
            Ellipse ellipse = new Ellipse();

            ellipse.Height = 50;
            ellipse.Width = 50;
            ellipse.StrokeThickness = 3;
            ellipse.Stroke = System.Windows.Media.Brushes.LightBlue;
            return ellipse;
        }
        public Path DrawX()
        {

            PathGeometry myPathGeometry = new PathGeometry();

            // Create a figure.
            PathFigure pathFigure1 = new PathFigure();
            pathFigure1.StartPoint = new System.Windows.Point(55, 55);


            pathFigure1.Segments.Add(
                new LineSegment(
                    new System.Windows.Point(5, 5),
                    true /* IsStroked */ ));


            myPathGeometry.Figures.Add(pathFigure1);

            PathFigure pathFigure2 = new PathFigure();
            pathFigure2.StartPoint = new System.Windows.Point(5, 55);


            pathFigure2.Segments.Add(
                new LineSegment(
                    new System.Windows.Point(55, 5),
                    true /* IsStroked */ ));


            myPathGeometry.Figures.Add(pathFigure2);

            // Display the PathGeometry. 
            Path myPath = new Path();
            myPath.Stroke = System.Windows.Media.Brushes.LightPink;
            myPath.StrokeThickness = 3;
            myPath.Data = myPathGeometry;
            return myPath;


        }
        
        
    }
}
