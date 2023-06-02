
namespace QuanLyQuanCafe.GUI
{
    partial class DoanhThuThangForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baoCao_lb = new System.Windows.Forms.Label();
            this.thang_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrV = new System.Windows.Forms.DataGridView();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam_lb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.namVal_txtB = new System.Windows.Forms.TextBox();
            this.thang_cbb = new System.Windows.Forms.ComboBox();
            this.TongDT_lb = new System.Windows.Forms.Label();
            this.tongDTVal_lb = new System.Windows.Forms.Label();
            this.dong_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // baoCao_lb
            // 
            this.baoCao_lb.AutoSize = true;
            this.baoCao_lb.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baoCao_lb.Location = new System.Drawing.Point(268, 9);
            this.baoCao_lb.Name = "baoCao_lb";
            this.baoCao_lb.Size = new System.Drawing.Size(243, 37);
            this.baoCao_lb.TabIndex = 0;
            this.baoCao_lb.Text = "Báo cáo Doanh thu";
            // 
            // thang_lb
            // 
            this.thang_lb.AutoSize = true;
            this.thang_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thang_lb.Location = new System.Drawing.Point(159, 9);
            this.thang_lb.Name = "thang_lb";
            this.thang_lb.Size = new System.Drawing.Size(41, 15);
            this.thang_lb.TabIndex = 1;
            this.thang_lb.Text = "Tháng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrV);
            this.panel1.Location = new System.Drawing.Point(24, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 283);
            this.panel1.TabIndex = 3;
            // 
            // dataGrV
            // 
            this.dataGrV.AllowUserToAddRows = false;
            this.dataGrV.AllowUserToDeleteRows = false;
            this.dataGrV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngay,
            this.orderId,
            this.hoaDonId,
            this.tongTien});
            this.dataGrV.Location = new System.Drawing.Point(0, 0);
            this.dataGrV.Name = "dataGrV";
            this.dataGrV.RowTemplate.Height = 25;
            this.dataGrV.Size = new System.Drawing.Size(755, 267);
            this.dataGrV.TabIndex = 0;
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngày";
            this.ngay.Name = "ngay";
            this.ngay.Width = 150;
            // 
            // orderId
            // 
            this.orderId.DataPropertyName = "order_id";
            this.orderId.HeaderText = "Id Order";
            this.orderId.Name = "orderId";
            this.orderId.Width = 150;
            // 
            // hoaDonId
            // 
            this.hoaDonId.DataPropertyName = "id";
            this.hoaDonId.HeaderText = "Id Hóa đơn";
            this.hoaDonId.Name = "hoaDonId";
            this.hoaDonId.Width = 150;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongtien";
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.Name = "tongTien";
            this.tongTien.Width = 250;
            // 
            // nam_lb
            // 
            this.nam_lb.AutoSize = true;
            this.nam_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nam_lb.Location = new System.Drawing.Point(349, 9);
            this.nam_lb.Name = "nam_lb";
            this.nam_lb.Size = new System.Drawing.Size(33, 15);
            this.nam_lb.TabIndex = 4;
            this.nam_lb.Text = "Năm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Ok_btn);
            this.panel2.Controls.Add(this.namVal_txtB);
            this.panel2.Controls.Add(this.thang_cbb);
            this.panel2.Controls.Add(this.thang_lb);
            this.panel2.Controls.Add(this.nam_lb);
            this.panel2.Location = new System.Drawing.Point(24, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 36);
            this.panel2.TabIndex = 7;
            // 
            // Ok_btn
            // 
            this.Ok_btn.Location = new System.Drawing.Point(508, 6);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(75, 23);
            this.Ok_btn.TabIndex = 9;
            this.Ok_btn.Text = "OK";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // namVal_txtB
            // 
            this.namVal_txtB.Location = new System.Drawing.Point(388, 6);
            this.namVal_txtB.Name = "namVal_txtB";
            this.namVal_txtB.Size = new System.Drawing.Size(100, 23);
            this.namVal_txtB.TabIndex = 8;
            // 
            // thang_cbb
            // 
            this.thang_cbb.FormattingEnabled = true;
            this.thang_cbb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.thang_cbb.Location = new System.Drawing.Point(206, 6);
            this.thang_cbb.Name = "thang_cbb";
            this.thang_cbb.Size = new System.Drawing.Size(121, 23);
            this.thang_cbb.TabIndex = 7;
            this.thang_cbb.SelectedIndexChanged += new System.EventHandler(this.thang_cbb_SelectedIndexChanged);
            // 
            // TongDT_lb
            // 
            this.TongDT_lb.AutoSize = true;
            this.TongDT_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TongDT_lb.Location = new System.Drawing.Point(24, 377);
            this.TongDT_lb.Name = "TongDT_lb";
            this.TongDT_lb.Size = new System.Drawing.Size(94, 15);
            this.TongDT_lb.TabIndex = 8;
            this.TongDT_lb.Text = "Tổng doanh thu";
            // 
            // tongDTVal_lb
            // 
            this.tongDTVal_lb.AutoSize = true;
            this.tongDTVal_lb.Location = new System.Drawing.Point(125, 376);
            this.tongDTVal_lb.Name = "tongDTVal_lb";
            this.tongDTVal_lb.Size = new System.Drawing.Size(38, 15);
            this.tongDTVal_lb.TabIndex = 9;
            this.tongDTVal_lb.Text = "label1";
            // 
            // dong_btn
            // 
            this.dong_btn.Location = new System.Drawing.Point(704, 410);
            this.dong_btn.Name = "dong_btn";
            this.dong_btn.Size = new System.Drawing.Size(75, 23);
            this.dong_btn.TabIndex = 10;
            this.dong_btn.Text = "Đóng";
            this.dong_btn.UseVisualStyleBackColor = true;
            this.dong_btn.Click += new System.EventHandler(this.dong_btn_Click);
            // 
            // DoanhThuThangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.dong_btn);
            this.Controls.Add(this.tongDTVal_lb);
            this.Controls.Add(this.TongDT_lb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.baoCao_lb);
            this.Name = "DoanhThuThangForm";
            this.Text = "DoanhThuThangForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label baoCao_lb;
        private System.Windows.Forms.Label thang_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrV;
        private System.Windows.Forms.Label nam_lb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox thang_cbb;
        private System.Windows.Forms.TextBox namVal_txtB;
        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoaDonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.Label TongDT_lb;
        private System.Windows.Forms.Label tongDTVal_lb;
        private System.Windows.Forms.Button dong_btn;
    }
}