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
    class HoaDonBUS
    {
        HoaDonDAO hoaDonDAO = new HoaDonDAO();
        public DataTable LayDanhSach(int thang, int nam)
        {
            
            return hoaDonDAO.LayDanhSach(thang, nam);
        }

        public int Them(HoaDon hoaDon)
        {
            return hoaDonDAO.Them(hoaDon);
        }

        public int CapNhat(HoaDon hoaDon)
        {
            return hoaDonDAO.CapNhat(hoaDon);
        }

        public int Xoa(int id)
        {
            return hoaDonDAO.Xoa(id);
        }
    }
}
