using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    class Ban
    {
        public int Id { get; set; }        
        public bool TinhTrang { get; set; }

        public Ban(int id, bool tinhTrang)
        {
            this.Id = id;            
            this.TinhTrang = tinhTrang;
        }
    }
}
