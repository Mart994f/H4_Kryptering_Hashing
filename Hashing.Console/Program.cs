using System;
using System.Text;

namespace Hashing.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            HmacAlgorithms hmac = new HmacAlgorithms();
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("HMAC Computer & Validater\r\n");

                Console.WriteLine("[1] SHA1");
                Console.WriteLine("[2] SHA256");
                Console.WriteLine("[3] SHA384");
                Console.WriteLine("[4] SHA512");
                Console.WriteLine("[5] HMACSHA1");
                Console.WriteLine("[6] HMACSHA256");
                Console.WriteLine("[7] HMACSHA384");
                Console.WriteLine("[8] HMACSHA512");
                Console.WriteLine("[0] EXIT\r\n");

                Console.Write("SELECT: ");

                ConsoleKeyInfo input = Console.ReadKey();

                if (input.Key == ConsoleKey.D0 || input.Key == ConsoleKey.NumPad0)
                    isRunning = false;

                switch (input.Key)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        ComputeHash(Console.ReadLine());
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        ComputeHash(Console.ReadLine());
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        ComputeHash(Console.ReadLine());
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        ComputeHash(Console.ReadLine());
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.WriteLine("HMACSHA 1\r\n");

                        Console.WriteLine("[1] COMPUTE");
                        Console.WriteLine("[2] VALIDATE");
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        break;
                }
            }
        }

        private static void ComputeHash(string message, )
        {
            HashAlgorithms hash = new HashAlgorithms();

            Console.Write("\r\nInput message: ");
            Console.Write("\r\nInput message: ");
            Console.WriteLine($"Hash: {Convert.ToBase64String(hash.ComputeHashSha512(Encoding.UTF8.GetBytes(message)))}");
            Console.WriteLine("Press [ENTER] to continue");
            Console.ReadLine();
        }
    }
}
