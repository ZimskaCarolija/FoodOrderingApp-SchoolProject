using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NRT136_21BazaProjekta
{
    public partial class DodavanjeJela : Form
    {
        List<Prilog> sviPrilozi;
        List<Prilog> dodatiPrilozi;
        public DodavanjeJela()
        {
            InitializeComponent();
            sviPrilozi = new List<Prilog>();
            dodatiPrilozi = new List<Prilog>();
            
        }

        private void DodavanjeJela_Load(object sender, EventArgs e)
        {
            sviPrilozi = Prilog.UcitajPriloge();
            Dictionary<Prilog, string> recnik = new Dictionary<Prilog, string>();

            foreach (Prilog p in sviPrilozi)
            {
                string tekst = p.Naziv + " " + p.Cena;
                recnik.Add(p, tekst);
            }
            comboBox1.DataSource = new BindingSource(recnik, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            if(sviPrilozi.Count!=0)
            dodatiPrilozi.Add(sviPrilozi[0]);
            else
            {
                MessageBox.Show("Greska prilozi su prazni");
                this.Close();
            }
        UpdejtujDodate();

        }
        public void UpdejtujDodate()
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            Prilog.PopuniListBoxNizomPriloga(listBox1, dodatiPrilozi);
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Prilog prilog = (Prilog)comboBox1.SelectedValue;
                if(dodatiPrilozi.Contains(prilog))
                {
                    MessageBox.Show("Vec ste dodali ovaj prilog");
                    return;
                }
                dodatiPrilozi.Add(prilog);
                UpdejtujDodate();
            }
            catch(Exception ex)
            {
                PorukaGreski.PrikaziPoruku(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue == null || listBox1.SelectedIndex == -1)
                return;
            Prilog p = (Prilog)listBox1.SelectedValue;
            if (p.Id_prilog == 1)
            {
                MessageBox.Show("Ovu stavku nemozete da obrisete");
                return;
            }
            dodatiPrilozi.Remove(p);
            UpdejtujDodate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNaziv.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti naziv jela");
                return;
            }
            int cena = 0;
            if (!int.TryParse(txtCena.Text,out cena))
             {
                MessageBox.Show("Morate uneti broj za cenu");
                return;
            }
            if(cena<=0)
            {
                MessageBox.Show("Cena mora biti veca od 0");
                return;
            }
            try
            {
                Konekcija.OtvoriKonekciju();
                string Tekstkomande = "Insert into Jelo (naziv,cena) values ('" + txtNaziv.Text + "'," + cena + ");";
                OleDbCommand komanda = new OleDbCommand(Tekstkomande, Konekcija.konekcija);
                komanda.ExecuteNonQuery();
                string TekstkomandeId = "Select max(id_jelo) from Jelo";
                OleDbCommand komandaId = new OleDbCommand(TekstkomandeId, Konekcija.konekcija);
                OleDbDataReader citac = komandaId.ExecuteReader();
                citac.Read();
                int id = int.Parse(citac[0].ToString());
                foreach(Prilog p in dodatiPrilozi)
                {
                    string TekstKomandePrilog = "Insert into Pripadnost values(" + id + "," + p.Id_prilog + ")";
                    OleDbCommand komandaPrilog = new OleDbCommand(TekstKomandePrilog, Konekcija.konekcija);
                    komandaPrilog.ExecuteNonQuery();

                }
                MessageBox.Show("Uspesno ste dodali jelo!");
            }
            catch(Exception ex)
            {
                PorukaGreski.PrikaziPoruku(ex.Message);
            }
            finally
            {
                Konekcija.ZatvoriKonekciju();
            }
        }
    }
}
