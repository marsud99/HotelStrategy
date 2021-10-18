using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStrategy
{
    public class VerificareNonEU : IModVerificare
    {
        public void verificaActe(string nume, string gender,string origin)
        {

            if (gender.ToLower() == "male")
                Console.WriteLine("Verifying passport for mister " + nume);
            else
                Console.WriteLine("Verifying passport for miss " + nume);

        }
    }
}
