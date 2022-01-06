using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisOlustur frm = new SiparisOlustur();
            frm.MdiParent = this; // this demek = mdıform a denk geliyor. 
            frm.Show();
        }

        private void siparişBİlgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisBilgileri frm = new SiparisBilgileri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HamburgerEkle frm = new HamburgerEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void extraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtraMalzemeEkle frm = new ExtraMalzemeEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
