using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelStrategy
{
    public class VerificareAmericani : IModVerificare
    {
        public void verificaActe(string nume,string gender)
           {
            
            if(gender.ToLower() == "male")
            Console.WriteLine("Verifying visa for mister " + nume);
            else
                Console.WriteLine("Verifying visa for miss " + nume);

        }
    }
}
