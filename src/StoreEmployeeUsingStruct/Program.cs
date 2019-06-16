using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreEmployeeUsingStruct
{
    class Program
    {
        /// <summary>
        /// Cấu trúc Nhân viên bao gồm
        /// - Họ tên
        /// - Ngày sinh
        /// - Giới tính
        /// </summary>
        struct NhanVien
        {
            public string HoTen;
            public NgaySinhDataType NgaySinh;
            public int GioiTinh;
            public bool LaNhanVienChinhThuc;

            public void InThongTin()
            {
                Console.WriteLine("Ho ten: {0}", this.HoTen);
                Console.WriteLine("Ngay sinh: {0}", this.HoTen);
                Console.WriteLine("Gioi tinh: {0}", (this.GioiTinh == 0) ? "Nam" : "Nu");
                Console.WriteLine("Loai hop dong: {0}", (this.LaNhanVienChinhThuc == true) ? "Nhan vien chinh thuc" : "Nhan vien tap su");
            }
        }

        /// <summary>
        /// Cấu trúc Ngày sinh bao gồm
        /// - Ngày
        /// - Tháng
        /// - Năm
        /// </summary>
        struct NgaySinhDataType
        {
            public int Day;
            public int Month;
            public int Year;
        }
        static void Main(string[] args)
        {
            int total = 3;
            Console.Write("\nNhap thong tin Nhan vien su dung Struct trong C#:\n");
            Console.Write("--------------------------\n");

            // Nhập thông tin danh sách [total] Nhân viên
            NhanVien[] emp = new NhanVien[total];
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("--- NHAP THONG TIN NHAN VIEN THU {0} ---", (i+1));
                // Họ tên
                Console.Write("Ho ten nhan vien: ");
                string hotenInput = Console.ReadLine();
                emp[i].HoTen = hotenInput;

                // Giới tính
                Console.Write("Nhap gioi tinh (0: Nam; 1: Nu): ");
                int gioiTinhInput = Convert.ToInt32(Console.ReadLine());
                emp[i].GioiTinh = gioiTinhInput;

                // Ngày tháng năm sinh
                Console.Write("Nhap ngay sinh: ");
                int ddInput = Convert.ToInt32(Console.ReadLine());
                emp[i].NgaySinh.Day = ddInput;

                Console.Write("Nhap thang sinh: ");
                int mmInput = Convert.ToInt32(Console.ReadLine());
                emp[i].NgaySinh.Month = mmInput;

                Console.Write("Nhap nam sinh: ");
                int yyInput = Convert.ToInt32(Console.ReadLine());
                emp[i].NgaySinh.Year = yyInput;

                // Loại hợp đồng
                Console.Write("Nhap loai hop dong (Y: chinh thuc; N: tap su): ");
                string loaiHopDongInput = Console.ReadLine();
                emp[i].LaNhanVienChinhThuc = (loaiHopDongInput == "Y") ? true : false;

                Console.WriteLine("--------------------------------------");
            }

            // In thông tin danh sách [total] Nhân viên vừa nhập
            Console.WriteLine("=== DANH SACH NHAN VIEN ===");
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("---Nhan vien thu {0}", (i+1));
                emp[i].InThongTin();
                Console.WriteLine("--------------------");
            }
            Console.WriteLine("===========================");

            // Dừng màn hình để kiểm tra
            Console.ReadKey();
        }
    }
}
