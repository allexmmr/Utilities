using System;
using System.Text;

namespace Text.Convert
{
    public class Program
    {
        public static void Main(string[] args)
        {
            byte[] data = FromHex("47-61-74-65-77-61-79-53-65-72-76-65-72");
            Console.WriteLine("Converting from hex to string:");
            Console.WriteLine(Encoding.ASCII.GetString(data));

            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
            }
        }

        #region Converting from hex to string

        /// <summary>
        /// Converting from hex to string
        /// </summary>
        /// <param name="hex">Hex</param>
        /// <returns>String from hex</returns>
        public static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = System.Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }

            return raw;
        }

        #endregion
    }
}