using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Input Output

namespace ConsoleApp1
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base(message)
        {
        }
    }
    internal class Program
    {
        static int numA = 3;
        static int numB = 0;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo file
            string tenFileLog = String.Format("log_{0}_{1}_{2}.txt",
                DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            // Tạo/Ghi file: Cách 1 --------------------------
            //FileStream fsWriter = new FileStream(tenFileLog, FileMode.Create,
            //    FileAccess.Write);

            //// Chuyển string -> bytes[]
            //string text = "Đây là đoạn ví dụ";
            //byte[] writerArr = Encoding.UTF8.GetBytes(text);

            //// Đẩy bytes vào trong luồng file
            //fsWriter.Write(writerArr, 0, 10);
            //fsWriter.Close();

            // Tạo/Ghi file: Cách 2 -----------------------
            StreamWriter sw = new StreamWriter(tenFileLog, true);

            // Đọc file TEXT: Cách 1 ------------------
            //FileStream fsReader = new FileStream("bai_bao.txt", FileMode.Open,
            //    FileAccess.Read);

            //byte[] buffer = new byte[1024]; // Tạo bộ đệm, mỗi lần múc/lấy 1Kb ~ 1024 bytes
            //int count = 0;

            //while((count = fsReader.Read(buffer, 0, buffer.Length)) > 0)
            //{
            //    string txt = Encoding.UTF8.GetString(buffer, 0, count);

            //    Console.WriteLine(txt);
            //}
            //fsReader.Close();

            // Đọc file TEXT: Cách 2 ------------------
            StreamReader sr = new StreamReader("bai_bao.txt");
            string line;
            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            try
            {
                //Console.WriteLine("Moi nhap a:");
                //int a = int.Parse(Console.ReadLine());

                //Console.WriteLine("Moi nhap b: ");
                //int b = int.Parse(Console.ReadLine());

                //int kq = a / b;
                //Console.WriteLine("Ket qua la: " + kq);
                int kq2 = numA / numB;

                string[] dsHoTen = new string[3];
                dsHoTen[0] = "CUONG";
                //throw new Exception("Ném thử lỗi, bạn có xử lý được không?");

                //dsHoTen[3] = "LAN";
                // 100000000000000000000000000000000000000000000000 * 1000000000000000000000000
                if (dsHoTen[0] == "CUONG")
                {
                    throw new InvalidNameException("Tên này không được phép đặt...");
                }


            }
            catch(InvalidNameException invalidNameEx)
            {
                Console.WriteLine(invalidNameEx.Message);
            }
            catch (IndexOutOfRangeException objIndexOutOfRangeEx)
            {
                // In cho người dùng xem
                Console.WriteLine("Gia tri index vuot ngoai danh sach...");

                // Ghi log lỗi kỹ thuật -> ghi vào files
                sw.WriteLine(string.Format("{0} [{1}] [{2}] {3}",
                    DateTime.Now, "DNPCUONG-PC", "192.168.1.10", "Giá trị index vượt ngoài danh sách"));
                sw.WriteLine(string.Format("{0} [{1}] [{2}] {3}",
                    DateTime.Now, "DNPCUONG-PC", "192.168.1.10", objIndexOutOfRangeEx));
            }
            catch (DivideByZeroException objDivide)
            {
                // In cho người dùng xem
                Console.WriteLine("Co loi trong qua trinh xu ly... Ban vui long thuc hien lai.");

                // Ghi log lỗi kỹ thuật -> ghi vào file
                Console.WriteLine("Exception caught: " + objDivide);
                Console.WriteLine("Tien hanh ghi log loi");
                sw.WriteLine(string.Format("{0} [{1}] [{2}] {3}",
                    DateTime.Now, "DNPCUONG-PC", "192.168.1.10", "Chia giá trị cho 0"));
                sw.WriteLine(string.Format("{0} [{1}] [{2}] {3}",
                    DateTime.Now, "DNPCUONG-PC", "192.168.1.10", objDivide));
            }
            catch(Exception ex)
            {
                // In cho người dùng xem
                Console.WriteLine("========= EXCEPTION MAC DINH ==========");
                Console.WriteLine("Co loi trong qua trinh xu ly... Ban vui long thuc hien lai.");

                // Ghi log lỗi kỹ thuật -> ghi vào file
                Console.WriteLine("Exception: " + ex);
            }
            finally 
            { 
                sw.Close(); 
            }

            Console.Read();
        }

    }
}
