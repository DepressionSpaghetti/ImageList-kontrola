using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList_kontrola
{
    public partial class Form1 : Form
    {
        public int brojac = 1;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];
        }
        
        private void btnPromjeni_Click(object sender, EventArgs e)
        {
            if(brojac % 2 == 0) pictureBox1.Image = imageList1.Images[0];
                else pictureBox1.Image = imageList1.Images[1];
            brojac++;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
