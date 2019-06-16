using File.Create.Business;
using System;
using System.IO;

namespace File.IncludeLine
{
    public class Program
    {
        public static void Main()
        {
            #region Include a new line in a file
            
            const string path = @"C:\Temp";
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Product product = new Product();
            
            // Counter to show the final amount of files which have lines included
            int counter = 0;

            foreach (FileInfo item in files)
            {
                foreach (Product p in product.List())
                {
                    string text = System.IO.File.ReadAllText(path + @"\" + item.Name);
                    text = text.Replace($@"Ilocation:                           0.155 0.155 {p.Size1 - (0.155 * 2)} {p.Size2 - (0.155 * 2)}",
                                        $@"Ilocation:                           0.19 0.19 {p.Size1 - (0.19 * 2)} {p.Size2 - (0.19 * 2)}");

                    System.IO.File.WriteAllText(path + @"\" + item.Name, text);
                }

                // Increase the counter
                counter++;
            }

            Console.WriteLine(counter == 1 ? "1 file has been edited." : $"{counter} files have been edited.");

            #endregion

            Console.WriteLine("Press <Enter> to exit...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}