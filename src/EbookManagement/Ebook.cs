using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbookManagement
{
    public class Ebook
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string TenTacGia { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public string ChuyenMuc { get; set; }
        public decimal GiaBan { get; set; }
        public decimal SoLuongBan { get; set; }
        public decimal ThanhTien { get; set; }

        public Ebook() { }
        public Ebook(string ma, string ten, string tenTacGia, string nhaXuatBan, int namXuatBan, string chuyenMuc, decimal giaBan, decimal soLuongBan)
        {
            Ma = ma;
            Ten = ten;
            TenTacGia = tenTacGia;
            NhaXuatBan = nhaXuatBan;
            NamXuatBan = namXuatBan;
            ChuyenMuc = chuyenMuc;
            GiaBan = giaBan;
            SoLuongBan = soLuongBan;
        }
        public void NhapLieu()
        {
            string temp;
            Console.ResetColor();
            
            Console.Write("Moi nhap ma ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("({0}): ", this.Ma));
            Console.ResetColor();
            temp = Console.ReadLine();
            if(temp != "")
            {
                this.Ma = temp;
            }

            Console.Write("Moi nhap ten: ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("({0}): ", this.Ten));
            Console.ResetColor();
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.Ten = temp;
            }

            Console.Write("Moi nhap ten tac gia: ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("({0}): ", this.TenTacGia));
            Console.ResetColor();
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.TenTacGia = temp;
            }

            Console.Write("Moi nhap nha xuat ban: ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("({0}): ", this.NhaXuatBan));
            Console.ResetColor();
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.NhaXuatBan = temp;
            }

            Console.Write("Moi nhap nam xuat ban: ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("({0}): ", this.NamXuatBan));
            Console.ResetColor();
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.NamXuatBan = int.Parse(temp);
            }

            Console.Write("Moi nhap chuyen muc: ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("({0}): ", this.ChuyenMuc));
            Console.ResetColor();
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.ChuyenMuc = temp;
            }

            Console.Write("Moi nhap gia ban: ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("({0}): ", this.GiaBan));
            Console.ResetColor();
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.GiaBan = decimal.Parse(temp);
            }

            Console.Write("Moi nhap so luong ban: ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("({0}): ", this.SoLuongBan));
            Console.ResetColor();
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.SoLuongBan = decimal.Parse(temp);
            }

            Console.ResetColor();
        }
        public void InManHinh()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(String.Format("- Ma: {0}", this.Ma));
            Console.WriteLine(String.Format("- Ten: {0}", this.Ten));
            Console.WriteLine(String.Format("- Ten tac gia: {0}", this.TenTacGia));
            Console.WriteLine(String.Format("- Nha xuat ban: {0}", this.NhaXuatBan));
            Console.WriteLine(String.Format("- Nam xuat ban: {0}", this.NamXuatBan));
            Console.WriteLine(String.Format("- Chuyen muc: {0}", this.ChuyenMuc));
            Console.WriteLine(String.Format("- Gia ban: {0}", this.GiaBan));
            Console.WriteLine(String.Format("- So luong ban: {0}", this.SoLuongBan));
            Console.WriteLine(String.Format("- Thanh tien: {0}", this.ThanhTien));

            Console.ResetColor();
        }
        public void InManHinhKieuDong()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("| Ma: {0}", this.Ma));
            Console.Write(String.Format("| Ten: {0}", this.Ten));
            Console.Write(String.Format("| Ten tac gia: {0}", this.TenTacGia));
            Console.Write(String.Format("| Nha xuat ban: {0}", this.NhaXuatBan));
            Console.Write(String.Format("| Nam xuat ban: {0}", this.NamXuatBan));
            Console.Write(String.Format("| Chuyen muc: {0}", this.ChuyenMuc));
            Console.Write(String.Format("| Gia ban: {0}", this.GiaBan));
            Console.Write(String.Format("| So luong ban: {0}", this.SoLuongBan));
            Console.Write(String.Format("| Thanh tien: {0} |", this.ThanhTien));
            Console.ResetColor();
        }
        public void TinhThanhTien()
        {
            this.ThanhTien = this.GiaBan * this.SoLuongBan;
        }
        public string Serialization()
        {
            // cách 1
            //string data = "";
            //data += this.Ma;
            //data += "," + this.Ten;
            //data += "," + this.TenTacGia;
            //data += "," + this.NhaXuatBan;
            //data += "," + this.NamXuatBan;
            //data += "," + this.ChuyenMuc;
            //data += "," + this.GiaBan;
            //data += "," + this.SoLuongBan;
            //data += "," + this.ThanhTien;

            // cách 2
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Ma);
            sb.Append(",");
            sb.Append(this.Ten);
            sb.Append(",");
            sb.Append(this.TenTacGia);
            sb.Append(",");
            sb.Append(this.NhaXuatBan);
            sb.Append(",");
            sb.Append(this.NamXuatBan);
            sb.Append(",");
            sb.Append(this.ChuyenMuc);
            sb.Append(",");
            sb.Append(this.GiaBan);
            sb.Append(",");
            sb.Append(this.SoLuongBan);
            sb.Append(",");
            sb.Append(this.ThanhTien);

            return sb.ToString();
        }
    }
}
