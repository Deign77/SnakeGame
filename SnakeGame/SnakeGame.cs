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
        int matrixSize;
        int score;
        int hiScore;
        int points = 100;
        int food = -1;
        int bonusFood = -2;
        int bonusFoodTime = 0;

        public static bool roundSnake = false;


        private void NewGame()
        {
            matrixSize = 25;
            matrix = new int[matrixSize, matrixSize];
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
