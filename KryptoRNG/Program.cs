using System.Security.Cryptography;
using System.Security.Cryptography;

Console.WriteLine("RNG with cryptology.");
using (var cryptyRng = RandomNumberGenerator.Create())
{
    for (int i = 0; i < 10; i++)
    {
        DateTime startTime = DateTime.Now;
        byte[] data = new byte[4];
        cryptyRng.GetBytes(data);
        DateTime endTime = DateTime.Now;
        Console.Write("Time: {0}: ", endTime - startTime);
        int value = BitConverter.ToInt32(data, 0);
        Console.WriteLine(value);
    }
}
Console.WriteLine("RNG with Random");
for (int i = 0; i < 10; i++)
{
    Random rndRng = new Random();
    DateTime startTime = DateTime.Now;
    byte[] data = new byte[4];
    int value = rndRng.Next(1000000, 9999999);
    DateTime endTime = DateTime.Now;
    Console.Write("Time: {0}: ", endTime - startTime);
    Console.WriteLine(value);
}