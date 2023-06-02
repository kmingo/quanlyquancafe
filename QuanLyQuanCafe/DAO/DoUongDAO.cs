using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class DoUongDAO : Db
    {
        public DataTable LayDanhSach()
        {
            string sql = "Select * From DoUong";
            return LayDuLieu(sql);
        }

        public int Them(DoUong doUong)
        {
            string sql = $"Insert Into DoUong(ten, dongia) Values('{doUong.Ten}', {doUong.DonGia})";
            return ThucThi(sql);
        }

        public int CapNhat(DoUong doUong)
        {
            string sql = $"Update DoUong Set ten='{doUong.Ten}', dongia={doUong.DonGia} Where id={doUong.Id}";
            return ThucThi(sql);
        }

        public int Xoa(int id)
        {
            string sql = $"Delete From DoUong Where id={id}";
            return ThucThi(sql);
        }
    }
}
