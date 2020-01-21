using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class Form3 : Form
    {
        public Form3(int p1Voitot, int p2Voitot, int ypParit)
        {
            InitializeComponent();
            labelP1voitot.Text = "Pelaajan 1 voitot: " + p1Voitot;
            labelP2voitot.Text = "Pelaajan 2 voitot: " + p2Voitot;
            labelYPParit.Text = "Yksinpeli parit: " + ypParit;
        }

        private void btnTakaisin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
