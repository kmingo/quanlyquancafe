using QuanLyQuanCafe.BUS;
using QuanLyQuanCafe.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class TrangChuForm : Form
    {
        OrderBUS orderBUS = new OrderBUS();
        BanBUS banBUS = new BanBUS();
        ImageList largeImageList;
        DataTable order_hienTai;
        private int ban_dangChon;
        
        public TrangChuForm()
        {
            InitializeComponent();
            grvOrder.Visible = false;
            ban_order.Visible = false;
            tao_order_btn.Visible = false;
            them_mon_btn.Visible = false;
            idNgay_pnl.Visible = false;
            thanhtoan_btn.Visible = false;
            capNhat_btn.Visible = false;
            //LayDanhSachBan();
        }

        void LayDanhSachBan() 
        {
            TableListView.Clear();            
            DataTable ban_dt = banBUS.LayDanhSach();
            LayDanhSachImage();
            TableListView.LargeImageList = largeImageList;            
            
            for (int i = 0; i< ban_dt.Rows.Count; i++)
            {                
                ListViewItem item = new ListViewItem();
                item.Name = ban_dt.Rows[i].ItemArray[0].ToString();
                if ((bool)ban_dt.Rows[i].ItemArray[1] == true)
                {
                    item.Text = $"Bàn {ban_dt.Rows[i].ItemArray[0]} \n(Có khách)";
                    item.ImageIndex = 1;
                }
                else 
                {
                    item.Text = $"Bàn {ban_dt.Rows[i].ItemArray[0]} \n(Trống)";
                    item.ImageIndex = 0; 
                }
                TableListView.Items.Add(item);
            }
        }

        void LayDanhSachImage()
        {
            largeImageList = new ImageList() { ImageSize = new Size(60, 40) };
            largeImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Assets\\empty_table.png"));
            largeImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Assets\\ordered_table.png"));
        }
        private void TableListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LayDanhSachImage();
            ListView tableListView = sender as ListView;
           if(tableListView.SelectedItems.Count > 0)
            {
                //Lấy dữ liệu                              
                int ban_id = int.Parse(TableListView.SelectedItems[0].Name);
                ban_dangChon = ban_id;
                ban_order.Visible = true;
                LayOrderCuaBan(ban_id);
            }  
        }

        void LayOrderCuaBan(int ban_id)
        {
            DataTable order = orderBUS.LayDanhSach(ban_id);
            order_hienTai = order;
            if (order.Rows.Count < 1)
            {
                if(ban_id == 0)
                {
                    tao_order_btn.Visible = false;
                }
                else
                {
                    tao_order_btn.Visible = true;
                }
                ban_order.Location = new Point(207, 10);
                ban_order.Text = $"Bàn {ban_id} Trống";
                
                them_mon_btn.Visible = false;
                grvOrder.Visible = false;
                idNgay_pnl.Visible = false;
                capNhat_btn.Visible = false;
                thanhtoan_btn.Visible = false;
            }
            else
            {
                idNgay_pnl.Visible = true;
                tao_order_btn.Visible = false;
                them_mon_btn.Visible = true;
                capNhat_btn.Visible = true;
                grvOrder.DataSource = order;
                grvOrder.Visible = true;
                ban_order.Location = new Point(100, 10);
                ban_order.Text = $"Danh sách đồ uống bàn {ban_id}";
                orderIdVal_lb.Text = order.Rows[0].ItemArray[4].ToString();
                ngayVal_lb.Text = order.Rows[0].ItemArray[5].ToString();
                grvOrder.Columns[4].Visible = false;
                grvOrder.Columns[5].Visible = false;
                thanhtoan_btn.Visible = true;
            }
        }

        private void tao_order_btn_Clicked(object sender, EventArgs e)
        {
            ThemOrderForm themOrderForm = new ThemOrderForm(ban_dangChon, this);
            themOrderForm.Show();
        }

        private void ThemDoUongOrder_btn_Click(object sender, EventArgs e)
        {
            ThemDoUongOrderForm themDoUongOrderForm = new ThemDoUongOrderForm(ban_dangChon, int.Parse(orderIdVal_lb.Text));
            themDoUongOrderForm.Show();
        }

        private void TrangChuForm_Activated(object sender, EventArgs e)
        {
            LayDanhSachBan();
            LayOrderCuaBan(ban_dangChon);
        }

        private void thanhtoan_btn_Click(object sender, EventArgs e)
        {
            HoaDonForm hoaDonForm = new HoaDonForm(ban_dangChon, int.Parse(orderIdVal_lb.Text), grvOrder.DataSource as DataTable);
            hoaDonForm.Show();
        }

        private void baoCao_btn_Click(object sender, EventArgs e)
        {
            DoanhThuThangForm doanhThuThangForm = new DoanhThuThangForm();
            doanhThuThangForm.Show();
        }

        private void capNhat_btn_Click(object sender, EventArgs e)
        {
            CapNhatOrderForm capNhatOrderForm = new CapNhatOrderForm(order_hienTai, ban_dangChon);
            capNhatOrderForm.Show();
        }
    }
}
