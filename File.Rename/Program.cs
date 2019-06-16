using System;
using System.IO;

namespace File.Rename
{
    public class Program
    {
        public static void Main()
        {
            const string path = @"C:\Temp";
            const string oldValue = "-min";
            const string newValue = "";

            #region Renaming filenames

            // Counter to show the final amount of files which have lines included
            int counter = 0;

            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo item in files)
            {
                System.IO.File.Move(item.FullName, item.FullName.Replace(oldValue, newValue));
                
                // Increase the counter
                counter++;
            }

            Console.WriteLine(counter == 1 ? "1 file has been renamed." : $"{counter} files have been renamed.");

            #endregion

            Console.WriteLine("Press <Enter> to exit...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}