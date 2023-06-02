using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class OrderDAO : Db
    {
        public DataTable LayDanhSach(int ban_id)
        {
            string sql = "Select DoUong.id, DoUong.ten, ChiTietOrder.soluong, DoUong.dongia, [Order].id, [Order].ngay " +
                                "from [Order], ChiTietOrder, DoUong " +
                                $"where [Order].ban_id={ban_id} " +
                                "and [Order].thanhtoan=0 " +
                                "and ChiTietOrder.order_id=[Order].id " +
                                "and ChiTietOrder.douong_id=DoUong.id";
            return LayDuLieu(sql);
        }

        public DataTable LayDanhSachOrderId(int ban_id)
        {
            string sql = $"Select [Order].id from [Order] where [Order].ban_id={ban_id}";
            return LayDuLieu(sql);
        }
        public int Them(Order order)
        {
            string sql = $"Insert Into [Order](ngay, ban_id, thanhtoan) Values('{order.Ngay}', {order.BanId}, {order.ThanhToan})";
            return ThucThi(sql);
        }

        public int CapNhat(int banId, int orderId, int thanhtoan)
        {
            string sql = $"Update [Order] Set ban_id={banId}, thanhtoan={thanhtoan} Where id={orderId}";
            return ThucThi(sql);
        }

        public int Xoa(int id)
        {
            string sql = $"Delete From [Order] Where id={id}";
            return ThucThi(sql);
        }
    }
}
