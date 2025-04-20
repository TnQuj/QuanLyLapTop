using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLapTop.Forms
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2;
            if (progressBar1.Value == 100)
                this.Dispose();
            if (progressBar1.Value > 80)
                this.Opacity -= 0.05;
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Wheat;
            this.BackColor = Color.Wheat;
        }
    }
}
