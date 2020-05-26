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

            if (SnakeGame.barriers) btnBarrierOn.BackColor = Color.DeepSkyBlue;
            else btnBarrierOff.BackColor = Color.DeepSkyBlue;

            if (SnakeGame.roundSnake) btnRoundSnake.BackColor = Color.DeepSkyBlue;
            else btnSquareSnake.BackColor = Color.DeepSkyBlue;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBarrierOff_Click(object sender, EventArgs e)
        {
            SnakeGame.barriers = false;
            btnBarrierOff.BackColor = Color.DeepSkyBlue;
            btnBarrierOn.BackColor = Color.PowderBlue;
        }

        private void btnBarrierOn_Click(object sender, EventArgs e)
        {
            SnakeGame.barriers = true;
            btnBarrierOn.BackColor = Color.DeepSkyBlue;
            btnBarrierOff.BackColor = Color.PowderBlue;
        }

        private void btnRoundSnake_Click(object sender, EventArgs e)
        {
            SnakeGame.roundSnake = true;
            btnRoundSnake.BackColor = Color.DeepSkyBlue;
            btnSquareSnake.BackColor = Color.PowderBlue;
        }

        private void btnSquareSnake_Click(object sender, EventArgs e)
        {
            SnakeGame.roundSnake = false;
            btnSquareSnake.BackColor = Color.DeepSkyBlue;
            btnRoundSnake.BackColor = Color.PowderBlue;
        }

        private void btnSnakeColour1_Click(object sender, EventArgs e)
        {
            lblSnakeColour.BackColor = Color.DarkOrange;
        }

        private void btnSnakeColour2_Click(object sender, EventArgs e)
        {
            lblSnakeColour.BackColor = Color.Green;
        }

        private void btnSnakeColour3_Click(object sender, EventArgs e)
        {
            lblSnakeColour.BackColor = Color.DarkCyan;
        }

        private void btnBoardColour1_Click(object sender, EventArgs e)
        {
            SnakeGame.bkgdSelect = 0;
        }

        private void btnBoardColour2_Click(object sender, EventArgs e)
        {
            SnakeGame.bkgdSelect = 1;
        }

        private void btnBoardColour3_Click(object sender, EventArgs e)
        {
            SnakeGame.bkgdSelect = 2;

        }
    }
}
