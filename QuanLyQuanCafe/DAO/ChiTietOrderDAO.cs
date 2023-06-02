using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class ChiTietOrderDAO : Db
    {
        public DataTable LayDanhSach()
        {
            string sql = "Select * From ChiTietOrder";
            return LayDuLieu(sql);
        }

        public int Them(ChiTietOrder chiTiet)
        {
            string sql = $"Insert Into ChiTietOrder(order_id, douong_id, soluong) Values({chiTiet.OrderId}, {chiTiet.DoUongId}, {chiTiet.SoLuong})";
            return ThucThi(sql);
        }

        public int CapNhat(ChiTietOrder chiTiet)
        {
            string sql = $"Update ChiTietOrder Set soluong={chiTiet.SoLuong} " +
                            $"Where order_id={chiTiet.OrderId} and douong_id={chiTiet.DoUongId}";
            return ThucThi(sql);
        }

        public int Xoa(int orderId, int doUongId)
        {
            string sql = $"Delete From ChiTietOrder Where order_id={orderId} and douong_id={doUongId}";
            return ThucThi(sql);
        }
    }
}
