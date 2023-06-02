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
    public partial class ThemOrderForm : Form
    {
        private int stt;
        private int BanId { get; set; }
        private TrangChuForm trangChuForm;
        DoUongBUS doUongBUS = new DoUongBUS();
        OrderBUS orderBUS = new OrderBUS();
        ChiTietOrderBUS chiTietBUS = new ChiTietOrderBUS();
        BanBUS banBUS = new BanBUS();
        DataTable orders;
        public ThemOrderForm(int banId, TrangChuForm trangChu)
        {
            this.trangChuForm = trangChu;
            stt = 1;
            DataTable doUong_dt = doUongBUS.LayDanhSach();
            this.BanId = banId;

            InitializeComponent();

            ngayValue_lb.Text = DateTime.Now.ToString();
            banValue_lb.Text = banId.ToString();

            doUong_cbb_1.DataSource = doUong_dt;
            doUong_cbb_1.DisplayMember = "ten";

            stt_txtBox_1.Text = stt.ToString();
            dongia_txtBox_1.DataBindings.Add(new Binding("Text", doUong_cbb_1.DataSource, "dongia"));

            id_tBox_1.DataBindings.Add(new Binding("Text", doUong_cbb_1.DataSource, "id"));
            //id_tBox_1.Visible = false;

            trash_pb_1.Image = new Bitmap(Application.StartupPath + "\\Assets\\trash.png");
            trash_pb_1.SizeMode = PictureBoxSizeMode.Zoom;
            trash_pb_1.Click += trash_pb_Click;
        }

        private void trash_pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            int dong = int.Parse(pb.Name.Split("_")[2]);
            danhSach_pnl.Controls.Remove(danhSach_pnl.Controls[$"themDoUong_pnl_{dong}"]);
        }
        private void taoOk_btn_Clicked(object sender, EventArgs e)
        {
            Order order = new Order(ngayValue_lb.Text, int.Parse(banValue_lb.Text), 0);
            orderBUS.Them(order);
            this.orders = orderBUS.LayDanhSachOrderId(int.Parse(banValue_lb.Text));
            int idOrder_hienTai = (int)orders.Rows[orders.Rows.Count - 1].ItemArray[0];
            for (int i=1; i<=stt; i++)
            {
                if (danhSach_pnl.Controls[$"themDoUong_pnl_{i}"] != null) 
                {
                    int doUong_id = int.Parse(danhSach_pnl.Controls[$"themDoUong_pnl_{i}"].Controls[$"id_tBox_{i}"].Text);
                    int soLuong = int.Parse(danhSach_pnl.Controls[$"themDoUong_pnl_{i}"].Controls[$"soLuong_nm_{i}"].Text);
                    ChiTietOrder chiTiet = new ChiTietOrder(idOrder_hienTai, doUong_id, soLuong);
                    chiTietBUS.Them(chiTiet);
                }                
            }
            Ban ban = new Ban(this.BanId, true);
            banBUS.CapNhat(ban);          
            this.Close();            
        }

        private void them_doUong_btn_Click(object sender, EventArgs e)
        {
            ThemPanelOrder();
        }

        void ThemPanelOrder()
        {
            DataTable doUong_dt = doUongBUS.LayDanhSach();
            stt++;
            Panel panel = new Panel();
            panel.Name = $"themDoUong_pnl_{stt}";
            panel.Size = new Size(themDoUong_pnl_1.Size.Width, themDoUong_pnl_1.Size.Height);
            panel.Location = new Point(themDoUong_pnl_1.Location.X, header_pnl.Height + ((stt - 1) * themDoUong_pnl_1.Size.Height));
            danhSach_pnl.Controls.Add(panel);

            TextBox tbox_stt = new TextBox();
            tbox_stt.Name = $"stt_txtBox_{stt}";
            tbox_stt.ReadOnly = true;
            tbox_stt.Size = new Size(stt_txtBox_1.Size.Width, stt_txtBox_1.Size.Height);
            panel.Controls.Add(tbox_stt);
            tbox_stt.Location = new Point(stt_txtBox_1.Location.X, stt_txtBox_1.Location.Y);
            tbox_stt.Text = stt.ToString();

            ComboBox cbb = new ComboBox();
            cbb.Name = $"doUong_cbb_{stt}";
            cbb.Size = new Size(doUong_cbb_1.Size.Width, doUong_cbb_1.Size.Height);
            cbb.DataSource = doUong_dt;
            cbb.DisplayMember = "ten";
            panel.Controls.Add(cbb);
            cbb.Location = new Point(doUong_cbb_1.Location.X, doUong_cbb_1.Location.Y);

            TextBox tb_id = new TextBox();
            tb_id.Name = $"id_tBox_{stt}";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(id_tBox_1.Size.Width, id_tBox_1.Size.Height);
            panel.Controls.Add(tb_id);
            tb_id.DataBindings.Add(new Binding("Text", cbb.DataSource, "id"));
            tb_id.Location = new Point(id_tBox_1.Location.X, id_tBox_1.Location.Y);
            
            NumericUpDown nm_soLuong = new NumericUpDown();
            nm_soLuong.Name = $"soLuong_nm_{stt}";
            nm_soLuong.Value = 1;
            nm_soLuong.Size = new Size(soLuong_nm_1.Width, soLuong_nm_1.Height);
            panel.Controls.Add(nm_soLuong);
            nm_soLuong.Location = new Point(soLuong_nm_1.Location.X, soLuong_nm_1.Location.Y);

            TextBox tbox_donGia = new TextBox();
            tbox_donGia.Name = $"dongia_txtBox_{stt}";
            tbox_donGia.ReadOnly = true;
            tbox_donGia.Size = new Size(dongia_txtBox_1.Width, dongia_txtBox_1.Height);
            tbox_donGia.DataBindings.Add(new Binding("Text", cbb.DataSource, "dongia"));
            panel.Controls.Add(tbox_donGia);
            tbox_donGia.Location = new Point(dongia_txtBox_1.Location.X, dongia_txtBox_1.Location.Y);

            PictureBox pb = new PictureBox();
            pb.Name = $"trash_pb_{stt}";
            pb.Size = new Size(trash_pb_1.Width, trash_pb_1.Height);
            pb.Image = new Bitmap(Application.StartupPath + "\\Assets\\trash.png");
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Click += trash_pb_Click;
            panel.Controls.Add(pb);
            pb.Location = new Point(trash_pb_1.Location.X, trash_pb_1.Location.Y);   
 
        }
    }
}
