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
    public partial class Form1 : Form
    {
        public int p1Voitot=0;
        public int p2Voitot=0;
        public int ypParit=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 muistipeli = new Form2(cbVaikeustaso.Text, cbPelaajat.Text, cbAihe.Text, this);
            muistipeli.ShowDialog();
        }

        private void btnTilastot_Click(object sender, EventArgs e)
        {
            Form3 tilastot = new Form3(p1Voitot, p2Voitot, ypParit);
            tilastot.ShowDialog();
        }
    }
}
