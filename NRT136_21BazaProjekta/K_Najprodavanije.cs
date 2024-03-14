using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRT136_21BazaProjekta
{
    class K_Najprodavanije
    {
        private string naziv;
        private int kolicina;
        private Color boja;

        public K_Najprodavanije(string naziv, int kolicina)
        {
            this.naziv = naziv;
            this.kolicina = kolicina;
            this.Boja = Color.Black;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public Color Boja { get => boja; set => boja = value; }

        public static List<K_Najprodavanije> PopuniListuNajprodavanijih(string TekstKomande = "SELECT SUM(s.kolicina) AS Expr1, j.naziv" +
                 " FROM(Stavka_racuna s INNER JOIN" +
                 " Jelo j ON s.id_jelo = j.id_jelo)" +
                 " GROUP BY j.naziv" +
                 " ORDER BY SUM(s.kolicina) DESC")
        {
            List<K_Najprodavanije> lista = new List<K_Najprodavanije>();
            try
            {
                Konekcija.OtvoriKonekciju();
                OleDbCommand komanda = new OleDbCommand(TekstKomande, Konekcija.konekcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read())
                {
                    int kolcina = int.Parse(citac[0].ToString());
                    string naziv = citac[1].ToString();
                    K_Najprodavanije n = new K_Najprodavanije(naziv, kolcina);
                    lista.Add(n);
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
            return lista;
        }
        public static int Suma(List<K_Najprodavanije> lista)
        {
            int suma = 0;
            foreach (K_Najprodavanije n in lista)
                suma += n.kolicina;
            return suma;
        }
    }
}
