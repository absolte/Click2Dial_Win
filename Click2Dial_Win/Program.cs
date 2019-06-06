using System;
using System.IO;



namespace Click2Dial_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path + @"\test.txt"))
                {
                    // Pass the phone number through cmd args to C# for text file.
                    foreach (var arg in args)
                    {
                        sw.WriteLine(arg);
                    }
                }
            }
        

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path + @"\test.txt"))
            {
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    System.Environment.Exit(1);
                }
            }
        }
    }
}

