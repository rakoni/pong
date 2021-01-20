namespace Pong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_leftStick = new System.Windows.Forms.PictureBox();
            this.pb_rightStick = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_ball = new System.Windows.Forms.PictureBox();
            this.lbl_player1Score = new System.Windows.Forms.Label();
            this.lbl_player2Score = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_player1Name = new System.Windows.Forms.Label();
            this.lbl_player2Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_leftStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightStick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ball)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_leftStick
            // 
            this.pb_leftStick.BackColor = System.Drawing.Color.Red;
            this.pb_leftStick.Location = new System.Drawing.Point(12, 265);
            this.pb_leftStick.Name = "pb_leftStick";
            this.pb_leftStick.Size = new System.Drawing.Size(21, 162);
            this.pb_leftStick.TabIndex = 0;
            this.pb_leftStick.TabStop = false;
            // 
            // pb_rightStick
            // 
            this.pb_rightStick.BackColor = System.Drawing.Color.Red;
            this.pb_rightStick.Location = new System.Drawing.Point(1331, 265);
            this.pb_rightStick.Name = "pb_rightStick";
            this.pb_rightStick.Size = new System.Drawing.Size(21, 162);
            this.pb_rightStick.TabIndex = 1;
            this.pb_rightStick.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb_ball
            // 
            this.pb_ball.Image = ((System.Drawing.Image)(resources.GetObject("pb_ball.Image")));
            this.pb_ball.Location = new System.Drawing.Point(690, 335);
            this.pb_ball.Name = "pb_ball";
            this.pb_ball.Size = new System.Drawing.Size(22, 22);
            this.pb_ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_ball.TabIndex = 2;
            this.pb_ball.TabStop = false;
            // 
            // lbl_player1Score
            // 
            this.lbl_player1Score.AutoSize = true;
            this.lbl_player1Score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player1Score.ForeColor = System.Drawing.Color.White;
            this.lbl_player1Score.Location = new System.Drawing.Point(618, 9);
            this.lbl_player1Score.Name = "lbl_player1Score";
            this.lbl_player1Score.Size = new System.Drawing.Size(29, 31);
            this.lbl_player1Score.TabIndex = 3;
            this.lbl_player1Score.Text = "0";
            // 
            // lbl_player2Score
            // 
            this.lbl_player2Score.AutoSize = true;
            this.lbl_player2Score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player2Score.ForeColor = System.Drawing.Color.White;
            this.lbl_player2Score.Location = new System.Drawing.Point(782, 9);
            this.lbl_player2Score.Name = "lbl_player2Score";
            this.lbl_player2Score.Size = new System.Drawing.Size(29, 31);
            this.lbl_player2Score.TabIndex = 4;
            this.lbl_player2Score.Text = "0";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.White;
            this.lbl_score.Location = new System.Drawing.Point(675, 9);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(85, 31);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Score";
            // 
            // lbl_player1Name
            // 
            this.lbl_player1Name.AutoSize = true;
            this.lbl_player1Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player1Name.ForeColor = System.Drawing.Color.White;
            this.lbl_player1Name.Location = new System.Drawing.Point(426, 15);
            this.lbl_player1Name.Name = "lbl_player1Name";
            this.lbl_player1Name.Size = new System.Drawing.Size(108, 25);
            this.lbl_player1Name.TabIndex = 6;
            this.lbl_player1Name.Text = "Jogador 1";
            // 
            // lbl_player2Name
            // 
            this.lbl_player2Name.AutoSize = true;
            this.lbl_player2Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player2Name.ForeColor = System.Drawing.Color.White;
            this.lbl_player2Name.Location = new System.Drawing.Point(898, 15);
            this.lbl_player2Name.Name = "lbl_player2Name";
            this.lbl_player2Name.Size = new System.Drawing.Size(108, 25);
            this.lbl_player2Name.TabIndex = 7;
            this.lbl_player2Name.Text = "Jogador 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(844, 452);
            this.Controls.Add(this.lbl_player2Name);
            this.Controls.Add(this.lbl_player1Name);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_player2Score);
            this.Controls.Add(this.lbl_player1Score);
            this.Controls.Add(this.pb_ball);
            this.Controls.Add(this.pb_rightStick);
            this.Controls.Add(this.pb_leftStick);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_leftStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightStick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_leftStick;
        private System.Windows.Forms.PictureBox pb_rightStick;
        private System.Windows.Forms.Timer timer1;
        public Form4 f4;
        private System.Windows.Forms.PictureBox pb_ball;
        private System.Windows.Forms.Label lbl_player1Score;
        private System.Windows.Forms.Label lbl_player2Score;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_player1Name;
        private System.Windows.Forms.Label lbl_player2Name;
    }
}

