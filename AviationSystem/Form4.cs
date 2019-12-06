using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (drawer.Visible) {
                thide.HideSync(drawer);
            }
            else
            {
                tshow.ShowSync(drawer);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void render_doughnut_Click(object sender, EventArgs e)

        {

          

        }

        private void bunifuCards1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("WHHHHHHHHHAAAAAAAAAAAAAAAAAAAAAAAAAT");
            Form1 fr = new Form1();
            fr.ShowDialog();
            
        }

        private void bunifuDataViz1_Load(object sender, EventArgs e)
        {

        }
    }
}
