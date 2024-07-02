using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EncryptDecrypt_Hashing
{
    class Program
    {
        /* 
         * MD5 là viết tắt của "Message Digest Algorithm 5", là một thuật toán băm tiêu chuẩn được thiết kế để tạo ra một giá trị băm (hash value) 
         * có độ dài cố định từ một đoạn dữ liệu có độ dài bất kỳ. Giá trị băm được tạo ra thông qua MD5 thường là một chuỗi hex (hệ thập lục phân) 
         * có độ dài 32 ký tự (128 bit).
         * MD5 được Ronald Rivest thiết kế vào năm 1991 và đã trở thành thuật toán băm phổ biến nhất trong những năm đầu tiên của internet.
         * Trong thời gian gần đây, nhiều cuộc tấn công collision (xung đột) đã được thực hiện thành công trên MD5 và nó không còn được khuyến cáo
         * sử dụng trong các hệ thống yêu cầu tính bảo mật cao.
         */
        public static string GenerateMD5(string data)
        {
            //tạo mới đối tượng lưu chuỗi kết quả 
            StringBuilder hash = new StringBuilder();
            //tạo mới đối tượng mã hóa md5
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            //mã hóa
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(data));
            //duyệt từng byte chuyển sang hệ 16
            for (int i = 0; i < bytes.Length; i++)
            {
                //chuyển về hệ hexa (16) chữ thường nếu muốn chữ hoa thì X2 nhé
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        /*
         * SHA stands for Simple Hashing Algorithm. SHA-256 will take any given input of data, convert it into 256 bits (256 zeros and ones), 
         * and then output those 256 bits into the format of 64 hexadecimal characters. The hexadecimal system uses a combination 
         * of 16 different characters (0123456789ABCDEF). Each hexadecimal characters represents 4 bits, which means that 64 hexadecimal 
         * characters represent 256 bits. There are 8 bits per byte, which means that 256 bits is equal to 32 bytes.
         * 
         * SHA là viết tắt của "Secure Hash Algorithm" là một loạt các thuật toán băm được thiết kế để tạo ra giá trị băm (hash value) có độ dài
         * cố định từ một đoạn dữ liệu có độ dài bất kỳ. Các thuật toán trong loạt SHA thường được sử dụng trong nhiều ứng dụng bảo mật 
         * thường là 256 hoặc 512 bit.
         */
        // SHA-256
        public static string ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        // SHA-512 
        public static string ComputeSHA512Hash(string input)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha512.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("*** Chương trình mã hóa (Encryption) và giải mã (Decryption) - Mã băm Hashing MD5 ***");
            string text = "Dương Nguyễn Phú Cường";

            // -- MD5
            Console.WriteLine("[Mã băm Hashing MD5]");
            Console.WriteLine("Chuỗi gốc: " + text);

            string textMD5 = GenerateMD5(text);
            Console.WriteLine("Chuỗi MD5: " + textMD5);
            Console.WriteLine("Độ dài Chuỗi MD5: " + textMD5.Length);

            // -- SHA256
            Console.WriteLine("[Mã băm Hashing SHA256]");
            Console.WriteLine("Chuỗi gốc: " + text);

            string textSHA256 = ComputeSHA256Hash(text);
            Console.WriteLine("Chuỗi SHA256: " + textSHA256);
            Console.WriteLine("Độ dài Chuỗi SHA256: " + textSHA256.Length);

            // -- SHA512
            Console.WriteLine("[Mã băm Hashing SHA512]");
            Console.WriteLine("Chuỗi gốc: " + text);

            string textSHA512 = ComputeSHA512Hash(text);
            Console.WriteLine("Chuỗi SHA512: " + textSHA512);
            Console.WriteLine("Độ dài Chuỗi SHA512: " + textSHA512.Length);

            Console.Read();
        }
    }
}
