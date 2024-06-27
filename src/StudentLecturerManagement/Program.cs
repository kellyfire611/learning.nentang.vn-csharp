using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLecturerManagement
{
    internal class Program
    {
        static List<Lecturer> lstLecturers = new List<Lecturer>();

        static void Main(string[] args)
        {
            MainMenu();

            Console.Read();
        }

        static void MainMenu()
        {
            Console.Clear();

            // Menu
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================");
            Console.WriteLine("1. Manage Students");
            Console.WriteLine("2. Manage Lecturers");
            Console.WriteLine("3. Exit");
            Console.WriteLine("=======================");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Please choose: ");
            string userChoose = Console.ReadLine();

            Console.ResetColor();
            switch (userChoose)
            {
                case "1":
                    Console.WriteLine("++++++ Manage Students ++++++");
                    break;
                case "2":
                    Console.WriteLine("++++++ Manage Lecturers ++++++");
                    SubMenuLecturer();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please choose only from 1 - 3.");
                    break;
            }
        }

        static void SubMenuLecturer()
        {
            // Dữ liệu giả
            Lecturer gvA = new Lecturer();
            gvA.ID = "11223344";
            gvA.Name = "Duong Nguyen Phu Cuong";
            gvA.DateOfBirth = "11/06/1989";
            gvA.Email = "phucuong@ctu.edu.vn";
            gvA.Address = "Ninh Kieu, TP Can Tho";
            gvA.Department = "IT dept";
            lstLecturers.Add(gvA);

            Lecturer gvB = new Lecturer();
            gvB.ID = "99887766";
            gvB.Name = "Nguyen Hai";
            gvB.DateOfBirth = "01/01/2000";
            gvB.Email = "nguyenhai@gmail.com";
            gvB.Address = "Soc Trang";
            gvB.Department = "ABC dept";
            lstLecturers.Add(gvB);

            // Xử lý
            Console.Clear();
            string userChoose;
            do
            {
                Console.WriteLine("=======================");
                Console.WriteLine("1. Add new lecturer");
                Console.WriteLine("2. View all lecturers");
                Console.WriteLine("3. Search lecturers");
                Console.WriteLine("4. Delete lecturers");
                Console.WriteLine("5. Update lecturer");
                Console.WriteLine("6. Back to main menu");
                Console.WriteLine("=======================");

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Please choose: ");
                userChoose = Console.ReadLine();
                Console.ResetColor();

                switch (userChoose)
                {
                    case "1":
                        Console.WriteLine("++ Add new Lecturer beginning....");
                        // Khởi tạo đối tượng Giảng viên và yêu cầu nhập liệu
                        Lecturer gv1 = new Lecturer();
                        bool isValid = false;
                        do
                        {
                            isValid = gv1.Input();
                            if (isValid)
                            {
                                gv1.Introduce();
                            }
                        } while (isValid != true);
                        // Đưa (add) thêm vào trong danh sách lstLecturers
                        lstLecturers.Add(gv1);
                        break;
                    case "2":
                        // In ra thông tin số lượng object đang có trong danh sách
                        Console.WriteLine(String.Format("List lecturers total have: {0} lecturer",
                            lstLecturers.Count));

                        // Vòng lặp duyệt qua tất cả đối tượng
                        foreach (Lecturer gv in lstLecturers) { 
                            gv.Introduce();
                            Console.WriteLine("------------------------");
                        }
                        break;
                    case "3":
                        // Yêu cầu nhập từ khóa tìm kiếm
                        Console.Write("Please input the name you want to search??? ");
                        string keyword = Console.ReadLine();

                        Lecturer gvTimDuoc = null;
                        // Vòng lặp duyệt qua tất cả đối tượng
                        foreach (Lecturer gv in lstLecturers)
                        {
                            // Tìm tương đối theo tên => trong tên của đối tượng cần tìm
                            // Có chứa các từ gần giống với từ khóa tìm kiếm
                            if(gv.Name.Contains(keyword))
                            {
                                gvTimDuoc = gv;
                            }
                        }

                        // Kiểm tra coi đã tìm được chưa?
                        if(gvTimDuoc == null) // Không tìm thấy
                        {
                            Console.WriteLine("Not found !!!");
                        }
                        else
                        {
                            Console.WriteLine("Found...");
                            gvTimDuoc.Introduce();
                        }
                        break;
                    case "4":
                        // Yêu cầu nhập từ khóa tìm kiếm
                        Console.Write("Please input the ID you want to delete??? ");
                        string keywordID = Console.ReadLine();

                        Lecturer gvTimDuocMuonXoa = null;
                        // Vòng lặp duyệt qua tất cả đối tượng
                        foreach (Lecturer gv in lstLecturers)
                        {
                            if(gv.ID == keywordID)
                            {
                                gvTimDuocMuonXoa = gv;
                            }
                        }

                        // Kiểm tra coi đã tìm được chưa?
                        if (gvTimDuocMuonXoa == null) // Không tìm thấy
                        {
                            Console.WriteLine("Not found !!!");
                        }
                        else
                        {
                            Console.WriteLine("Found. Deleting...");
                            lstLecturers.Remove(gvTimDuocMuonXoa);
                        }
                        break;
                    case "5":
                        // Yêu cầu nhập từ khóa tìm kiếm
                        Console.Write("Please input the ID you want to update??? ");
                        string keywordIDUpdate = Console.ReadLine();

                        Lecturer gvTimDuocMuonSua = null;
                        // Vòng lặp duyệt qua tất cả đối tượng
                        foreach (Lecturer gv in lstLecturers)
                        {
                            if (gv.ID == keywordIDUpdate)
                            {
                                gvTimDuocMuonSua = gv;
                            }
                        }

                        // Kiểm tra coi đã tìm được chưa?
                        if (gvTimDuocMuonSua == null) // Không tìm thấy
                        {
                            Console.WriteLine("Not found !!!");
                        }
                        else
                        {
                            Console.WriteLine("Found. Updating...");
                            gvTimDuocMuonSua.Input();
                        }
                        break;
                    case "6":
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Please choose only from 1 - 6.");
                        break;
                }
            } while (userChoose != "6");
        }

        static void SubMenuStudent()
        {

        }
    }
}
