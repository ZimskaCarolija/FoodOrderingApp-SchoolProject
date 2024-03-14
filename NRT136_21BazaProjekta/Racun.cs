using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRT136_21BazaProjekta
{
    class Racun
    {
        private int id_racun;
        private int ukupna_cena;
        private DateTime datum;

        public Racun(int id_racun, int ukupna_cena, DateTime datum)
        {
            this.Id_racun = id_racun;
            this.Ukupna_cena = ukupna_cena;
            this.Datum = datum;
        }

        public int Id_racun { get => id_racun; set => id_racun = value; }
        public int Ukupna_cena { get => ukupna_cena; set => ukupna_cena = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public static int IzracunajUkupnuCenuRacuna(List<Stavka_racuna> stavke)
        {
            int ukupno = 0;
            foreach (Stavka_racuna s in stavke)
            {
                ukupno += s.CenaStavke();
            }
            return ukupno;
        }
        public static bool UpisiNoviRacun(int UkupnaCena)
        {
            try
            {
                Konekcija.OtvoriKonekciju();
                string TekstKonade = "Insert into Racun(ukupna_cena,datum) values(" + UkupnaCena + ",'" + DateTime.Now + "')";
                OleDbCommand komanda = new OleDbCommand(TekstKonade, Konekcija.konekcija);
                komanda.ExecuteNonQuery();
                PorukaGreski.PrikaziPoruku("Uspesno upisan racun");
                return true;
            }
            catch (Exception ex)
            {
                PorukaGreski.PrikaziPoruku("Greska prilikom Upisivanja racuna" + ex.Message);
                return false;
            }
            finally
            {

                Konekcija.ZatvoriKonekciju();
            }
        }
        public static int ZadnjiUpisanRacun()
        {
            try
            {
                Konekcija.OtvoriKonekciju();
                string TekstKonade = "Select max(id_racun) from Racun";
                OleDbCommand komanda = new OleDbCommand(TekstKonade, Konekcija.konekcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                citac.Read();
                return int.Parse(citac[0].ToString());
            }
            catch (Exception ex)
            {
                PorukaGreski.PrikaziPoruku("Greska prilokom upisivanja novog racuna " + ex.Message);
                return -1;
            }
            finally
            {

                Konekcija.ZatvoriKonekciju();
            }
        }
        public static List<Racun> UcitajRacune(string komandaStr = "SELECT * FROM Racun")
        {
            List<Racun> racuni = new List<Racun>();
            try
            {
                OleDbCommand komanda = new OleDbCommand(komandaStr);
                Konekcija.OtvoriKonekciju();
                komanda.Connection = Konekcija.konekcija;
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    int id_jela = int.Parse(citac[0].ToString());
                    int cena = int.Parse(citac[1].ToString());
                    DateTime datum = DateTime.Parse(citac[2].ToString());
                    Racun r = new Racun(id_jela, cena,datum);
                    racuni.Add(r);

                }
            }
            catch (Exception ex)
            {
                PorukaGreski.PrikaziPoruku(ex.Message);

            }
            finally
            {
                Konekcija.ZatvoriKonekciju();
            }

            return racuni;
        }
        public static void PopuniListBoxNizomRacuna(ListBox listbox, List<Racun> listaRacuna)
        {
            if (listaRacuna.Count <= 0)
            {
                listbox.Items.Clear();
                listbox.DataSource = null;
                return;
            }
            Dictionary<Racun, string> recnik = new Dictionary<Racun, string>();
            foreach (Racun j in listaRacuna)
            {
                recnik.Add(j, j.datum + " Cena : " + j.ukupna_cena);
            }
            listbox.DataSource = new BindingSource(recnik, null);
            listbox.ValueMember = "Key";
            listbox.DisplayMember = "Value";

        }

    }
}
