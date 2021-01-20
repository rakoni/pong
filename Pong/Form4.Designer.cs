namespace Pong
{
    partial class Form4
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
            this.tb_player1Name = new System.Windows.Forms.TextBox();
            this.tb_player2Name = new System.Windows.Forms.TextBox();
            this.lbl_player1Name = new System.Windows.Forms.Label();
            this.lbl_player2Name = new System.Windows.Forms.Label();
            this.lbl_InsiraJogadores = new System.Windows.Forms.Label();
            this.btn_Jogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_player1Name
            // 
            this.tb_player1Name.Location = new System.Drawing.Point(176, 134);
            this.tb_player1Name.Name = "tb_player1Name";
            this.tb_player1Name.Size = new System.Drawing.Size(200, 20);
            this.tb_player1Name.TabIndex = 0;
            // 
            // tb_player2Name
            // 
            this.tb_player2Name.Location = new System.Drawing.Point(176, 232);
            this.tb_player2Name.Name = "tb_player2Name";
            this.tb_player2Name.Size = new System.Drawing.Size(200, 20);
            this.tb_player2Name.TabIndex = 1;
            // 
            // lbl_player1Name
            // 
            this.lbl_player1Name.AutoSize = true;
            this.lbl_player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player1Name.Location = new System.Drawing.Point(62, 134);
            this.lbl_player1Name.Name = "lbl_player1Name";
            this.lbl_player1Name.Size = new System.Drawing.Size(108, 25);
            this.lbl_player1Name.TabIndex = 2;
            this.lbl_player1Name.Text = "Jogador 1";
            // 
            // lbl_player2Name
            // 
            this.lbl_player2Name.AutoSize = true;
            this.lbl_player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player2Name.Location = new System.Drawing.Point(62, 232);
            this.lbl_player2Name.Name = "lbl_player2Name";
            this.lbl_player2Name.Size = new System.Drawing.Size(108, 25);
            this.lbl_player2Name.TabIndex = 3;
            this.lbl_player2Name.Text = "Jogador 2";
            // 
            // lbl_InsiraJogadores
            // 
            this.lbl_InsiraJogadores.AutoSize = true;
            this.lbl_InsiraJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InsiraJogadores.Location = new System.Drawing.Point(13, 9);
            this.lbl_InsiraJogadores.Name = "lbl_InsiraJogadores";
            this.lbl_InsiraJogadores.Size = new System.Drawing.Size(463, 37);
            this.lbl_InsiraJogadores.TabIndex = 4;
            this.lbl_InsiraJogadores.Text = "Insira os nomes dos Jogadores";
            // 
            // btn_Jogar
            // 
            this.btn_Jogar.Location = new System.Drawing.Point(176, 363);
            this.btn_Jogar.Name = "btn_Jogar";
            this.btn_Jogar.Size = new System.Drawing.Size(200, 72);
            this.btn_Jogar.TabIndex = 5;
            this.btn_Jogar.Text = "Jogar";
            this.btn_Jogar.UseVisualStyleBackColor = true;
            this.btn_Jogar.Click += new System.EventHandler(this.btn_Jogar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.btn_Jogar);
            this.Controls.Add(this.lbl_InsiraJogadores);
            this.Controls.Add(this.lbl_player2Name);
            this.Controls.Add(this.lbl_player1Name);
            this.Controls.Add(this.tb_player2Name);
            this.Controls.Add(this.tb_player1Name);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_player1Name;
        public System.Windows.Forms.TextBox tb_player2Name;
        private System.Windows.Forms.Label lbl_player1Name;
        private System.Windows.Forms.Label lbl_player2Name;
        private System.Windows.Forms.Label lbl_InsiraJogadores;
        private System.Windows.Forms.Button btn_Jogar;
    }
}