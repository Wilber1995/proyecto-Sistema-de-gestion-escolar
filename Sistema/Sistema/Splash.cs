using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int n = 0;
        private void Principal_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            n++;
            label2.Text = n.ToString();
            progressBar1.Value = n;
            if(n==100)
            {
                this.Hide();
                timer1.Stop();
                Menu menu = new Menu();
                menu.Show();


            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
