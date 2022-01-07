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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }
        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu() {MenuAdi="Dana Carpaccio", Fiyati= 130},
            new Menu() { MenuAdi="Steak Tartar" , Fiyati=170},
            new Menu() { MenuAdi = "Lokum Burger", Fiyati=70}
        };
        public static List<Extra> ExtraMalzemeler = new List<Extra>()
        {
            new Extra(){ExtraAdi="Ranch Sos", Fiyati=5},
            new Extra(){ExtraAdi="Hardal Sos",Fiyati=5},
            new Extra(){ExtraAdi="BBQ Sos",Fiyati=5}
        };



        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            foreach (var menu in Menuler)
            {
                cbMenu.Items.Add(menu);
            }
           cbMenu.SelectedIndex = 0;

            foreach (var extra in ExtraMalzemeler)
            {
                flpExtraMalzeme.Controls.Add(new CheckBox() { Text = extra.ExtraAdi, Tag = extra });
            }
            foreach (Boyut item in Enum.GetValues(typeof(Boyut)))
            {
                flpBoyut.Controls.Add(new RadioButton() { Text = item.ToString(), Tag = item });
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
