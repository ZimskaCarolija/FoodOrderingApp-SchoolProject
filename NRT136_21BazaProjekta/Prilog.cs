using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRT136_21BazaProjekta
{
    class Prilog
    {
        private int id_prilog;
        private string naziv;
        private int cena;

        public Prilog(int id_prilog, string naziv, int cena)
        {
            this.Id_prilog = id_prilog;
            this.Naziv = naziv;
            this.Cena = cena;
        }

        public int Id_prilog { get => id_prilog; set => id_prilog = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public int Cena { get => cena; set => cena = value; }
        public static List<Prilog> UcitajPriloge(string komandaStr = "SELECT * FROM Prilog")
        {
            List<Prilog> prilozi = new List<Prilog>();
            try
            {
                OleDbCommand komanda = new OleDbCommand(komandaStr);
                Konekcija.OtvoriKonekciju();
                komanda.Connection = Konekcija.konekcija;
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    int id_prilog = int.Parse(citac[0].ToString());
                    string naziv = citac[1].ToString();
                    int cena = int.Parse(citac[2].ToString());
                    Prilog p = new Prilog(id_prilog, naziv, cena);
                    prilozi.Add(p);

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

            return prilozi;
        }
        public static Prilog UzmiIzListaSaID(int id, List<Prilog> listaPrilog)
        {
            foreach (Prilog j in listaPrilog)
            {
                if (j.id_prilog == id)
                    return j;
            }
            return null;
        }
        public static void PopuniListBoxNizomPriloga(ListBox listbox, List<Prilog> listaPriloga)
        {
            if (listaPriloga.Count <= 0)
            {
                listbox.Items.Clear();
                listbox.DataSource = null;
                return;
            }
            Dictionary<Prilog, string> recnik = new Dictionary<Prilog, string>();
            foreach (Prilog j in listaPriloga)
            {
                recnik.Add(j, j.Naziv + " Cena : " + j.Cena);
            }
            listbox.DataSource = new BindingSource(recnik, null);
            listbox.ValueMember = "Key";
            listbox.DisplayMember = "Value";
        }
    }
}
