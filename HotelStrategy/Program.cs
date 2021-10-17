using System;

namespace HotelStrategy
{
    class Program
    {
        

        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello! To proceed further I require your name and gender: \n");
            var name = Console.ReadLine();
            var gender = Console.ReadLine();
            if (gender.ToLower() != "male" && gender.ToLower() != "female")
                throw new Exception("Gender not recognised");
            Console.WriteLine("Please select one of the following numbers based on your provenance" +
            "\n 0 - America" +
            "\n 1 - Europe" +
            "\n 2 - NonEU \n");
            var destination = Console.ReadLine();
            if (destination != "0" && destination != "1" && destination != "2")
                throw new Exception("Provenance not valid!");
            Client client = new Client()
            { 
                  Nume = name,
                  Gen = gender
            };

            switch (destination)
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
