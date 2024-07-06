using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Runtime.CompilerServices;
using System.IO;

namespace ConsoleApp4
{
    internal class Program
    {
        // 0123456789ABCDEF
        public static string GenerateMD5(string content)
        {
            StringBuilder sb = new StringBuilder();
            MD5CryptoServiceProvider crypto = new MD5CryptoServiceProvider();

            byte[] bytes = crypto.ComputeHash(  new UTF8Encoding().GetBytes(content) );

            //duyệt từng byte chuyển sang hệ 16
            for (int i = 0; i < bytes.Length; i++)
            {
                //chuyển về hệ hexa (16) chữ thường nếu muốn chữ hoa thì X2 nhé
                sb.Append(bytes[i].ToString("x2"));
            }

            return sb.ToString();
        }

        // SHA256
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

        // SHA512
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

        public static string AESEncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16]; // Initial Vector
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string AESDecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            string secretText = File.ReadAllText("secretKey_DNPCUONG.txt");

            Console.WriteLine("Chuoi bi mat ban dau: " + secretText);
            string secretKey = GenerateMD5(secretText); // MD5 32 ký tự

            string content = File.ReadAllText("TapTinNhayCam.txt");
            string encryptedText = AESEncryptString(secretKey, content);

            Console.WriteLine("Noi dung da ma hoa: " + encryptedText);
            File.WriteAllText("TapTinDaMaHoa.txt", encryptedText);

            // Giải mã
            try
            {
                string contentEncrypted = File.ReadAllText("TapTinDaMaHoa.txt");
                string secketKeyGia = GenerateMD5("aaabbb"); // MD5 32 ký tự
                string decryptedText = AESDecryptString(secretKey, contentEncrypted);

                Console.WriteLine("Doan text goc: " + decryptedText);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Khong khop chia khoa...");
            }




            //Console.WriteLine("Ma MD5: " + cipherText);
            //Console.WriteLine("Ma MD5 co do dai: " + cipherText.Length);

            //Console.WriteLine("---------");
            //string cipherText_SHA256 = ComputeSHA256Hash(secretText);
            //Console.WriteLine("Ma SHA256: " + cipherText_SHA256);
            //Console.WriteLine("Ma SHA256 co do dai: " + cipherText_SHA256.Length);

            //Console.WriteLine("---------");
            //string cipherText_SHA512 = ComputeSHA512Hash(secretText);
            //Console.WriteLine("Ma SHA512: " + cipherText_SHA512);
            //Console.WriteLine("Ma SHA512 co do dai: " + cipherText_SHA512.Length);



            Console.Read();
        }
    }
}
