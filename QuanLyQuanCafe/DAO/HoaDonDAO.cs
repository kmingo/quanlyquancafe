using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class HoaDonDAO : Db
    {
        public DataTable LayDanhSach(int thang, int nam)
        {
            string sql = "Select [Order].ngay, HoaDon.order_id, HoaDon.id, HoaDon.tongtien From [Order], HoaDon " +
                $"where HoaDon.order_id=[Order].id and [Order].ngay LIKE '%[/]{thang}[/]{nam}%'";
            return LayDuLieu(sql);
        }

        public int Them(HoaDon hoaDon)
        {
            string sql = $"Insert Into HoaDon(order_id, tongtien) Values({hoaDon.OrderId}, {hoaDon.TongTien})";
            return ThucThi(sql);
        }

        public int CapNhat(HoaDon hoaDon)
        {
            string sql = $"Update HoaDon Set order_id={hoaDon.OrderId}, tongtien={hoaDon.TongTien} Where id={hoaDon.Id}";
            return ThucThi(sql);
        }

        public int Xoa(int id)
        {
            string sql = $"Delete From HoaDon Where id={id}";
            return ThucThi(sql);
        }
    }
}
