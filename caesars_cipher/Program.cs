using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caesars_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceasar cipher encrypter/decryter");
            bool goOn = false;
            string encrypted = "";
            Crpt crypt = new Crpt();
            while (true)
            {
                Console.WriteLine("1 do encrypt || 2 to decrypt");
                string option = Console.ReadLine();
                if (option == "1" || option == "2")
                {
                    goOn = true;
                }
                if (!goOn)
                {
                    Environment.Exit(0);
                }
                else if (option == "1")
                {
                    Console.WriteLine("Type word/s to encrypt");
                    encrypted = crypt.Encrypt(Console.ReadLine());
                    Console.WriteLine(encrypted);
                    Console.WriteLine("press c to continue, d to decrypt, any other to exit");
                    option = Console.ReadLine();
                }else if(option == "2")
                {
                    Console.WriteLine("Type word/s to dencrypt");
                    encrypted = Console.ReadLine();
                    Console.WriteLine(crypt.Decrypt(encrypted));
                    Console.WriteLine("press c to continue, any other to exit");
                    encrypted = "";
                    option = Console.ReadLine();
                }
                if (option == "d" && encrypted != "")
                {
                    Console.WriteLine(crypt.Decrypt(encrypted));
                    Console.WriteLine("press c to continue, any other to exit");
                    option = Console.ReadLine();
                }
                if (option != "c")
                {
                    Environment.Exit(0);
                }
            }    
        }
        
    }
    class Crpt
    {
        public string Encrypt(string message)
        {
            string encrypted = "";
            char[] raw = message.ToCharArray();
            foreach (char item in raw)
            {
                if (Char.IsWhiteSpace(item))
                {
                    encrypted += " ";
                }
                else
                {
                    int kkk = item + 13;
                    char dong = Convert.ToChar(kkk);
                    encrypted += dong.ToString();
                }   
            }
            return encrypted;
        }

        public string Decrypt(string message)
        {
            string decrypted = "";
            char[] raw = message.ToCharArray();
            foreach (char item in raw)
            {
                if (Char.IsWhiteSpace(item))
                {
                    decrypted += " ";
                }
                else
                {
                    int kkk = item - 13;
                    char dong = Convert.ToChar(kkk);
                    decrypted += dong.ToString();
                }
            }
            return decrypted;
        }
    }
}
