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
    class BanBUS
    {
        BanDAO banDAO = new BanDAO();
        public DataTable LayDanhSach()
        {
            return banDAO.LayDanhSach();
        }

        public int Them(Ban ban)
        {
            return banDAO.Them(ban);
        }

        public int CapNhat(Ban ban)
        {
            int tinh_trang = 0;
            if(ban.TinhTrang == true)
            {
                tinh_trang = 1;
            }
            return banDAO.CapNhat(ban.Id, tinh_trang);
        }

        public int Xoa(int id)
        {
            return banDAO.Xoa(id);
        }
    }
}
