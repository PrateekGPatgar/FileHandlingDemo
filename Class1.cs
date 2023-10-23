using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    internal class Class1
    {
        FileStream fs1;
        FileStream fs2;
        public void WriteTofile()
        {
            fs1 = new FileStream("Test1.txt",
                FileMode.OpenOrCreate,
                FileAccess.Write,
                FileShare.None);
            StreamWriter sw = new StreamWriter(fs1);
            Console.WriteLine("Enter a sentence");
            string s = Console.ReadLine();
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs1.Close();
        }
        public void ReadFromFile()
        {
            fs2 = new FileStream("Test1.txt",
                FileMode.OpenOrCreate,
                FileAccess.Read,
                FileShare.None);
            StreamReader sr = new StreamReader(fs2);
            string result = sr.ReadToEnd();
            Console.WriteLine(result);
            sr.Close();
            fs2.Close();
    }
}
}
