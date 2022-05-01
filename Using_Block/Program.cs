using System;
using System.IO;
namespace Using_Block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex001 - Maneira mais verbosa
            /*
            string path = @"C:\Users\marlo\teste001.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                string a = Console.ReadLine();
            }
            */

            //Ex002 - Maneira mais resumida com a instanciação utilizando a classe File
            string path = @"C:\Users\marlo\teste001.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                string a = Console.ReadLine();
            }
            
        }
    }
}
