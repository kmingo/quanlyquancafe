using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class Db
    {
        string duong_dan = @"Data Source=ADMIN;Initial Catalog=quan_cafe;Integrated Security=True";

        public DataTable LayDuLieu(string sql)
        {
            
            SqlConnection ket_noi = new SqlConnection(duong_dan);
            SqlDataAdapter bo_chuyen_doi = new SqlDataAdapter(sql, ket_noi);

            DataTable order_table = new DataTable();
            bo_chuyen_doi.Fill(order_table);

            return order_table;
        }

        public int ThucThi(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(duong_dan);

            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            ket_noi.Open();
            var rs = lenh.ExecuteNonQuery();
            ket_noi.Close();

            return rs;
        }
    }
}
