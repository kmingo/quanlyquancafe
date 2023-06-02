using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.BUS
{
    class OrderBUS
    {
        OrderDAO orderDAO = new OrderDAO();
        public DataTable LayDanhSach(int ban_id)
        {
            return orderDAO.LayDanhSach(ban_id);
        }

        public DataTable LayDanhSachOrderId(int ban_id)
        {
            return orderDAO.LayDanhSachOrderId(ban_id);
        }

        public int Them(Order order)
        {
            return orderDAO.Them(order);
        }

        public int CapNhat(int banId, int orderId, int thanhtoan)
        {
            return orderDAO.CapNhat(banId, orderId, thanhtoan);
        }

        public int Xoa(int id)
        {
            return orderDAO.Xoa(id);
        }
    }
}
