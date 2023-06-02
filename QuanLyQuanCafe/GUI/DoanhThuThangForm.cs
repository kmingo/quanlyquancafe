using QuanLyQuanCafe.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.GUI
{
   
    public partial class DoanhThuThangForm : Form
    {
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        public DoanhThuThangForm()
        {           
            InitializeComponent();
            dataGrV.Visible = false;
            namVal_txtB.Text = DateTime.Now.Year.ToString();
            thang_cbb.Text = DateTime.Now.Month.ToString();
            TongDT_lb.Visible = false;
            tongDTVal_lb.Visible = false;
        }

        private void thang_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                int thang = int.Parse(thang_cbb.Text);
                int nam = int.Parse(namVal_txtB.Text);
                DataTable ds_hoaDon = hoaDonBUS.LayDanhSach(thang, nam);
                dataGrV.DataSource = ds_hoaDon;
                dataGrV.Visible = true;
                int doanhThu = 0;
                for (int i = 0; i < ds_hoaDon.Rows.Count; i++)
                {
                    doanhThu += int.Parse(ds_hoaDon.Rows[i].ItemArray[3].ToString());
                }
                TongDT_lb.Visible = true;
                tongDTVal_lb.Visible = true;
                tongDTVal_lb.Text = doanhThu.ToString();
            }
            
        }

        bool ValidateForm()
        {
            if (thang_cbb.Text == "" || namVal_txtB.Text == "")
            {
                MessageBox.Show("Vui lòng cho biết tháng và năm cần lập báo cáo!");
                return false;
            }
            
            if (Regex.Match(thang_cbb.Text, "[0-9]").Success && Regex.Match(namVal_txtB.Text, "[0-9]").Success)
            {                
                if(thang_cbb.Text.Length > 2 || namVal_txtB.Text.Length!= 4)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng tháng và năm!");
                    return false;
                }
                return true;
            }
            MessageBox.Show("Vui lòng nhập đúng định dạng tháng và năm!");
            return false;
        }

        private void dong_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
