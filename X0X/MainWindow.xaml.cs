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
        static internal bool IsMoveEnemy = false;

        private Random rnd = new Random(DateTime.Now.Millisecond);
        public delegate void DelegateWhoWin(Button[,] buttons);
        public event DelegateWhoWin WhoIsWon;
        static int ScoreUserInt = 0;
        static int ScoreEnemyInt = 0;
        static bool restartFlag = false;
        

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
                    IsMovePlayer = false;
                    IsMoveEnemy = true;
                    WhoWin();
                    if (!restartFlag)
                    {
                        IsMovePlayer = false;
                        IsMoveEnemy = false;

                    }



                }




            }
            
            

            

        }
        
        public void WhoWin()
        {
            
            
            if (btn1.Content is Path && btn4.Content is Path && btn7.Content is Path||
                btn2.Content is Path && btn5.Content is Path && btn8.Content is Path||
                btn3.Content is Path && btn6.Content is Path && btn9.Content is Path||
                btn1.Content is Path && btn2.Content is Path && btn3.Content is Path||
                btn4.Content is Path && btn5.Content is Path && btn6.Content is Path||
                btn7.Content is Path && btn8.Content is Path && btn9.Content is Path||
                btn1.Content is Path && btn5.Content is Path && btn9.Content is Path||
                btn3.Content is Path && btn5.Content is Path && btn7.Content is Path)
            {
                WhoIsWon += PlayerWon;
                WhoIsWon(buttonsLocation);
                ScoreUserInt = Convert.ToInt32(ScoreUser.Text);
                ScoreUserInt++;
                ScoreUser.Text = ScoreUserInt.ToString();
                restartFlag = true;
               


            }
            else
            {
                if (btn1.Content != null && btn2.Content != null && btn3.Content != null &&
                                btn4.Content != null && btn5.Content != null && btn6.Content != null &&
                                btn7.Content != null && btn8.Content != null && btn9.Content != null)
                {
                    WhoIsWon += DeadHeat;
                    WhoIsWon(buttonsLocation);
                    restartFlag = true;
                    ScoreUserInt = Convert.ToInt32(ScoreUser.Text);
                    ScoreUserInt++;
                    ScoreUser.Text = ScoreUserInt.ToString();

                    ScoreEnemyInt = Convert.ToInt32(ScoreEnemy.Text);
                    ScoreEnemyInt++;
                    ScoreEnemy.Text = ScoreEnemyInt.ToString();

                }
            }
            if (btn1.Content is Ellipse && btn4.Content is Ellipse && btn7.Content is Ellipse ||
                btn2.Content is Ellipse && btn5.Content is Ellipse && btn8.Content is Ellipse ||
                btn3.Content is Ellipse && btn6.Content is Ellipse && btn9.Content is Ellipse ||
                btn1.Content is Ellipse && btn2.Content is Ellipse && btn3.Content is Ellipse ||
                btn4.Content is Ellipse && btn5.Content is Ellipse && btn6.Content is Ellipse ||
                btn7.Content is Ellipse && btn8.Content is Ellipse && btn9.Content is Ellipse ||
                btn1.Content is Ellipse && btn5.Content is Ellipse && btn9.Content is Ellipse ||
                btn3.Content is Ellipse && btn5.Content is Ellipse && btn7.Content is Ellipse)
            {
                WhoIsWon += EnemyWon;
                WhoIsWon(buttonsLocation);
                restartFlag = true;
                ScoreEnemyInt = Convert.ToInt32(ScoreEnemy.Text);
                ScoreEnemyInt++;
                ScoreEnemy.Text = ScoreEnemyInt.ToString();
                

            }
           





        }

        private void DeadHeat(Button[,] buttons)//обработчик события
        {
            DelegateWhoWin delegateWhoWin;
            delegateWhoWin = IsDeadHeat;
            delegateWhoWin(buttonsLocation);
            
        }

        private void EnemyWon(Button[,] buttons) //обработчик события
        {
            DelegateWhoWin delegateWhoWin;
            delegateWhoWin = IsEnemyWon;
            delegateWhoWin(buttonsLocation);
           

        }

        private void PlayerWon(Button[,] buttons) //обработчик события
        {
            DelegateWhoWin delegateWhoWin;
            delegateWhoWin = IsPlayerWon;
            delegateWhoWin(buttonsLocation);
            

        }

        public void IsPlayerWon(Button[,] buttons)//метод соответствующий делегату DelegateWhoWin
        {
           
            
                WhoWinText.Foreground = System.Windows.Media.Brushes.DarkGreen;
                WhoWinText.Text = "YOU WIN";
                
            
        }
        public void IsEnemyWon(Button[,] buttons) //метод соответствующий делегату DelegateWhoWin
        {
            
            WhoWinText.Foreground = System.Windows.Media.Brushes.DarkRed;
            WhoWinText.Text = "YOU LOSE";
            
        
        

    }
        public void IsDeadHeat(Button[,] buttons) //метод соответствующий делегату DelegateWhoWin
        {
            
            WhoWinText.Foreground = System.Windows.Media.Brushes.DarkOrange;
            WhoWinText.Text = "DEAD HEAT";

           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Done
        {
            
            if (!IsMoveEnemy)
            {
                

                for (; ; )
                {
                    int x = rnd.Next(0, 3);
                    int y = rnd.Next(0, 3);
                    Button button = buttonsLocation[x, y];
                    

                    if (button.Content == null)
                    {
                        button.Content = DrawCircle();
                        IsMoveEnemy = false;
                        IsMovePlayer = true;
                        
                        break;
                    }
                   
                    else if (button.Content != null)
                    {
                        continue;
                    }

                    
                }

                WhoWin();
                if (restartFlag)
                {
                    IsMovePlayer = false;
                    IsMoveEnemy = false;

                }

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

            // Создание креста
            PathFigure pathFigure1 = new PathFigure();
            pathFigure1.StartPoint = new System.Windows.Point(55, 55);


            pathFigure1.Segments.Add(
                new LineSegment(
                    new System.Windows.Point(5, 5),
                    true  /*Отображение линии*/  ));


            myPathGeometry.Figures.Add(pathFigure1);

            PathFigure pathFigure2 = new PathFigure();
            pathFigure2.StartPoint = new System.Windows.Point(5, 55);


            pathFigure2.Segments.Add(
                new LineSegment(
                    new System.Windows.Point(55, 5),
                    true /*Отображение линии*/ ));


            myPathGeometry.Figures.Add(pathFigure2);

            // Вывод фигуры 
            Path myPath = new Path();
            myPath.Stroke = System.Windows.Media.Brushes.LightPink;
            myPath.StrokeThickness = 3;
            myPath.Data = myPathGeometry;
            return myPath;


        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //restart
        {
            if (restartFlag)
            {
                btn1.Content = null;
                btn2.Content = null;
                btn3.Content = null;
                btn4.Content = null;
                btn5.Content = null;
                btn6.Content = null;
                btn7.Content = null;
                btn8.Content = null;
                btn9.Content = null;
                WhoWinText.Text = "";
                IsMovePlayer = true;
                IsMoveEnemy = false;
                restartFlag = false;

            }
        }
    }
}
