using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    class HoaDon
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int TongTien { get; set; }
        public HoaDon(int orderId, int tongTien)
        {
            this.OrderId = orderId;
            this.TongTien = tongTien;
        }
    }
}
