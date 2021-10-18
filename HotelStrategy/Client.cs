using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStrategy
{
    public class Client
    {

        public IModVerificare modVerificare;
        public Client(IModVerificare modVerificare)
        {
            this.modVerificare = modVerificare;
        }
        public string Nume { get; set; }

        public string Gen { get; set; }

        public string Origin { get; set; }

        public void VerificaActe(string Nume, string Gen, string Origin)
        {
            modVerificare.verificaActe(Nume, Gen, Origin);
        }
        

    }
}
