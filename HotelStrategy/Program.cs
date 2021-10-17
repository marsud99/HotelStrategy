using System;

namespace HotelStrategy
{
    class Program
    {




        static void Main(string[] args)
        {
            Client client = new ClientData().DataInput();


            switch (client.Origin)
            {
                case "0":
                    VerificareAmericani verificareAmericani = new VerificareAmericani();
                    verificareAmericani.verificaActe(client.Nume, client.Gen);
                    break;
                case "1":
                    VerificareEuropeni verificareEuropeni = new VerificareEuropeni();
                    verificareEuropeni.verificaActe(client.Nume, client.Gen);
                    break;
                case "2":
                    VerificareNonEU verificareNonEU = new VerificareNonEU();
                    verificareNonEU.verificaActe(client.Nume, client.Gen);
                    break;
            }
        }
    }
}
