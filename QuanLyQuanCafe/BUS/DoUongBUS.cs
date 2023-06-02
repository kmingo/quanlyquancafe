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
    class DoUongBUS
    {
        DoUongDAO doUongDAO = new DoUongDAO();
        public DataTable LayDanhSach()
        {         
            return doUongDAO.LayDanhSach();
        }

        public int Them(DoUong doUong)
        {
            return doUongDAO.Them(doUong);
        }

        public int CapNhat(DoUong doUong)
        {
            return doUongDAO.CapNhat(doUong);
        }

        public int Xoa(int id)
        {
            return doUongDAO.Xoa(id);
        }
    }
}
