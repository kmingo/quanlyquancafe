using QuanLyQuanCafe.BUS;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.GUI
{
    public partial class ThemDoUongOrderForm : Form
    {
        private int BanId { get; set; }
        private int OrderId { get; set; }
        DoUongBUS doUongBUS = new DoUongBUS();
        ChiTietOrderBUS chiTietBUS = new ChiTietOrderBUS();
        public ThemDoUongOrderForm(int banId, int orderId)
        {
            this.BanId = banId;
            this.OrderId = orderId;

            InitializeComponent();
            banVal_lb.Text = banId.ToString();
            orderIdVal_lb.Text = orderId.ToString();
            DataTable ds_doUong = doUongBUS.LayDanhSach();
            doUong_cbb.DataSource = ds_doUong;
            doUong_cbb.DisplayMember = "ten";
            doUongId_txtB.DataBindings.Add(new Binding("Text", ds_doUong, "id"));
            donGia_txtB.DataBindings.Add(new Binding("Text", ds_doUong, "dongia"));
        }
        
        private void themOk_btn_Click(object sender, EventArgs e)
        {
            ChiTietOrder chiTiet = new ChiTietOrder(this.OrderId, int.Parse(doUongId_txtB.Text), int.Parse(soLuong_nm.Text));
            chiTietBUS.Them(chiTiet);
            this.Close();
        }
    }
}
