using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace readingTextFiles
{
    class Program
    {
        public static void read(string path)
        {
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
        static void Main(string[] args)
        {
            read("c:/data.txt");
            Console.ReadLine();
        }
    }
}
