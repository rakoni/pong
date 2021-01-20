using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void novoJogo2v2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formAjuda = new Form3();
            formAjuda.Closed += (s, args) => this.Close();
            formAjuda.Show();
        }

        private void lbl_newGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formNomeJogadores = new Form4();
            formNomeJogadores.Closed += (s, args) => this.Close();
            formNomeJogadores.Show();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
