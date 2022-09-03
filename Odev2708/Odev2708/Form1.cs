using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Odev2708
{
    public partial class Form1 : Form
    {
        DataModel dataModel = new DataModel();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxisim.ValueMember = "ID";
            comboBoxisim.DisplayMember = "Isim";
            comboBoxSoyisim.ValueMember = "ID";
            comboBoxSoyisim.DisplayMember = "Soyisim";
            List<Kullanicilar> kullanici = dataModel.GetIsim();
            kullanici.Insert(0, new Kullanicilar { ID = 0, Isim = "İsim Seç", Soyisim = "Soyisim Seç"});
            comboBoxisim.DataSource = kullanici;
            comboBoxSoyisim.DataSource = kullanici;
        }
    }
}
