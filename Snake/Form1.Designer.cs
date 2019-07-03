namespace Snake
{
    partial class SnakeForm
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
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.score_label = new System.Windows.Forms.Label();
            this.current_score = new System.Windows.Forms.Label();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.lblHighestScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbCanvas.Location = new System.Drawing.Point(13, 13);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(500, 500);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_label.Location = new System.Drawing.Point(540, 13);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(81, 26);
            this.score_label.TabIndex = 1;
            this.score_label.Text = "Score:";
            // 
            // current_score
            // 
            this.current_score.AutoSize = true;
            this.current_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.current_score.Location = new System.Drawing.Point(627, 13);
            this.current_score.Name = "current_score";
            this.current_score.Size = new System.Drawing.Size(25, 26);
            this.current_score.TabIndex = 2;
            this.current_score.Text = "0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGameOver.Location = new System.Drawing.Point(32, 43);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(146, 31);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "GameOver";
            this.lblGameOver.Visible = false;
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.asd.Location = new System.Drawing.Point(540, 43);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(169, 26);
            this.asd.TabIndex = 4;
            this.asd.Text = "Highest Score:";
            // 
            // lblHighestScore
            // 
            this.lblHighestScore.AutoSize = true;
            this.lblHighestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHighestScore.Location = new System.Drawing.Point(715, 43);
            this.lblHighestScore.Name = "lblHighestScore";
            this.lblHighestScore.Size = new System.Drawing.Size(25, 26);
            this.lblHighestScore.TabIndex = 5;
            this.lblHighestScore.Text = "0";
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(838, 527);
            this.Controls.Add(this.lblHighestScore);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.current_score);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.pbCanvas);
            this.Name = "SnakeForm";
            this.Text = "Snake - The Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label current_score;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label lblHighestScore;
    }
}

