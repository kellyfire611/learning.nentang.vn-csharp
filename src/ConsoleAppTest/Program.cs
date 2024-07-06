using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
  
    public class Program
    {
        static void Main(string[] args)
        {
            FileStream fWrite = new FileStream("TextFile.txt", FileMode.Create,
                FileAccess.Write);

            var text = "This is some text written to the TextFile 2";

            byte[] writeArr = Encoding.UTF8.GetBytes(text);

            fWrite.Write(writeArr, 0, writeArr.Length);

            fWrite.Close();

            // Read
            FileStream fRead = new FileStream("TextFile.txt", FileMode.Open,
                FileAccess.Read, FileShare.Read);

            byte[] readArr = new byte[text.Length];
            int count;

            while((count = fRead.Read(readArr, 0, readArr.Length)) > 0)
            {
                Console.WriteLine(Encoding.UTF8.GetString(readArr, 0, count));
            }
            
            fRead.Close();

            // Đọc cách 2
            FileStream fs = File.OpenRead("TextFile.txt");
            byte[] buffer = new byte[1024];
            int c;

            while((c = fs.Read(buffer, 0, buffer.Length)) > 0) { 
                Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, c));
            }

            // Read StreamReader

            ReadLargeFile("TestFile_50M.txt");


            Console.Read();
        }

        public static string ReadLargeFile(string path)
        {
            const int bufferSize = 8; // read the file in 4KB chunks
            var builder = new StringBuilder();

            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    char[] buffer = new char[bufferSize];
                    int bytesRead;

                    while ((bytesRead = streamReader.ReadBlock(buffer, 0, bufferSize)) > 0)
                    {
                        builder.Append(buffer, 0, bytesRead);
                        string tmp = new string(buffer, 0, bytesRead);
                        Console.WriteLine(tmp);
                        Thread.Sleep(3000);
                    }
                }
            }

            return builder.ToString();
        }
    }
}
