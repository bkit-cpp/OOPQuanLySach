using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuanLySach
{
     class Book:IBook
    {
      
       public int ID { get; set; }
      public  string Noidung { get; set; }
       public  string Tacgia { get; set; }
        public string NhaxuatBan { get; set; }
        public int Namsanxuat { get; set; }
        public Book() {
           
                }
        public Book(int ID,string Noidung ,string Tacgia, string NhaxuatBan, int Namsanxuat)
        {
            this.ID = ID;
            this.Noidung = Noidung;
            this.Tacgia = Tacgia;
            this.NhaxuatBan = NhaxuatBan;
            this.Namsanxuat = Namsanxuat;
        }
        
       /* public Book suasach(string )
        {

        }*/
       

    }
}
