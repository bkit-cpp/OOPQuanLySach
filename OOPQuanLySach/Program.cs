using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuanLySach
{
    class Program
    {
        //public static List<QuanLySach> dssac = new List<QuanLySach>();
        static void QLSACH()
        {
            QuanLySach sachmanage = new QuanLySach();  
            do
            {
                Console.WriteLine("\t\t\t\t\t Chuong trinh Quan Ly Sach\t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t 1.Nhap thong tin Sach \t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t 2.Hien Thi thong tin Sach \t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t 3.Sap xep thong tin Sach theo Ten \t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t 4. Xoa thong tin Sach \t\t\t\t\t");
                Console.WriteLine("\t\t\t\t\t Moi Nhap Lua Chon\t\t\t\t\t");
                int choice = int.Parse(Console.ReadLine());
               
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Them Sach");
                        sachmanage.input();
                   Console.WriteLine("\n Them sach Thanh cong");
                          
                        break;
                    case 2:
                        if(sachmanage.SoLuong()>0)
                        {
                            Console.WriteLine("\n\n Hien Thi danh sach");
                            sachmanage.showBook(sachmanage.getlistbook());
                        }
                            
                       
                        break;
                    case 3:
                        if(sachmanage.SoLuong()>0)
                        {
                            Console.WriteLine("\n\nDanh Sach Sap xep theo ten sach");
                            sachmanage.SortByName();
                            sachmanage.showBook(sachmanage.getlistbook());
                        }
                        else
                        {
                            Console.WriteLine("\n\n\n Danh Sach Trong");
                        }
                        break;
                    case 4:
                        if(sachmanage.SoLuong()>0)
                        {
                            int id;
                            Console.WriteLine("\t\t\t Nhap vao ID:");
                            id = Convert.ToInt32(Console.ReadLine());
                            if(sachmanage.xoathongtin(id))
                            {
                                Console.WriteLine("Sach co ID={0} da bi xoa", id);
                            }
                            else
                            {
                                Console.WriteLine("Danh sach Trong");
                            }
                        }
                        break;


                }
            } while (true);
        }
            
        static void Main(string[] args)
        {
            
            QLSACH();
            Console.ReadLine();
        }
    }
}
