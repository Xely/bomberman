using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace wpfBomberman
{
    public partial class Board : Window
    {
        Image robot;
        int rows;
        int cols;
        int[] playerPosition = new int[2];

        public Board()
        {
            InitializeComponent();
            this.KeyDown += HandleKeyPress;

            this.rows = 8;
            this.cols = 8;
            InitializeGrid(this.rows, this.cols);
            this.robot = getRobot();
            placeWalls();

            playerPosition[0] = 1;
            playerPosition[1] = 1;
            Grid.SetColumn(this.robot, 1);
            Grid.SetRow(this.robot, 1);
            grid.Children.Add(this.robot);
            
            //var cell = Grid.Children
            //      .Cast<UIElement>()
            //    .First(e => Grid.GetRow(e) == 1 && Grid.GetColumn(e) == 1);
            //Button button = new Button();
            //button.Content = "test";
            //unigrid.Children.Add(button);


            /*Button button = new Button();
            button.Content = "test";
            Grid.SetColumn(button, 1);
            Grid.SetRow(button, 1);
            grid.Children.Add(button);*/

        }

        private void InitializeGrid(int rows, int cols)
        {
            for (var i = 0; i < rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }

            for (var j = 0; j < cols; j++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        private void getGraphicalItems()
        {
            getRobot();
            getWall();
            getBomb();
        }

        private Image getRobot()
        {
            Image robot = new Image();
            robot.Width = 120;
            robot.Height = 120;

            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("/images/robot_nobg.png", UriKind.Relative);
            logo.EndInit();
            robot.Source = logo;

            return robot;
        }

        private Image getBomb()
        {
            Image bomb = new Image();
            bomb.Width = 120;
            bomb.Height = 120;

            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("/images/bomb.jpg", UriKind.Relative);
            logo.EndInit();
            bomb.Source = logo;

            return bomb;
        }

        private Image getWall()
        {
            Image wall = new Image();
            wall.Width = 120;
            wall.Height = 120;

            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("/images/wall.jpg", UriKind.Relative);
            logo.EndInit();
            wall.Source = logo;

            return wall;
        }

        private void placeWalls()
        {
            placeAWall(0, 0);
            placeAWall(0, 1);
            placeAWall(0, 2);
            placeAWall(0, 3);
            placeAWall(0, 4);
            placeAWall(0, 5);
            placeAWall(0, 6);
            placeAWall(0, 7);
            placeAWall(1, 0);
            placeAWall(2, 0);
            placeAWall(3, 0);
            placeAWall(4, 0);
            placeAWall(5, 0);
            placeAWall(6, 0);
            placeAWall(7, 0);
            placeAWall(1, 7);
            placeAWall(2, 7);
            placeAWall(3, 7);
            placeAWall(4, 7);
            placeAWall(5, 7);
            placeAWall(6, 7);
            placeAWall(7, 7);
            placeAWall(7, 6);
            placeAWall(7, 5);
            placeAWall(7, 4);
            placeAWall(7, 3);
            placeAWall(7, 2);
            placeAWall(7, 1);

            placeAWall(2, 4);
            placeAWall(5, 4);
            placeAWall(6, 4);
        }

        private void placeAWall(int row, int col)
        {
            Image wall = getWall();
            Grid.SetRow(wall, row);
            Grid.SetColumn(wall, col);
            grid.Children.Add(wall);
        }

        private void movePlayer(Key direction)
        {
            if (direction == Key.Right)
            {
                grid.Children.Remove(this.robot);

                Grid.SetRow(this.robot, this.playerPosition[0]);
                Grid.SetColumn(this.robot, ++this.playerPosition[1]);
                grid.Children.Add(this.robot);
            }
            if (direction == Key.Down)
            {
                grid.Children.Remove(this.robot);

                Grid.SetRow(this.robot, ++this.playerPosition[0]);
                Grid.SetColumn(this.robot, this.playerPosition[1]);
                grid.Children.Add(this.robot);
            }
            if (direction == Key.Left)
            {
                grid.Children.Remove(this.robot);

                Grid.SetRow(this.robot, this.playerPosition[0]);
                Grid.SetColumn(this.robot, --this.playerPosition[1]);
                grid.Children.Add(this.robot);
            }
            if (direction == Key.Up)
            {
                grid.Children.Remove(this.robot);

                Grid.SetRow(this.robot, --this.playerPosition[0]);
                Grid.SetColumn(this.robot, this.playerPosition[1]);
                grid.Children.Add(this.robot);
            }
        }

        private void placeBomb()
        {
            Image bomb = getBomb();
            Grid.SetRow(bomb, this.playerPosition[0]);
            Grid.SetColumn(bomb, this.playerPosition[1]);
            grid.Children.Add(bomb);

        }
        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right || e.Key == Key.Left || e.Key == Key.Down || e.Key == Key.Up)
            {
                movePlayer(e.Key);
            }
            if (e.Key == Key.Space)
            {
                placeBomb();
            }
        }
    }
}
