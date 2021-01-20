namespace Pong
{
    partial class Form2
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
            this.lbl_newGame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_newGame
            // 
            this.lbl_newGame.AutoSize = true;
            this.lbl_newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newGame.Location = new System.Drawing.Point(270, 276);
            this.lbl_newGame.Name = "lbl_newGame";
            this.lbl_newGame.Size = new System.Drawing.Size(198, 42);
            this.lbl_newGame.TabIndex = 1;
            this.lbl_newGame.Text = "Novo Jogo";
            this.lbl_newGame.Click += new System.EventHandler(this.lbl_newGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajuda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_sair
            // 
            this.lbl_sair.AutoSize = true;
            this.lbl_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sair.Location = new System.Drawing.Point(329, 414);
            this.lbl_sair.Name = "lbl_sair";
            this.lbl_sair.Size = new System.Drawing.Size(62, 31);
            this.lbl_sair.TabIndex = 3;
            this.lbl_sair.Text = "Sair";
            this.lbl_sair.Click += new System.EventHandler(this.lbl_sair_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 640);
            this.Controls.Add(this.lbl_sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_newGame);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(758, 758);
            this.MinimumSize = new System.Drawing.Size(678, 678);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_newGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sair;
    }
}