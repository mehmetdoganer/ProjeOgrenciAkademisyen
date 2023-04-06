using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ogrenci_Akademisyen.Formlar
{
    public partial class FrmHarita : Form
    {
        public FrmHarita()
        {
            InitializeComponent();
        }

        private void PnlBolumListesi_Click(object sender, EventArgs e)
        {
            FrmBolumListesi fr = new FrmBolumListesi();
            fr.Show();  
        }

        private void PnlYeniBölüm_Click(object sender, EventArgs e)
        {
            FrmBolumler ft = new FrmBolumler();
            ft.Show();
        }

        private void PnlNotlar_Click(object sender, EventArgs e)
        {
            FrmNotlar frm = new FrmNotlar();
            frm.Show();
        }

        private void PnlOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr = new FrmOgrenci();
            fr.Show();
        }

        private void PnlOgrenciKayit_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayit fr = new FrmOgrenciKayit(); 
            fr.Show();
        }

        private void PnlDersListesi_Click(object sender, EventArgs e)
        {
            FrmDersListesi fr = new FrmDersListesi();   
            fr.Show();
        }

        private void PnlYardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje turkcell geleceği yazanlar eğitimi kapsamında hazırlanmıştır. Müfredatın son projesinde şuana kadar öğrendiklerimizi veritanlı proje hazırlamaktır.Projemizde akademisyen için kullanıcı ad : 00000 şifre: 000 şeklindedir. Sisteme giriş yapan öğrenci sadece kendi notlarını görüntüler.", "Yardım Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PnlYeniDers_Click(object sender, EventArgs e)
        {
            FrmYeniDers fr = new FrmYeniDers();
            fr.Show();

        }

        private void PnlCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
