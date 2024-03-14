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
    public partial class Detaljnije : Form
    {
        public Detaljnije()
        {
            InitializeComponent();
        }

        private void Detaljnije_Load(object sender, EventArgs e)
        {

        }
        public void Ispisi(int idRacuna)
        {
            List<Racun> racuni = new List<Racun>();
            racuni = Racun.UcitajRacune("Select * from Racun where id_racun = " + idRacuna);
            string ZaPrikaz = "Racun  Datum :  " + racuni[0].Datum.ToString() + " Ukupna Cena Racuna : " + racuni[0].Ukupna_cena + Environment.NewLine +
                "Stavke racuna : "+Environment.NewLine;
           try
            {
                Konekcija.OtvoriKonekciju();
                string komandaString = "SELECT j.naziv,p.naziv , s.kolicina ,j.cena , p.cena" +
                " FROM Racun r,Stavka_racuna s, Jelo j , Prilog p" +
                " where  r.id_racun = " +idRacuna + "  and r.id_racun = s.id_racun and s.id_jelo = j.id_jelo and s.id_prilog = p.id_prilog";
                OleDbCommand komanda = new OleDbCommand(komandaString, Konekcija.konekcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                while(citac.Read())
                {
                    ZaPrikaz += "Naziv Jela : " + citac[0].ToString() + " Cena Jela : " + citac[3].ToString() + " Prilog Naziv : "+citac[1].ToString() + " Cena Priloga : "+
                   citac[4].ToString() + " Kolicina : " + citac[2].ToString() + " Ukupna cena jela : " +
                   (  (int.Parse(citac[3].ToString()) + int.Parse(citac[4].ToString()) ) * int.Parse(citac[2].ToString())  ) + Environment.NewLine;
                }
            }
            catch(Exception ex)
            {
                PorukaGreski.PrikaziPoruku(ex.Message);
            }
            finally
            {
                Konekcija.ZatvoriKonekciju();
            }

            textBox1.Text = ZaPrikaz;

        }
    }
}
