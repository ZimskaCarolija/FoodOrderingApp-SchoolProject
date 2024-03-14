using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRT136_21BazaProjekta
{
    class Pripadnost
    {
        private int id_jelo;
        private int id_prilog;

        public Pripadnost(int id_jelo, int id_prilog)
        {
            this.Id_jelo = id_jelo;
            this.Id_prilog = id_prilog;
        }

        public int Id_jelo { get => id_jelo; set => id_jelo = value; }
        public int Id_prilog { get => id_prilog; set => id_prilog = value; }
    }
}
