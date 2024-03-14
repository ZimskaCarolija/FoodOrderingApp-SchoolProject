using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRT136_21BazaProjekta
{
    class Stavka_racuna
    {
        private int id_racun;
        private int id_jelo;
        private int id_prilog;
        private int cenaJelo;
        private int cenaPrilog;
        private int kolicina = 1;
        public Stavka_racuna(int id_racun, int id_jelo, int id_prilog, int cenaJelo, int cenaPrilog, int kolicina = 1)
        {
            this.Id_racun = id_racun;
            this.Id_jelo = id_jelo;
            this.Id_prilog = id_prilog;
            this.CenaJelo = cenaJelo;
            this.CenaPrilog = cenaPrilog;
            this.kolicina = kolicina;
        }

        public int Id_racun { get => id_racun; set => id_racun = value; }
        public int Id_jelo { get => id_jelo; set => id_jelo = value; }
        public int Id_prilog { get => id_prilog; set => id_prilog = value; }
        public int CenaJelo { get => cenaJelo; set => cenaJelo = value; }
        public int CenaPrilog { get => cenaPrilog; set => cenaPrilog = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public static bool PorveriPOsotjanjeStavke(Stavka_racuna stavka, List<Stavka_racuna> stavke)//proverava dali posotji data stavka  uu racunu i iako postoji povecava kolicinu te z a1 i vraca true u ostalim slucajevima vraca false
        {
            bool Vracanje = false;
            foreach (Stavka_racuna s in stavke)
            {
                if (s.id_jelo == stavka.id_jelo && s.id_prilog == stavka.id_prilog)
                {
                    s.kolicina++;
                    return true;
                }


            }
            return Vracanje;
        }
        public static void PopuniListBoxNizomStavki(ListBox listbox, List<Stavka_racuna> stavke_Racuna, List<Jelo> listaJela, List<Prilog> listaPriloga)
        {
            Dictionary<Stavka_racuna, string> recnik = new Dictionary<Stavka_racuna, string>();
            foreach (Stavka_racuna j in stavke_Racuna)
            {
                Jelo jelo = Jelo.UzmiIzListaSaID(j.id_jelo, listaJela);
                Prilog prilog = Prilog.UzmiIzListaSaID(j.id_prilog, listaPriloga);
                if (jelo != null && prilog != null)
                    recnik.Add(j, jelo.Naziv + " Cena Jela : " + jelo.Cena + " Prilog : " + prilog.Naziv + " Cena : " + prilog.Cena + " Kolicina : " + j.kolicina + " Cena Stavke : " + j.CenaStavke());
            }
            listbox.DataSource = null;
            if (stavke_Racuna.Count() == 0)
                return;
            listbox.DataSource = new BindingSource(recnik, null);
            listbox.ValueMember = "Key";
            listbox.DisplayMember = "Value";

        }
        public int CenaStavke()
        {
            return (this.cenaJelo + this.cenaPrilog) * kolicina;
        }
        public void UpisiStavku(int id_racuna)
        {
            try
            {
                Konekcija.OtvoriKonekciju();
                string tekstKomande = "Insert into Stavka_racuna(id_racun, id_jelo, id_prilog, cenaJelo, cenaPrilog,kolicina)" +
                    " values(" + id_racuna + "," + id_jelo + "," + id_prilog + "," + cenaJelo + "," + cenaPrilog + "," + kolicina + ")";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, Konekcija.konekcija);
                komanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                PorukaGreski.PrikaziPoruku("Greska prilikom unosa stavki racuna " + ex.Message);
            }
            finally
            {
                Konekcija.ZatvoriKonekciju();
            }
        }
        public static List<Stavka_racuna> UcitajStavke(string komandaStr = "SELECT * FROM Stavka_racuna")
        {
            List<Stavka_racuna> stavke = new List<Stavka_racuna>();
            try
            {
                OleDbCommand komanda = new OleDbCommand(komandaStr);
                Konekcija.OtvoriKonekciju();
                komanda.Connection = Konekcija.konekcija;
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    int id_racuna = int.Parse(citac[0].ToString());
                    int id_jela = int.Parse(citac[1].ToString());
                    int id_jpriloga = int.Parse(citac[2].ToString());
                    int cena_Jela = int.Parse(citac[3].ToString());
                    int cenaPriloga = int.Parse(citac[4].ToString());
                    int kolicina = int.Parse(citac[5].ToString());
                    Stavka_racuna r = new Stavka_racuna(id_racuna,id_jela,id_jpriloga,cena_Jela,cenaPriloga,kolicina);
                    stavke.Add(r);

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

            return stavke;
        }
    }
}
