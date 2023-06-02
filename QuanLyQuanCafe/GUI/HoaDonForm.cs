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
    public partial class HoaDonForm : Form
    {
        private int OrderId { get; set; }
        private int BanId { get; set; }
        BanBUS banBUS = new BanBUS();
        OrderBUS orderBUS = new OrderBUS();
        HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private string NgayOrder { get; set; }

        public HoaDonForm(int ban_id, int order_id, DataTable order)
        {
            this.OrderId = order_id;
            this.BanId = ban_id;
            this.NgayOrder = order.Rows[0].ItemArray[5].ToString();
            InitializeComponent();

            ngayVal_lb.Text = DateTime.Now.ToString();
            orderIdVal_lb.Text = order_id.ToString();
            banIdVal_lb.Text = ban_id.ToString();
            order_dgv.DataSource = order;
            order_dgv.Columns[4].Visible = false;
            order_dgv.Columns[5].Visible = false;
            int tongTien = 0;
            for(int i = 0; i<order_dgv.Rows.Count; i++)
            {
                tongTien += int.Parse(order.Rows[i].ItemArray[2].ToString()) * int.Parse(order.Rows[i].ItemArray[3].ToString());
            }
            tongVal_lb.Text = tongTien.ToString();
        }

        private void InHD_btn_Click(object sender, EventArgs e)
        {
            Ban ban = new Ban(this.BanId, false);
            banBUS.CapNhat(ban);
            
            orderBUS.CapNhat(this.BanId, this.OrderId, 1);
            HoaDon hd = new HoaDon(this.OrderId, int.Parse(tongVal_lb.Text));
            hoaDonBUS.Them(hd);
            this.Close();
        }
    }
}
