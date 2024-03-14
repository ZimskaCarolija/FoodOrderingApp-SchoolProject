using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRT136_21BazaProjekta
{
    public partial class Pocetna : Form
    {
        Form Aktivna;
        public Pocetna()
        {
            InitializeComponent();
            Aktivna = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Promeni(new Form1());
        }
        public void Promeni(Form forma)
        {
            if (Aktivna != null)
                Aktivna.Close();
           
            Aktivna = forma;
            Aktivna.TopLevel = false;
            PanelSadrzaj.Controls.Add(Aktivna);
            Aktivna.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Aktivna.Dock = DockStyle.Fill;
            Aktivna.Show();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            Promeni(new Form1());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Promeni(new SvePOrudzbine());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Promeni(new DodavanjeJela());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Promeni(new Najprodavanije());
        }
    }
}
