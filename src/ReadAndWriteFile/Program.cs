using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ReadAndWriteFile
{
    class Program
    {
        /// <summary>
        /// Đọc toàn bộ nội dung file trong đường dẫn filePath, và in ra màn hình console
        /// </summary>
        /// <param name="filePath">Đường dẫn file</param>
        static string ReadFile(string filePath)
        {
            // Sử dụng Try, Catch để bắt các lỗi ngoại lệ...
            // Tránh làm CRASH chương trình
            try
            {
                // Sử dụng StringBuilder để nối chuỗi lại với nhau
                // sẽ tối ưu tốc độ hơn so với việc sử dụng toán tử += string
                StringBuilder sb = new StringBuilder();

                // Sử dụng StreamReader để đọc dữ liệu file "data.txt"
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;

                    // Sử dụng vòng lặp While để đọc từng dòng dữ liệu
                    // đến khi đọc hết file
                    while ((line = sr.ReadLine()) != null)
                    {
                        // In ra màn hình
                        Console.WriteLine(line);

                        // Nối chuỗi
                        sb.AppendLine(line);
                    }
                }

                // Trả về chuỗi tất cả text
                return sb.ToString();
            }
            catch (Exception e)
            {
                // Thông báo lỗi ngoại lệ
                Console.WriteLine("Không thể đọc được file. Lỗi xảy ra:");
                Console.WriteLine(e.Message);
            }

            // Nếu chạy đến đây thì có khả năng lỗi đã xảy ra, trả về rỗng
            return "";
        }

        /// <summary>
        /// Hàm ghi nội dung vào filePath
        /// </summary>
        /// <param name="filePath">Đường dẫn file cần ghi</param>
        /// <param name="content">Nội dung</param>
        /// <returns></returns>
        static bool WriteFile(string filePath, string content)
        {
            // Sử dụng Try, Catch để bắt các lỗi ngoại lệ...
            // Tránh làm CRASH chương trình
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(content);
                }
                return true;
            }
            catch (Exception e)
            {
                // Thông báo lỗi ngoại lệ
                Console.WriteLine("Không thể ghi được file. Lỗi xảy ra:");
                Console.WriteLine(e.Message);
            }

            // Nếu chạy đến đây thì có khả năng lỗi đã xảy ra, trả về false
            return false;
        }

        /// <summary>
        /// Trích xuất nội dung trong file
        /// </summary>
        /// <param name="content">Nội dung file</param>
        static string ExtractDataInContent(string content)
        {
            // Sử dụng Try, Catch để bắt các lỗi ngoại lệ...
            // Tránh làm CRASH chương trình
            try
            {
                // Tạo danh sách chứa các thông tin trích xuất được
                List<string> lstEmail = new List<string>();
                List<string> lstName = new List<string>();
                List<string> lstTel = new List<string>();

                // Trích xuất EMAIL
                string emailPattern = @"email\:\w+@(nentang\.vn|ctu\.edu\.vn|gmail\.com|cusc\.ctu\.edu\.vn)"; //Mẫu regular pattern kiểm tra EMAIL
                MatchCollection mcEmail = Regex.Matches(content, emailPattern);
                foreach (Match m in mcEmail)
                {
                    lstEmail.Add(m.ToString());
                }

                // Trích xuất NAME
                string namePattern = @"name:\w+"; //Mẫu regular pattern kiểm tra NAME
                MatchCollection mcName = Regex.Matches(content, namePattern);
                foreach (Match m in mcName)
                {
                    lstName.Add(m.ToString());
                }

                // Trích xuất TEL
                string telPattern = @"tel:\d+"; //Mẫu regular pattern kiểm tra TEL
                MatchCollection mcTel = Regex.Matches(content, telPattern);
                foreach (Match m in mcTel)
                {
                    lstTel.Add(m.ToString());
                }

                return String.Join(Environment.NewLine, (lstEmail.Concat(lstName).Concat(lstTel)));
            }
            catch (Exception e)
            {
                // Thông báo lỗi ngoại lệ
                Console.WriteLine("Không thể đọc được file. Lỗi xảy ra:");
                Console.WriteLine(e.Message);
            }

            // Nếu chạy đến đây thì có khả năng lỗi đã xảy ra, trả về content
            return content;
        }

        /// <summary>
        /// Tạo mẫu Regular pattern để lọc các từ bad word
        /// AA|BB|CC|DD|EE
        /// </summary>
        /// <param name="filePath">Đường dẫn file</param>
        static string GeneratePatternFromBadWordFile(string filePath)
        {
            // Sử dụng Try, Catch để bắt các lỗi ngoại lệ...
            // Tránh làm CRASH chương trình
            try
            {
                // Tạo list lưu trữ Bad word
                List<string> lstBadWord = new List<string>();

                // Sử dụng StreamReader để đọc dữ liệu file "data.txt"
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;

                    // Sử dụng vòng lặp While để đọc từng dòng dữ liệu
                    // đến khi đọc hết file
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Nối chuỗi
                        lstBadWord.Add(line);
                    }
                }

                // Ghép các từ trong LIST với ký tự "|"
                return "(" + String.Join("|", lstBadWord) + ")";
            }
            catch (Exception e)
            {
                // Thông báo lỗi ngoại lệ
                Console.WriteLine("Không thể đọc được file. Lỗi xảy ra:");
                Console.WriteLine(e.Message);
            }

            // Nếu chạy đến đây thì có khả năng lỗi đã xảy ra, trả về rỗng
            return "";
        }

        /// <summary>
        /// Hàm kiểm tra xem có tồn tại BAD WORD trong CONTENT hay không?
        /// </summary>
        /// <param name="content">Nội dung cần kiểm duyệt</param>
        /// <param name="pattern">Mẫu Regular Expression</param>
        /// <returns></returns>
        static int DetectBadWordInContent(string content, string pattern)
        {
            MatchCollection mc = Regex.Matches(content, pattern);
            return mc.Count;
        }

        /// <summary>
        /// Hàm loại bỏ các BAD WORD
        /// </summary>
        /// <param name="content">Nội dung cần kiểm duyệt</param>
        /// <param name="pattern">Mẫu Regular Expression</param>
        /// <returns></returns>
        static string RemoveBadWordInContent(string content, string pattern)
        {
            MatchCollection mc = Regex.Matches(content, pattern);
            foreach (Match m in mc)
            {
                content = content.Replace(m.ToString(), "");
            }

            return content;
        }

        static void Main(string[] args)
        {
            // Đường dẫn đến file dữ liệu "data.txt"
            // - Đường dẫn tuyệt đối là được dẫn được chỉ định cụ thể: [Ổ đĩa]:\[Thư mục]\[Tên file]
            //   Ví dụ: D:\DuLieu\data.txt
            // - Đường dẫn tương đối được tính từ file .EXE của chương trình
            //   Ví dụ: data.txt
            string filePath = "data.txt";

            // Đọc nội dung file và in ra màn hình
            Console.WriteLine("Noi dung file \"data.txt\"");
            string allText = ReadFile(filePath);

            // Tìm và in danh sách các email hợp lệ để gởi mail MARKETING hàng loạt đến người dùng
            string contentExtracted = ExtractDataInContent(allText);

            // Lưu nội dung được trích xuất ra file
            string dataExtractedFilePath = "data_extracted.txt";
            WriteFile(dataExtractedFilePath, contentExtracted);
            Console.WriteLine("Ket qua trich xuat du lieu duoc luu trong file {0}", dataExtractedFilePath);

            // Tạo mẫu pattern từ các BAD WORD trong file
            string badWordFilePath = "base-list-of-bad-words_text-file.txt";
            string badWordPattern = GeneratePatternFromBadWordFile(badWordFilePath);

            // Kiểm tra có BAD WORD không?
            int badWordCount = DetectBadWordInContent(allText, badWordPattern);
            bool foundBadWord = badWordCount > 0;
            Console.WriteLine("Ket qua kiem tra noi dung: {0}", (foundBadWord ? "Phat hien BAD WORD!!!" : "Noi dung OKEY!!!"));

            // Loại bỏ BAD WORD trong nội dung (nếu phát hiện được)
            if (foundBadWord)
            {
                Console.WriteLine("So luong tu BAD WORD phat hien duoc: {0}", badWordCount);

                string contentChecked = RemoveBadWordInContent(allText, badWordPattern);
                string okeyFilePath = "data_checked.txt";
                WriteFile(okeyFilePath, contentChecked);
                Console.WriteLine("Ket qua kiem duyet noi dung duoc luu trong file {0}", okeyFilePath);
            }

            // Dừng màn hình chờ nhấn Enter để kết thúc
            Console.ReadLine();
        }
    }
}