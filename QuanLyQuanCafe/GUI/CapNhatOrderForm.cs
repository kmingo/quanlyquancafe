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
    public partial class CapNhatOrderForm : Form
    {
        
        DoUongBUS doUongBUS = new DoUongBUS();        
        ChiTietOrderBUS chiTietBUS = new ChiTietOrderBUS();
        DataTable order;
        int ban_dangChon;
        
        public CapNhatOrderForm(DataTable order, int ban_id)
        {
            DataTable doUong_ds = doUongBUS.LayDanhSach();
            this.order = order;
            this.ban_dangChon = ban_id;
            
            InitializeComponent();

            banValue_lb.Text = ban_id.ToString();
            orderIdVal_lb.Text = order.Rows[0].ItemArray[4].ToString();
            //doUong_tBox_1.DataSource = doUong_ds;
            //doUong_cbb_1.DisplayMember = "ten";
            doUong_tBox_1.Text = order.Rows[0].ItemArray[1].ToString();
            //id_tBox_1.DataBindings.Add(new Binding("Text", doUong_ds, "id"));
            id_tBox_1.Text = order.Rows[0].ItemArray[0].ToString();
            soLuong_nm_1.Text = order.Rows[0].ItemArray[2].ToString();
            //dongia_txtBox_1.DataBindings.Add(new Binding("Text", doUong_ds, "dongia"));
            dongia_txtBox_1.Text = order.Rows[0].ItemArray[3].ToString();
            themDoUong_pnl_1.Controls.Add(doUong_tBox_1);
            themDoUong_pnl_1.Controls.Add(id_tBox_1);
            themDoUong_pnl_1.Controls.Add(soLuong_nm_1);
            themDoUong_pnl_1.Controls.Add(dongia_txtBox_1);
            danhSach_pnl.Controls.Add(themDoUong_pnl_1);

            trash_pb_1.Image = new Bitmap(Application.StartupPath + "\\Assets\\trash.png");
            trash_pb_1.SizeMode = PictureBoxSizeMode.Zoom;
            trash_pb_1.Click += trash_pb_Click;

            for (int i = 1; i< order.Rows.Count; i++)
            {
                ThemPanelOrder(i, order);
            }
        }

        void ThemPanelOrder(int i, DataTable order)
        {
            DataTable doUong_dt = doUongBUS.LayDanhSach();
            i++;
            Panel panel = new Panel();
            panel.Name = $"themDoUong_pnl_{i}";
            panel.Size = new Size(themDoUong_pnl_1.Size.Width, themDoUong_pnl_1.Size.Height);
            panel.Location = new Point(themDoUong_pnl_1.Location.X, header_pnl.Height + ((i - 1) * themDoUong_pnl_1.Size.Height));
            danhSach_pnl.Controls.Add(panel);

            TextBox tbox_stt = new TextBox();
            tbox_stt.Name = $"stt_txtBox_{i}";
            tbox_stt.ReadOnly = true;
            tbox_stt.Size = new Size(stt_txtBox_1.Size.Width, stt_txtBox_1.Size.Height);
            panel.Controls.Add(tbox_stt);
            tbox_stt.Location = new Point(stt_txtBox_1.Location.X, stt_txtBox_1.Location.Y);
            tbox_stt.Text = i.ToString();

            TextBox tb_doUong = new TextBox();
            tb_doUong.Name = $"doUong_tBox_{i}";
            tb_doUong.Size = new Size(doUong_tBox_1.Size.Width, doUong_tBox_1.Size.Height);
            tb_doUong.Location = new Point(doUong_tBox_1.Location.X, doUong_tBox_1.Location.Y);
            tb_doUong.Text = order.Rows[i - 1].ItemArray[1].ToString();
            tb_doUong.ReadOnly = true;
            panel.Controls.Add(tb_doUong);
            //cbb.DataSource = doUong_dt;            
            //cbb.DisplayMember = "ten";                  
            
            //cbb.SelectedValueChanged += doUong_cbb_SelectedValueChanged;

            TextBox tb_id = new TextBox();
            tb_id.Name = $"id_tBox_{i}";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(id_tBox_1.Size.Width, id_tBox_1.Size.Height);
            tb_id.Location = new Point(id_tBox_1.Location.X, id_tBox_1.Location.Y);
            panel.Controls.Add(tb_id);
            //tb_id.DataBindings.Add(new Binding("Text", cbb.DataSource, "id"));            
            tb_id.Text = order.Rows[i-1].ItemArray[0].ToString();

            NumericUpDown nm_soLuong = new NumericUpDown();
            nm_soLuong.Name = $"soLuong_nm_{i}";
            nm_soLuong.Value = 1;
            nm_soLuong.Size = new Size(soLuong_nm_1.Width, soLuong_nm_1.Height);
            nm_soLuong.Text = order.Rows[i-1].ItemArray[2].ToString();            
            panel.Controls.Add(nm_soLuong);
            nm_soLuong.Location = new Point(soLuong_nm_1.Location.X, soLuong_nm_1.Location.Y);

            TextBox tbox_donGia = new TextBox();
            tbox_donGia.Name = $"dongia_txtBox_{i}";
            tbox_donGia.ReadOnly = true;
            tbox_donGia.Size = new Size(dongia_txtBox_1.Width, dongia_txtBox_1.Height);
            tbox_donGia.Location = new Point(dongia_txtBox_1.Location.X, dongia_txtBox_1.Location.Y);
            panel.Controls.Add(tbox_donGia);
            //tbox_donGia.DataBindings.Add(new Binding("Text", cbb.DataSource, "dongia"));
            tbox_donGia.Text = order.Rows[i-1].ItemArray[3].ToString();           

            PictureBox pb = new PictureBox();
            pb.Name = $"trash_pb_{i}";
            pb.Size = new Size(trash_pb_1.Width, trash_pb_1.Height);
            pb.Image = new Bitmap(Application.StartupPath + "\\Assets\\trash.png");
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Click += trash_pb_Click;
            panel.Controls.Add(pb);
            pb.Location = new Point(trash_pb_1.Location.X, trash_pb_1.Location.Y);

        }

        private void trash_pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            int dong = int.Parse(pb.Name.Split("_")[2]);
            int doUong_id = int.Parse(danhSach_pnl.Controls[$"themDoUong_pnl_{dong}"].Controls[$"id_tBox_{dong}"].Text);
            chiTietBUS.Xoa(int.Parse(orderIdVal_lb.Text), doUong_id);
            danhSach_pnl.Controls.Remove(danhSach_pnl.Controls[$"themDoUong_pnl_{dong}"]);            
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= order.Rows.Count; i++)
            {
                if (danhSach_pnl.Controls[$"themDoUong_pnl_{i}"] != null)
                {
                    int doUong_id = int.Parse(danhSach_pnl.Controls[$"themDoUong_pnl_{i}"].Controls[$"id_tBox_{i}"].Text);
                    int soLuong = int.Parse(danhSach_pnl.Controls[$"themDoUong_pnl_{i}"].Controls[$"soLuong_nm_{i}"].Text);
                    ChiTietOrder chitiet = new ChiTietOrder(int.Parse(orderIdVal_lb.Text), doUong_id, soLuong);
                    chiTietBUS.CapNhat(chitiet);
                }
                
            }
            this.Close();
        }
        
        private void doUong_cbb_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            DataRowView row = cb.SelectedValue as DataRowView;
            //MessageBox.Show(row);
            int i = int.Parse(cb.Name.Split('_')[2]);

            string id = row.Row.ItemArray[0].ToString();
            TextBox id_tb = danhSach_pnl.Controls[$"themDoUong_pnl_{i}"].Controls[$"id_tBox_{i}"] as TextBox;
            id_tb.Text = id;

            string dongia = row.Row.ItemArray[2].ToString();
            TextBox dongia_tb = danhSach_pnl.Controls[$"themDouong_pnl_{i}"].Controls[$"dongia_txtBox_{i}"] as TextBox;
            dongia_tb.Text = dongia;
        }
    }
}
