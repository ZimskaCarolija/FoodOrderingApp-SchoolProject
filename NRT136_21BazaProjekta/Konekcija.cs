using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRT136_21BazaProjekta
{
    class Konekcija
    {
        private static string konekcioniString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Aleksa\Desktop\Restoran.accdb";
        public static OleDbConnection konekcija = new OleDbConnection(konekcioniString);

        public static void OtvoriKonekciju()
        {
            if (konekcija != null)
                konekcija.Open();
        }
        public static void ZatvoriKonekciju()
        {
            if (konekcija != null)
                konekcija.Close();
        }
    }
}
