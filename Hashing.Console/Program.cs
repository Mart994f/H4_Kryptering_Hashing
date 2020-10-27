using System;
using System.Data.SqlTypes;
using System.Text;

namespace Hashing.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            HashAlgorithms hash = new HashAlgorithms();
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
                        Console.Clear();
                        Console.WriteLine("SHA 1\r\n");
                        Console.Write("Input message: ");
                        string message = Console.ReadLine();
                        Console.WriteLine($"Hash: {Convert.ToBase64String(hash.ComputeHashSha1(Encoding.UTF8.GetBytes(message)))}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine("SHA 256\r\n");
                        Console.Write("Input message: ");
                        message = Console.ReadLine();
                        Console.WriteLine($"Hash: {Convert.ToBase64String(hash.ComputeHashSha256(Encoding.UTF8.GetBytes(message)))}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.WriteLine("SHA 384\r\n");
                        Console.Write("Input message: ");
                        message = Console.ReadLine();
                        Console.WriteLine($"Hash: {Convert.ToBase64String(hash.ComputeHashSha384(Encoding.UTF8.GetBytes(message)))}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        Console.WriteLine("SHA 512\r\n");
                        Console.Write("Input message: ");
                        message = Console.ReadLine();
                        Console.WriteLine($"Hash: {Convert.ToBase64String(hash.ComputeHashSha512(Encoding.UTF8.GetBytes(message)))}");
                        Console.WriteLine("Press [ENTER] to continue");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        Console.WriteLine("HMAC SHA 1");
                        HmacUI("SHA1");
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Console.Clear();
                        Console.WriteLine("HMAC SHA 256");
                        HmacUI("SHA256");
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        Console.Clear();
                        Console.WriteLine("HMAC SHA 384");
                        HmacUI("SHA384");
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        Console.Clear();
                        Console.WriteLine("HMAC SHA 512");
                        HmacUI("SHA512");
                        break;
                }
            }
        }

        public static void HmacUI(string algorithm)
        {
            HmacAlgorithms hmac = new HmacAlgorithms(algorithm);
            Console.WriteLine("\n[1] COMPUTE");
            Console.WriteLine("[2] VALIDATE");
            Console.Write("\r\nSELECT: ");
            ConsoleKeyInfo input = Console.ReadKey();


            switch (input.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Console.Write("Input Message: ");
                    string message = Console.ReadLine();
                    Console.Write("Input Key: ");
                    string key = Console.ReadLine();
                    byte[] macBytes = hmac.ComputeMAC(Encoding.UTF8.GetBytes(message), Encoding.UTF8.GetBytes(key));
                    Console.WriteLine($"\r\nMAC ASCII: {Convert.ToBase64String(macBytes)}");
                    Console.WriteLine($"MAC HEX: {BitConverter.ToString(macBytes).Replace("-", string.Empty)}");
                    Console.WriteLine("Press [ENTER] to continue");
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    Console.Write("Input Message: ");
                    message = Console.ReadLine();
                    Console.Write("Input Key: ");
                    key = Console.ReadLine();
                    Console.Write("Input Mac: ");
                    string mac = Console.ReadLine();
                    Console.WriteLine($"\r\nMAC IS VALID: {hmac.ValidateAuthenticity(Encoding.UTF8.GetBytes(message), Encoding.UTF8.GetBytes(mac), Encoding.UTF8.GetBytes(key))}");
                    Console.WriteLine("Press [ENTER] to continue");
                    Console.ReadLine();
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    break;
            }
        }
    }
}
