namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbGameBoard = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHiScore = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblHiScoreTotal = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGameBoard
            // 
            this.pbGameBoard.Location = new System.Drawing.Point(228, 181);
            this.pbGameBoard.Name = "pbGameBoard";
            this.pbGameBoard.Size = new System.Drawing.Size(100, 50);
            this.pbGameBoard.TabIndex = 0;
            this.pbGameBoard.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(149, 703);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 24);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblHiScore
            // 
            this.lblHiScore.AutoSize = true;
            this.lblHiScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiScore.Location = new System.Drawing.Point(328, 703);
            this.lblHiScore.Name = "lblHiScore";
            this.lblHiScore.Size = new System.Drawing.Size(110, 24);
            this.lblHiScore.TabIndex = 2;
            this.lblHiScore.Text = "High Score:";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTotal.Location = new System.Drawing.Point(220, 703);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(20, 24);
            this.lblScoreTotal.TabIndex = 3;
            this.lblScoreTotal.Text = "0";
            // 
            // lblHiScoreTotal
            // 
            this.lblHiScoreTotal.AutoSize = true;
            this.lblHiScoreTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiScoreTotal.Location = new System.Drawing.Point(444, 703);
            this.lblHiScoreTotal.Name = "lblHiScoreTotal";
            this.lblHiScoreTotal.Size = new System.Drawing.Size(20, 24);
            this.lblHiScoreTotal.TabIndex = 4;
            this.lblHiScoreTotal.Text = "0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(286, 545);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(50, 25);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "G O";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 774);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblHiScoreTotal);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblHiScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGameBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGameBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameBoard;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHiScore;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label lblHiScoreTotal;
        private System.Windows.Forms.Label lblGameOver;
    }
}

