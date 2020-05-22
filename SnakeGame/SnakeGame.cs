using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SnakeGame : Form
    {
        public SnakeGame()
        {
            InitializeComponent();
        }

        public enum MoveDirection { Up, Down, Left, Right };
        MoveDirection snakeDirection;

        Point headPos;
        Point movePos;

        Random random = new Random();
        public static Timer timer = new Timer();
        public static Brush snakeCol = Brushes.DarkSlateBlue;

        public static int speed { get; set; } = 5;
        public static int bonusFoodChance { get; set; } = 10;
        public static int snakeColNum { get; set; } = 0;
        public static bool barriers { get; set;} = true;

        int lastSegment;
        int[,] matrix;
        int matSize;
        int score;
        int hiScore;
        int points = 100;
        int food = -1;
        int bonusFood = -2;
        int bonusFoodTime = 0;

        public static bool roundSnake = false;


        private void NewGame()
        {
            matSize = 25;
            matrix = new int[matSize, matSize];
            matrix[15, 10] = 1;

            headPos = new Point(15, 10);
            snakeDirection = MoveDirection.Left;

            lastSegment = 3;
            score = 0;
            lblScoreTotal.Text = score.ToString();
            lblGameOver.Visible = false;
            lblBonusFoodTimer.Visible = false;

            bonusFoodTime = 0;

            timer = new Timer();
            timer.Interval = 500 / speed;
            timer.Tick += timer_Tick;
            timer.Start();

       

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //MoveSnake();
            Draw();
        }

        private void Draw()
        {
            Bitmap bitmap = new Bitmap(pbGameBoard.Width, pbGameBoard.Height);
            Graphics gfx = Graphics.FromImage(bitmap);
            SizeF cellSize = new SizeF((float)pbGameBoard.Width / matSize, (float)pbGameBoard.Height / matSize);

            gfx.FillRectangle(Brushes.PaleGreen, 0, 0, pbGameBoard.Width, pbGameBoard.Height);

            for (int i = 0; i < matSize; i++)
            {
                for (int j = 0; j < matSize; j++)
                {
                    if (barriers)
                        if (i == 0 || j == 0 || i == matSize - 1 || j == matSize - 1) matrix[i, j] = 400;

                    Brush cellColour = Brushes.PaleTurquoise;

                    if (matrix[i, j] == 1) cellColour = Brushes.Black;
                    else if (matrix[i, j] > 399) cellColour = Brushes.DarkSlateGray;
                    else if (matrix[i, j] > 1) cellColour = snakeCol;
                    else if (matrix[i, j] == food) cellColour = Brushes.Red;
                    else if (matrix[i, j] == bonusFood)
                    {
                        if (bonusFoodTime > 0)
                        {
                            cellColour = Brushes.Blue;
                            bonusFoodTime--;
                            lblBonusFoodTimer.Text = bonusFoodTime.ToString() + "/nGet the bonus food!";
                        }
                        else
                        {
                            matrix[i, j] = 0;
                            lblBonusFoodTimer.Visible = false;
                        } 
                    }
                    if (matrix[i, j] < 399 && roundSnake) gfx.FillEllipse(cellColour, i * cellSize.Width - 1, j * cellSize.Height - 1, cellSize.Width - 1, cellSize.Height - 1);

                    else gfx.FillRectangle(cellColour, i * cellSize.Width - 1, j * cellSize.Height - 1, cellSize.Width - 1, cellSize.Height - 1);
                }
                pbGameBoard.BackgroundImage = bitmap;
            }
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
