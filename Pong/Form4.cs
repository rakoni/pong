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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_Jogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formNovoJogo = new Form1();
            formNovoJogo.f4 = this;
            formNovoJogo.Closed += (s, args) => this.Close();
            formNovoJogo.Show();
        }
    }
}
