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
    public partial class GirisBasarili : Form
    {
        ntpEntitiesConnectionDb db = new ntpEntitiesConnectionDb();
        public GirisBasarili()
        {
            InitializeComponent();
        }

        private void GirisBasarili_Load(object sender, EventArgs e)
        {
            label1.Text = $@"Hoş Geldiniz. Sayın {db.PersonelGirisTablosu.FirstOrDefault(x => x.Id == Form1.Id).FirstName}
              { db.PersonelGirisTablosu.FirstOrDefault(x => x.Id == Form1.Id).LastName}";
        }
    }
}
