using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPQuanLySach
{
    interface IBook
    {
      
        int ID { get; set; }
        string Noidung { get; set; }
        string Tacgia { get; set; }
        string NhaxuatBan { get; set; }
         int  Namsanxuat { get; set; }

       string ToString();
        


    }
}
