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
    public partial class Form1 : Form
    {
        List<Jelo> jela = new List<Jelo>();
        List<Prilog> prilozi = new List<Prilog>();
        Jelo odabranoJelo;
        Prilog odabranPrilog;
        List<Stavka_racuna> stavkeRacuna = new List<Stavka_racuna>();
        int SelektovanaStavkaIndex = -1;
        public Form1()
        {
            InitializeComponent();
            PopuniComboBokseve();
        }
        private void PopuniComboBokseve()
        {
            cmbSortiraj.Items.Clear();
            Dictionary<int, string> recnik = new Dictionary<int, string>();
            recnik.Add(0, "Opadajuce po ceni");
            recnik.Add(1, "Rastuce po ceni");
            recnik.Add(2, "Opadajuce po nazivu");
            recnik.Add(3, "Rastuce po nazivu");
            cmbSortiraj.DataSource = new BindingSource(recnik, null);//Binding source dalje samo vise custom podatke prikaz i ivrednost itd
            cmbSortiraj.DisplayMember = "Value";
            cmbSortiraj.ValueMember = "Key";
            cmbSortiraj.SelectedIndex = 0;



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSortiraj.SelectedValue != null)
                FIltriraj();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jela = Jelo.UcitajJela();
            listBox1.DataSource = null;
            Jelo.PopuniListBoxNizomJela(listBox1, jela);
        }
        public void FIltriraj()
        {
            Dictionary<int, string> recnik = new Dictionary<int, string>();
            recnik.Add(0, " ORDER BY cena DESC");
            recnik.Add(1, " ORDER BY cena ASC");
            recnik.Add(2, " ORDER BY naziv DESC");
            recnik.Add(3, " ORDER BY naziv ASC");
            string nazivZaFIltriranje = "";
            if (txtNaziv.Text.Trim() != "")
            {
                nazivZaFIltriranje = " WHERE naziv LIKE '%" + txtNaziv.Text.Trim() + "%'";
            }
            string sort = "";
            if (recnik.TryGetValue(int.Parse(cmbSortiraj.SelectedValue.ToString()), out sort))//uzima vrenost iz comboboxa za selktovanje nacina sortiranj i po toj vrenoasti uzima iz drugog recnika ii ta vrednsot jej sql deo upita z a stortiranje
                jela = Jelo.UcitajJela("SELECT * FROM Jelo " + nazivZaFIltriranje + sort);
            Jelo.PopuniListBoxNizomJela(listBox1, jela);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FIltriraj();
        }

        private void cmbPrilozi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPrilozi.SelectedValue != null && cmbPrilozi.SelectedIndex >= 0)
                try
                {
                    odabranPrilog = (Prilog)cmbPrilozi.SelectedValue;
                }
                catch (Exception ex)
                { };
            CenaJela();
        }
        public void CenaJela()
        {
            int Cena = 0;
            if (odabranoJelo != null)
                Cena += odabranoJelo.Cena;
            if (odabranPrilog != null)
                Cena += odabranPrilog.Cena;
            lblCenaJela.Text = Cena.ToString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jelo j = null;
            try
            {
                j = (Jelo)listBox1.SelectedValue;
            }
            catch (Exception ex)
            {
                return;
            };
            odabranoJelo = j;
            lblNaziv.Text = j.Naziv + " Cena" + j.Cena;
            string komanda = "Select p.id_prilog , p.naziv, p.cena"
           + " FROm  Prilog p, Pripadnost pr "
          + "WHERE p.id_prilog = pr.Id_prilog " +
                "and pr.id_jelo = " + j.Id_jelo;
            prilozi = Prilog.UcitajPriloge(komanda);
            Dictionary<Prilog, string> recnik = new Dictionary<Prilog, string>();

            foreach (Prilog p in prilozi)
            {
                string tekst = p.Naziv + " " + p.Cena;
                recnik.Add(p, tekst);
            }
            cmbPrilozi.DataSource = new BindingSource(recnik, null);
            cmbPrilozi.DisplayMember = "Value";
            cmbPrilozi.ValueMember = "Key";
            CenaJela();
        }

        private void button2_Click(object sender, EventArgs e)//Dugme Klikni
        {
            if (odabranoJelo != null && odabranPrilog != null)
            {
                Stavka_racuna s = new Stavka_racuna(0, odabranoJelo.Id_jelo, odabranPrilog.Id_prilog, odabranoJelo.Cena, odabranPrilog.Cena, 1);
                if (!Stavka_racuna.PorveriPOsotjanjeStavke(s, stavkeRacuna))
                {
                    stavkeRacuna.Add(s);
                }
            }
            Stavka_racuna.PopuniListBoxNizomStavki(listBoxPOrudbina, stavkeRacuna, jela, prilozi);
            lblUkupnaCena.Text = Racun.IzracunajUkupnuCenuRacuna(stavkeRacuna).ToString();
        }

        private void btnOduzmi_Click(object sender, EventArgs e)
        {
            if (SelektovanaStavkaIndex < 0 || SelektovanaStavkaIndex > stavkeRacuna.Count)
                return;
            stavkeRacuna[SelektovanaStavkaIndex].Kolicina--;
            if (stavkeRacuna[SelektovanaStavkaIndex].Kolicina == 0)
            {
                stavkeRacuna.RemoveAt(SelektovanaStavkaIndex);
                SelektovanaStavkaIndex = -1;
            }
            Stavka_racuna.PopuniListBoxNizomStavki(listBoxPOrudbina, stavkeRacuna, jela, prilozi);
            lblUkupnaCena.Text = Racun.IzracunajUkupnuCenuRacuna(stavkeRacuna).ToString();
        }

        private void listBoxPOrudbina_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelektovanaStavkaIndex = listBoxPOrudbina.SelectedIndex;
        }

        private void button3_Click(object sender, EventArgs e)//dugme kupi
        {
            if (stavkeRacuna == null)
            {
                MessageBox.Show("Morate uneti bar jednu stavku!!");
                return;
            }
            int ukupna = Racun.IzracunajUkupnuCenuRacuna(stavkeRacuna);
            if (ukupna < 0)
            {
                MessageBox.Show("Greska ukupna cena je manja od 0");
            }
            if (Racun.UpisiNoviRacun(ukupna))
            {
                int IdRacuna = Racun.ZadnjiUpisanRacun();
                if (IdRacuna < 0)
                {
                    MessageBox.Show("Greska id racuna je negativan");
                    return;
                }
                foreach (Stavka_racuna stavka in stavkeRacuna)
                {
                    stavka.UpisiStavku(IdRacuna);
                }
                listBoxPOrudbina.DataSource = null;
                MessageBox.Show("Uspesno ste poruzicli");
                lblUkupnaCena.Text = "0";
                stavkeRacuna.Clear();
                stavkeRacuna = null;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
