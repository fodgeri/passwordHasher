using System;

namespace PasswordHasher
{
    class Program
    {
        static void Main(string[] args)
        {
            var hash = SecurePasswordHasher.Hash("<Your Password>");

            Console.WriteLine($"Hash: {hash}");

            // Verify
            var result = SecurePasswordHasher.Verify("<Your Password>", hash);

            Console.WriteLine($"Result: {result}");
        }
    }
}
