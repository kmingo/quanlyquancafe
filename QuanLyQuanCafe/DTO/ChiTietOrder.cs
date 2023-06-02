using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    class ChiTietOrder
    {
        public int OrderId { get; set; }
        public int DoUongId { get; set; }
        public int SoLuong { get; set; }
        public ChiTietOrder(int orderId, int doUongId, int soLuong)
        {
            this.OrderId = orderId;
            this.DoUongId = doUongId;
            this.SoLuong = soLuong;
        }
    }
}
