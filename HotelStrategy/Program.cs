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
            var origin = Console.ReadLine();
            if (origin != "0" && origin != "1" && origin != "2")
                throw new Exception("Provenance not valid!");

            
            switch (origin)
            {
                case "0":
                     new Client(new VerificareAmericani()).VerificaActe(name, gender, origin);
                    break;
                case "1":
                    new Client(new VerificareEuropeni()).VerificaActe(name, gender, origin);
                    break;
                case "2":
                    new Client(new VerificareNonEU()).VerificaActe(name, gender, origin);

                    break;
            }
        }
    }
}
