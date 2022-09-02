using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuanLySach
{
    class QuanLySach
    {
        public List<Book> dssach = new List<Book>();
  private int TangdanID()
        {
            int max = 1;
            if (dssach != null && dssach.Count > 0)
            {
                max = dssach[0].ID;
                foreach (Book sa in dssach)
                {
                    if (sa.ID > max)
                    {
                        max = sa.ID;
                    }
                }
                max++;
            }
            return max;
        }
        public void input()
        {
            Book bk = new Book();
            bk.ID = TangdanID();
            Console.WriteLine("Nhap vao tieu de noi dung:");
            bk.Noidung = Console.ReadLine();
            Console.WriteLine("Nhap vao tac gia:");
            bk.Tacgia = Console.ReadLine();
            Console.WriteLine("Nhap vao Nha xuat Ban:");
            bk.NhaxuatBan = Console.ReadLine();
            Console.WriteLine("Nhap vao Nam san xuat:");
            bk.Namsanxuat = int.Parse(Console.ReadLine());
            dssach.Add(bk);
        }
        public int SoLuong()
        {
            int Count = 0;
            if (dssach != null)
            {
                Count = dssach.Count;
            }
            return Count;
        }
        public void SortByID()
        {
            dssach.Sort(delegate (Book b1, Book b2)
            {
                return b1.ID.CompareTo(b2.ID);
            });
        }
        public void SortByName()
        {
            dssach.Sort(delegate (Book b1, Book b2)
            {
                return b1.Noidung.CompareTo(b2.Noidung);
            });
        }
        public Book TimKiemSach(int ID)
        {
            Book searchsa = null;
            if (dssach != null && dssach.Count > 0)
            {
                foreach (Book sa in dssach)
                {
                    if (sa.ID == ID)
                    {
                        searchsa = sa;
                    }
                }
            }
            return searchsa;
        }
        public void showBook(List<Book> listsach)
        {
            if (listsach != null && listsach.Count > 0)
            {
                foreach (Book bk in listsach)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} ", bk.ID, bk.Noidung, bk.Tacgia, bk.NhaxuatBan, bk.Namsanxuat);
                }
            }
            Console.WriteLine();
        }
        public bool xoathongtin(int ID)
        {
            bool IDDelete = false;
            Book bk = TimKiemSach(ID);
            if(bk!=null)
            {
                IDDelete = dssach.Remove(bk);
            }
            return IDDelete;
        }

        public List<Book> getlistbook()
        {
            return dssach;
        }
        public bool addsach(Book sa)
        {
            bool trungma = false;
            foreach (Book b in dssach)
            {
                if (b.Namsanxuat == sa.Namsanxuat)
                {
                    trungma = true;
                    break;
                }
                if (trungma == true)
                    return false;
            }
            dssach.Add(sa);

            return true;


        }
    }
}
