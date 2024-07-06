using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EbookManagement
{
    internal class Program
    {
        static string secretKey = "42bedad76f22113a7dc8225c6b342150"; //NenTang.vn MD5

        static void Main(string[] args)
        {
            string userChoice = "";
            List<Ebook> lstEbooks = new List<Ebook>();
            Ebook objEbook = null;
            string keywordMa = "";
            string tenFile = "";
            tenFile = String.Format("du_lieu_ebooks_{0}_{1}_{2}.dat",
                            DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            // Dữ liệu giả
            Ebook objEbook1 = new Ebook();
            objEbook1.Ma = "E001";
            objEbook1.Ten = "Lap trinh can ban CSharp";
            objEbook1.TenTacGia = "Dai hoc Can Tho";
            objEbook1.NhaXuatBan = "NXB Dai Hoc Can Tho";
            objEbook1.NamXuatBan = 2019;
            objEbook1.ChuyenMuc = "Lap trinh";
            objEbook1.GiaBan = 1490000;
            objEbook1.SoLuongBan = 15;
            objEbook1.TinhThanhTien();
            lstEbooks.Add(objEbook1);

            Ebook objEbook2 = new Ebook();
            objEbook2.Ma = "E002";
            objEbook2.Ten = "Thiet ke web voi Laravel";
            objEbook2.TenTacGia = "CUSC";
            objEbook2.NhaXuatBan = "Trung tam Cong Nghe Phan Mem";
            objEbook2.NamXuatBan = 2018;
            objEbook2.ChuyenMuc = "Lap trinh";
            objEbook2.GiaBan = 300000;
            objEbook2.SoLuongBan = 30;
            objEbook2.TinhThanhTien();
            lstEbooks.Add(objEbook2);

            Ebook objEbook3 = new Ebook()
            {
                Ma = "E003",
                Ten = "Tri tue nhan tao",
                TenTacGia = "CTU-CIT",
                NhaXuatBan = "Khoa Cong Nghe",
                NamXuatBan = 2015,
                ChuyenMuc = "AI",
                GiaBan = 2500000,
                SoLuongBan = 72
            };
            objEbook3.TinhThanhTien();
            lstEbooks.Add(objEbook3);

            do {
                
                Console.WriteLine("================== HE THONG QUAN LY CUA HANG EBOOK ONLINE==================================");
                Console.WriteLine("| 1. Nhap thong tin Ebook                                                                 |");
                Console.WriteLine("|    1.1. Nhap Ebook moi vao dau danh sach                                                |");
                Console.WriteLine("|    1.2. Nhap Ebook moi cuoi danh sach                                                   |");
                Console.WriteLine("|    1.3. Nhap Ebook vao vi tri bat ky ma nguoi dung mong muon trong danh sach            |");
                Console.WriteLine("| 2. In thong tin Ebook                                                                   |");
                Console.WriteLine("|    2.1. In thong tin tat ca Ebook (dang luoi - hang/cot)                                |");
                Console.WriteLine("|    2.2. In va sap xep thu tu Ebook theo Alphabet                                        |");
                Console.WriteLine("|    2.3. Tim và in thong tin 1 Ebook cu the, dua vao ma Ebook?                           |");
                Console.WriteLine("| 3. Xoa Ebook                                                                            |");
                Console.WriteLine("|    3.1. Xoa Ebook dua vao ma ebook                                                      |");
                Console.WriteLine("| 4. Sua Ebook                                                                            |");
                Console.WriteLine("|    4.1. Sua thong tin Ebook dua vao ma ebook                                            |");
                Console.WriteLine("| 5. Thong ke                                                                             |");
                Console.WriteLine("|    5.1. Co bao nhieu Ebook trong He thong?                                              |");
                Console.WriteLine("|    5.2. Co bao nhieu Ebook duoc xuat ban trong 5 nam gan day?                           |");
                Console.WriteLine("|    5.3. Ebook co doanh thu bán ra cao nhat va thap nhat? In thong tin                   |");
                Console.WriteLine("|    5.4. Thong ke moi chuyen muc co bao nhieu Ebook? Tong doanh thu cua tung chuyen muc? |");
                Console.WriteLine("|6. Xuat (export) du lieu                                                                 |");
                Console.WriteLine("|    6.1. Xuat tat ca Ebook theo chuan CSV, luu tru trong tap tin \"du_lieu_ebooks.dat\"    |");
                Console.WriteLine("|    6.2. Ma hoa tap tin \"du_lieu_ebooks.dat\"                                             |");
                Console.WriteLine("|7. Nhap (import) du lieu                                                                 |");
                Console.WriteLine("|    7.1. Doc va giai ma du lieu tap tin \"du_lieu_ebooks.dat\", sau do nhap (import) tat   |");
                Console.WriteLine("|ca ebook đang co vao he thong                                                            |");
                Console.WriteLine("===========================================================================================");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ban muon su dung chuc nang nao: ");
                userChoice = Console.ReadLine();
                Console.ResetColor();

                switch (userChoice)
                {
                    case "1.1":
                        objEbook = new Ebook();
                        objEbook.NhapLieu();
                        objEbook.TinhThanhTien();
                        Console.WriteLine("Thong tin ebook vua nhap: ");
                        objEbook.InManHinh();

                        lstEbooks.Insert(0, objEbook); // index 0
                        break;
                    case "1.2":
                        objEbook = new Ebook();
                        objEbook.NhapLieu();
                        objEbook.TinhThanhTien();
                        Console.WriteLine("Thong tin ebook vua nhap: ");
                        objEbook.InManHinh();

                        lstEbooks.Insert(lstEbooks.Count - 1, objEbook); // index Count - 1
                        break;
                    case "1.3":
                        objEbook = new Ebook();
                        objEbook.NhapLieu();
                        objEbook.TinhThanhTien();
                        Console.WriteLine("Thong tin ebook vua nhap: ");
                        objEbook.InManHinh();

                        Console.WriteLine("Ban muon chen cuon sach o vi tri nao? ");
                        int viTri = int.Parse(Console.ReadLine());
                        if (viTri < 1 || viTri > lstEbooks.Count)
                        {
                            Console.WriteLine("Vi tri khong hop le.");
                        }
                        else
                        {
                            lstEbooks.Insert(viTri - 1, objEbook);
                        }
                        break;
                    case "2.1":
                        Console.WriteLine("| Ma   | Ten ebook                | Tac gia         | Nha xuat ban                 | Nam XB | Chuyen muc | Gia ban | SL | Thanh tien |");
                        foreach (Ebook e in lstEbooks)
                        {
                            e.InManHinhKieuDong();
                            Console.WriteLine();
                        }
                        break;
                    case "2.2":
                        List<Ebook> lstEbookOrdered = lstEbooks.OrderBy(z => z.GiaBan).ToList(); // Sắp xếp giảm dần Z->A
                        Console.WriteLine("Danh sach sau khi sap xep giam dan: ");
                        foreach (Ebook e in lstEbookOrdered)
                        {
                            e.InManHinhKieuDong();
                            Console.WriteLine();
                        }
                        break;
                    case "2.3":
                        Console.WriteLine("Moi ban nhap ma ebook: ");
                        keywordMa = Console.ReadLine();

                        Ebook objEbookTimDuoc = null;
                        foreach (Ebook e in lstEbooks)
                        {
                            if(e.Ma == keywordMa)
                            {
                                objEbookTimDuoc = e;
                            }
                        }

                        if(objEbookTimDuoc == null)
                        {
                            Console.WriteLine("Ebook tim khong thay.");
                        } else
                        {
                            objEbookTimDuoc.InManHinh();
                        }
                        break;
                    case "3.1":
                        Console.WriteLine("Moi ban nhap ma ebook: ");
                        keywordMa = Console.ReadLine();

                        Ebook objEbookMuonXoa = null;
                        foreach (Ebook e in lstEbooks)
                        {
                            if (e.Ma == keywordMa)
                            {
                                objEbookMuonXoa = e;
                            }
                        }

                        if (objEbookMuonXoa == null)
                        {
                            Console.WriteLine("Ebook tim khong thay.");
                        }
                        else
                        {
                            lstEbooks.Remove(objEbookMuonXoa);
                        }
                        break;
                    case "4.1":
                        Console.WriteLine("Moi ban nhap ma ebook: ");
                        keywordMa = Console.ReadLine();

                        Ebook objEbookMuonSua = null;
                        foreach (Ebook e in lstEbooks)
                        {
                            if (e.Ma == keywordMa)
                            {
                                objEbookMuonSua = e;
                            }
                        }

                        if (objEbookMuonSua == null)
                        {
                            Console.WriteLine("Ebook tim khong thay.");
                        }
                        else
                        {
                            objEbookMuonSua.NhapLieu();
                        }
                        break;
                    case "5.1":
                        Console.WriteLine(String.Format("Hien dang co {0} ebooks.", lstEbooks.Count));
                        break;
                    case "5.2":
                        int namHienTai = DateTime.Now.Year;
                        int namMuonXet = namHienTai - 5; // 5 năm gần đây

                        List<Ebook> lstThongKe = new List<Ebook>();
                        foreach (Ebook e in lstEbooks) 
                        { 
                            if(e.NamXuatBan >= namMuonXet)
                            {
                                lstThongKe.Add(e);
                            }
                        }

                        if(lstThongKe.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Khong co cuon sach nao trong 5 nam gan day...");
                            Console.ResetColor();
                        } 
                        else
                        {
                            Console.WriteLine(String.Format("Hien dang co {0} ebooks tim duoc trong 5 nam gan day."
                                , lstThongKe.Count));
                            foreach (Ebook e in lstThongKe)
                            {
                                e.InManHinh();
                            }
                        }
                        break;
                    case "5.3":
                        Ebook objEbookDoanhThuMax = null;
                        Ebook objEbookDoanhThuMin = null;
                        decimal max = 0;
                        decimal min = lstEbooks[0].ThanhTien;
                        foreach (Ebook e in lstEbooks)
                        {
                            // Tìm Max
                            if(e.ThanhTien > max)
                            {
                                max = e.ThanhTien;
                                objEbookDoanhThuMax = e;
                            }

                            // Tìm Min
                            if(e.ThanhTien < min)
                            {
                                min = e.ThanhTien;
                                objEbookDoanhThuMin = e;
                            }
                        }

                        Console.WriteLine(String.Format("Doanh thu cao nhat la: {0}", max));
                        objEbookDoanhThuMax.InManHinh();

                        Console.WriteLine(String.Format("Doanh thu thap nhat la: {0}", min));
                        objEbookDoanhThuMin.InManHinh();
                        break;
                    case "5.4":
                        var data = from p in lstEbooks
                                   group p by p.ChuyenMuc into grp
                                   select new
                                   {
                                       TenChuyenMuc = grp.Key,
                                       TongSoLuong = grp.Count(),
                                       TongThanhTien = grp.Sum(z => z.ThanhTien)
                                   };

                        Console.WriteLine("Du lieu thong ke theo Chuyen muc:");
                        foreach (var d in data)
                        {
                            Console.WriteLine("----------");
                            Console.WriteLine(String.Format("Chuyen muc: {0}", d.TenChuyenMuc));
                            Console.WriteLine(String.Format("so luong sach: {0}", d.TongSoLuong));
                            Console.WriteLine(String.Format("Tong doanh thu: {0}", d.TongThanhTien));
                        }
                        break;
                    case "6.1":
                        using (StreamWriter sw = new StreamWriter(tenFile))
                        {
                            foreach (Ebook e in lstEbooks)
                            {
                                sw.WriteLine(e.Serialization());
                            }
                        }
                        break;
                    case "6.2":
                        string content = File.ReadAllText(tenFile);
                        string contentEncrypted = AESEncryptString(secretKey, content);

                        using(StreamWriter sw = new StreamWriter(tenFile))
                        {
                            sw.WriteLine(contentEncrypted);
                        }
                        break;
                    case "7.1":
                        string contentEncrypted2 = File.ReadAllText(tenFile);
                        string plainContent = AESDecryptString(secretKey, contentEncrypted2);

                        Console.WriteLine(plainContent);
                        lstEbooks.Clear();
                        // Tách chuỗi theo ký tự ENTER
                        string[] arrContentEbooks = plainContent.Split('\n');
                        foreach (string contentEbook in arrContentEbooks)
                        {
                            if(contentEbook == "") { continue; }

                            // Tách theo ký tự ,
                            string[] ebookProperties = contentEbook.Split(',');
                            Ebook ebook = new Ebook();
                            ebook.Ma = ebookProperties[0];
                            ebook.Ten = ebookProperties[1];
                            ebook.TenTacGia = ebookProperties[2];
                            ebook.NhaXuatBan = ebookProperties[3];
                            ebook.NamXuatBan = int.Parse(ebookProperties[4]);
                            ebook.ChuyenMuc = ebookProperties[5];
                            ebook.GiaBan = decimal.Parse(ebookProperties[6]);
                            ebook.SoLuongBan = decimal.Parse(ebookProperties[7]);
                            ebook.ThanhTien = decimal.Parse(ebookProperties[8]);

                            lstEbooks.Add(ebook);
                        }

                        break;
                    default:
                        Console.WriteLine("Chuong trinh khong ho tro chuc nang nay... Vui long chon trong menu...");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            } while (userChoice != "0");

            Console.Read();
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
    }
}
