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
    public partial class OptionsMenu : Form
    {
        public OptionsMenu()
        {
            InitializeComponent();
        }

        private void btnSpeedDec_Click(object sender, EventArgs e)
        {
            if (SnakeGame.speed > 1) SnakeGame.speed--;
            lblSpeedTotal.Text = SnakeGame.speed.ToString();
        }

        private void btnSpeedInc_Click(object sender, EventArgs e)
        {
            if (SnakeGame.speed < 10) SnakeGame.speed++;
            lblSpeedTotal.Text = SnakeGame.speed.ToString();
        }

        private void btnBonusChanceDec_Click(object sender, EventArgs e)
        {
            if (SnakeGame.bonusFoodChance > 10) SnakeGame.bonusFoodChance -= 10;
            lblBonusChanceTotal.Text = SnakeGame.bonusFoodChance.ToString() + "%";
        }

        private void btnBonusChanceInc_Click(object sender, EventArgs e)
        {
            if (SnakeGame.bonusFoodChance < 50) SnakeGame.bonusFoodChance += 10;
            lblBonusChanceTotal.Text = SnakeGame.bonusFoodChance.ToString() + "%";
        }

        private void OptionsMenu_Load(object sender, EventArgs e)
        {
            SnakeGame.timer.Stop();
            lblSpeedTotal.Text = SnakeGame.speed.ToString();
            lblBonusChanceTotal.Text = SnakeGame.bonusFoodChance.ToString() + "%";

            if (SnakeGame.barriers) btnBarrierOn.BackColor = Color.DarkSlateGray;
            else btnBarrierOff.BackColor = Color.DarkSlateGray;

            if (SnakeGame.roundSnake) btnRoundSnake.BackColor = Color.DarkSlateGray;
            else btnSquareSnake.BackColor = Color.DarkSlateGray;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
