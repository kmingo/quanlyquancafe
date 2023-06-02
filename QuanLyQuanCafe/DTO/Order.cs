using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    class Order
    {
        public int Id { get; set; }
        public string Ngay { get; set; }
        public int BanId { get; set; }
        public int ThanhToan { get; set; }
        public Order(string ngay, int banId, int thanhToan)
        {
            this.Ngay = ngay;
            this.BanId = banId;
            this.ThanhToan = thanhToan;
        }
    }
}
