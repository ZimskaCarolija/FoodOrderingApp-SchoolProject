using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRT136_21BazaProjekta
{
    class Jelo
    {
        private int id_jelo;
        private string naziv;
        private int cena;

        public Jelo(int id_jelo, string naziv, int cena)
        {
            this.Id_jelo = id_jelo;
            this.Naziv = naziv;
            this.Cena = cena;
        }

        public int Id_jelo { get => id_jelo; set => id_jelo = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public int Cena { get => cena; set => cena = value; }

        public static List<Jelo> UcitajJela(string komandaStr = "SELECT * FROM Jelo")
        {
            List<Jelo> jela = new List<Jelo>();
            try
            {
                OleDbCommand komanda = new OleDbCommand(komandaStr);
                Konekcija.OtvoriKonekciju();

                komanda.Connection = Konekcija.konekcija;
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    int idpom = int.Parse(citac[0].ToString());
                    string nazivpom = citac[1].ToString();
                    int cenapom = int.Parse(citac[2].ToString());
                    Jelo j = new Jelo(idpom, nazivpom, cenapom);
                    jela.Add(j);
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

            return jela;
        }
        public static void PopuniListBoxNizomJela(ListBox listbox, List<Jelo> listaJela)
        {
            if (listaJela.Count <= 0)
            {
                listbox.Items.Clear();
                listbox.DataSource = null;
                return;
            }
            Dictionary<Jelo, string> recnik = new Dictionary<Jelo, string>();
            foreach (Jelo j in listaJela)
            {
                recnik.Add(j, j.Naziv + " Cena : " + j.Cena);
            }
            listbox.DataSource = new BindingSource(recnik, null);
            listbox.ValueMember = "Key";
            listbox.DisplayMember = "Value";
        }
        public static Jelo UzmiIzListaSaID(int id, List<Jelo> listaJela)
        {
            foreach (Jelo j in listaJela)
            {
                if (j.id_jelo == id)
                    return j;
            }
            return null;
        }
    }
}
