using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_SystemIOFileIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool check = File.Exists("c:\\Network Akademi\\merhaba.txt");
            //if (check)
            //{
            //    Console.WriteLine("Belirtmiş olduğunuz dosya sistemde bulunmaktadır.");
            //}
            //else
            //{
            //    FileCreate("c:\\Network Akademi\\merhaba.txt");
            //}
        }
        static void FileCreate(string path)
        {
            FileStream fs = File.Create(path);
            fs.Close();
        }
        static string FileReadAllText(string path)
        {
            string textValue = File.ReadAllText(path);
            return textValue;
        }
    }
}
