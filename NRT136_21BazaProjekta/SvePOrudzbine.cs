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
    public partial class SvePOrudzbine : Form
    {
        List<Racun> racuni;
        public SvePOrudzbine()
        {
            InitializeComponent();
            racuni = new List<Racun>();
        }

        private void SvePOrudzbine_Load(object sender, EventArgs e)
        {
            racuni = Racun.UcitajRacune();
            Racun.PopuniListBoxNizomRacuna(listBox1, racuni);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Racun> racuniFIltrirani = new List<Racun>(racuni);
            for(int i =0;i<racuniFIltrirani.Count;i++)
            {
                if(racuniFIltrirani[i].Datum.Date < dateOd.Value.Date || racuniFIltrirani[i].Datum.Date>dateDo.Value.Date)
                {
                    racuniFIltrirani.RemoveAt(i);
                        i--;
                }
            }
            Racun.PopuniListBoxNizomRacuna(listBox1, racuniFIltrirani);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Racun racun = (Racun)listBox1.SelectedValue;
            Detaljnije dt = new Detaljnije();
            dt.Ispisi(racun.Id_racun);
            dt.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
