
using System;

namespace bvn
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] email = new string[3];
            string[] username = new string[3];
            string[] password = new string[3];

            

            //index 1
            email[0] = "kev@gmail.com";
            username[0] = "kev_1";
            password[0] = "dpass";

            //index 2
            email[1] = "frncs@gmail.com";
            username[1] = "frncs_05";
            password[1] = "passd";

            //index 3
            email[2] = "esg@gmail.com";
            username[2] = "esg_18";
            password[2] = "pasas";


            for (int i = 0; i < email.Length; i++)
            {
                Console.WriteLine($"Index: {i}");
                Console.WriteLine($"Email: {email[i]}");
                Console.WriteLine($"Username: {username[i]}");
                Console.WriteLine($"Password: {password[i]}");

                Console.WriteLine();
            }
        }
    }
}
