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
using System.Threading;

namespace NRT136_21BazaProjekta
{
    public partial class Najprodavanije : Form
    {
        List<K_Najprodavanije> listaNajprodavanijih;
        int y = 200;
        Task ta;
        bool prikazan = false;
        List<Label> labele;
        public Najprodavanije()
        {
            InitializeComponent();
            listaNajprodavanijih = new List<K_Najprodavanije>();
            labele = new List<Label>();
        }
        private void Najprodavanije_Load(object sender, EventArgs e)
        {
            ta = new Task(Animacija);
            ta.Start();
            listaNajprodavanijih = K_Najprodavanije.PopuniListuNajprodavanijih();
            PrikazNajprodavanijih();
            if(!prikazan)
            this.Paint += Crtanje;
        }
        public void PrikazNajprodavanijih()
        {
            y = 200;
            foreach (Label l in labele)
            {
                this.Controls.Remove(l);
            }
            labele.Clear();
            Random random = new Random();
            if(listaNajprodavanijih.Count <=0)
            {
                lblNajprodavanije.Text = "NIje bilo narudzbina u u tom vremensom periodu";
                return;
            }
            lblNajprodavanije.Text = listaNajprodavanijih[0].Naziv + " Kolicina : " + listaNajprodavanijih[0].Kolicina.ToString();
            foreach (K_Najprodavanije n in listaNajprodavanijih)
            {
                Label pom = new Label();
                pom.Font = new Font(lblNajprodavanije.Font.Name, 12);
                int r = random.Next(0, 255);
                int g = random.Next(0, 255);
                int b = random.Next(0, 255);
                Color boja = Color.FromArgb(r, g, b);
                pom.ForeColor = boja;
                pom.Location = new Point(50, y);
                y += 50;
                pom.Text = n.Naziv + " Kolicna : " + n.Kolicina;
                pom.Size = new Size(this.ClientSize.Width / 3, 20);
                this.Controls.Add(pom);
                pom.Show();
                n.Boja = boja;
                labele.Add(pom);
            }
        }

        private void Crtanje(object sender, PaintEventArgs e)
        {
            prikazan = true;
            Rectangle re = new Rectangle(this.ClientSize.Width/2, 250, 200, 200);
            float pocetniUgao = 0;
            int suma = K_Najprodavanije.Suma(listaNajprodavanijih);
            foreach (K_Najprodavanije n in listaNajprodavanijih)
            {
                float x = 360f * n.Kolicina / suma;
                SolidBrush cetka = new SolidBrush(n.Boja);
                e.Graphics.FillPie(cetka, re, pocetniUgao, x);
                pocetniUgao += x;
            }
        }

        public void Animacija()
        {
            int pom = 1;
            int velicinafonta = 12;
            while (true)
            {
               
                if (lblNajprodavanije.Font.Size > 15)
                    pom = -1;
                if (lblNajprodavanije.Font.Size < 7)
                    pom =1;
                velicinafonta += pom;
                lblNajprodavanije.Font = new Font(lblNajprodavanije.Font.Name,velicinafonta);
                Thread.Sleep(100);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string komanda = "SELECT  SUM(s.kolicina) AS Expr1, j.naziv"+
            " FROM((Stavka_racuna s INNER JOIN"+
            " Jelo j ON s.id_jelo = j.id_jelo) INNER JOIN"+
            " Racun r ON s.id_racun = r.id_racun)"+
            " WHERE(r.datum BETWEEN #"+dateOd.Value.Date+"# AND #"+dateDo.Value.Date+"#)"+
            " GROUP BY j.naziv"+
            " ORDER BY SUM(s.kolicina) DESC";
            listaNajprodavanijih = K_Najprodavanije.PopuniListuNajprodavanijih(komanda);
            PrikazNajprodavanijih();
            Invalidate();
            prikazan = true;
            if (!prikazan)
                this.Paint += Crtanje;

        }

        private void dateDo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateOd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
