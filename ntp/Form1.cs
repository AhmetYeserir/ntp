using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ntp.Models;

namespace ntp
{
    public partial class Form1 : Form
    {
        ntpEntitiesConnectionDb db = new ntpEntitiesConnectionDb();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static int Id;
        private void button1_Click(object sender, EventArgs e)
        {
         var Durum = db.PersonelGirisTablosu.FirstOrDefault(x => x.MailAdress == textBox1.Text && x.Password == textBox2.Text);
            if (Durum != null)
            {
                Id = Durum.Id;
                GirisBasarili gb = new GirisBasarili();
                gb.ShowDialog();
            }
        else
            {
                MessageBox.Show("Girilen bilgiler gerçeğiyle uyuşmamaktadır", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreTazele st = new SifreTazele ();
            st.ShowDialog();
        }
    }
}
