using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRT136_21BazaProjekta
{
    class PorukaGreski
    {
        public static void PrikaziPoruku(string poruka)//pusta messagebox u posebnoj s eklasi nalazi da ne bi se u usvakoj klasi prikljuvalo system.windows.form
        {
            MessageBox.Show("Greska : " + poruka);
        }
    }
}
