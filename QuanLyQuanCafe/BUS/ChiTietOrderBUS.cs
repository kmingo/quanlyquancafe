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
    class ChiTietOrderBUS
    {
        ChiTietOrderDAO chiTietDAO = new ChiTietOrderDAO();
        public DataTable LayDanhSach()
        {
            return chiTietDAO.LayDanhSach();
        }

        public int Them(ChiTietOrder chiTiet)
        {
            return chiTietDAO.Them(chiTiet);
        }

        public int CapNhat(ChiTietOrder chiTiet)
        {
            return chiTietDAO.CapNhat(chiTiet);
        }

        public int Xoa(int orderId, int doUongId)
        {
            return chiTietDAO.Xoa(orderId, doUongId);
        }
    }
}
