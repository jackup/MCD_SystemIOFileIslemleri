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

            //FileAppendText("c:\\Network Akademi\\merhaba.txt", "Merhaba txt");
            //string textValue = FileReadAllText("c:\\Network Akademi\\merhaba.txt");
            //Console.WriteLine(textValue);

            //FileCopy("c:\\Network Akademi\\merhaba.txt", "c:\\Network Akademi\\hello.txt");
            //FileMove("c:\\Network Akademi\\hello.txt", "c:\\Network Akademi\\new\\hello.txt");
            FileDelete("c:\\Network Akademi\\new\\hello.txt");
            
            
        }
        static void FileCreate(string path)
        {
            FileStream fs = File.Create(path);
            fs.Close();
        }
        static void FileDelete(string path)
        {
            File.Delete(path);
        }
        static string FileReadAllText(string path)
        {
            string textValue = File.ReadAllText(path);
            return textValue;
        }
        static void FileMove(string source, string target)
        {
            File.Move(source, target);
        }

        static void FileCopy(string source, string target)
        {
            File.Copy(source, target);
        }
        static void FileAppendText(string path, string value)
        {
            File.AppendAllText(path, value);
        }
    }
}
