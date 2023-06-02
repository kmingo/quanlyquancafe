
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class BanDAO : Db
    {
        public DataTable LayDanhSach()
        {
            string sql = "Select * From Ban";
            return LayDuLieu(sql);
        }

        public int Them(Ban ban)
        {
            string sql = $"Insert Into Ban(tinh_trang) Values({ban.TinhTrang})";
            return ThucThi(sql);
        }

        public int CapNhat(int banId, int tinhTrang)
        {
            string sql = $"Update Ban Set tinh_trang={tinhTrang} Where id={banId}";
            return ThucThi(sql);
        }

        public int Xoa(int id)
        {
            string sql = $"Delete From Ban Where id={id}";
            return ThucThi(sql);
        }
    }
}
