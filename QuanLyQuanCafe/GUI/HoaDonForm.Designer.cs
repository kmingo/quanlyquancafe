
namespace QuanLyQuanCafe.GUI
{
    partial class HoaDonForm
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
            this.hoaDon_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderIdVal_lb = new System.Windows.Forms.Label();
            this.orderId_lb = new System.Windows.Forms.Label();
            this.ngayVal_lb = new System.Windows.Forms.Label();
            this.ngay_lb = new System.Windows.Forms.Label();
            this.banIdVal_lb = new System.Windows.Forms.Label();
            this.ban_lb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tongVal_lb = new System.Windows.Forms.Label();
            this.tong_lb = new System.Windows.Forms.Label();
            this.order_dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inHD_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // hoaDon_lb
            // 
            this.hoaDon_lb.AutoSize = true;
            this.hoaDon_lb.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoaDon_lb.Location = new System.Drawing.Point(256, 9);
            this.hoaDon_lb.Name = "hoaDon_lb";
            this.hoaDon_lb.Size = new System.Drawing.Size(120, 37);
            this.hoaDon_lb.TabIndex = 0;
            this.hoaDon_lb.Text = "Hóa đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderIdVal_lb);
            this.panel1.Controls.Add(this.orderId_lb);
            this.panel1.Controls.Add(this.ngayVal_lb);
            this.panel1.Controls.Add(this.ngay_lb);
            this.panel1.Controls.Add(this.banIdVal_lb);
            this.panel1.Controls.Add(this.ban_lb);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 39);
            this.panel1.TabIndex = 1;
            // 
            // orderIdVal_lb
            // 
            this.orderIdVal_lb.AutoSize = true;
            this.orderIdVal_lb.Location = new System.Drawing.Point(300, 12);
            this.orderIdVal_lb.Name = "orderIdVal_lb";
            this.orderIdVal_lb.Size = new System.Drawing.Size(38, 15);
            this.orderIdVal_lb.TabIndex = 5;
            this.orderIdVal_lb.Text = "label3";
            // 
            // orderId_lb
            // 
            this.orderId_lb.AutoSize = true;
            this.orderId_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderId_lb.Location = new System.Drawing.Point(236, 12);
            this.orderId_lb.Name = "orderId_lb";
            this.orderId_lb.Size = new System.Drawing.Size(58, 15);
            this.orderId_lb.TabIndex = 4;
            this.orderId_lb.Text = "Mã order";
            // 
            // ngayVal_lb
            // 
            this.ngayVal_lb.AutoSize = true;
            this.ngayVal_lb.Location = new System.Drawing.Point(48, 12);
            this.ngayVal_lb.Name = "ngayVal_lb";
            this.ngayVal_lb.Size = new System.Drawing.Size(38, 15);
            this.ngayVal_lb.TabIndex = 3;
            this.ngayVal_lb.Text = "label2";
            // 
            // ngay_lb
            // 
            this.ngay_lb.AutoSize = true;
            this.ngay_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ngay_lb.Location = new System.Drawing.Point(7, 12);
            this.ngay_lb.Name = "ngay_lb";
            this.ngay_lb.Size = new System.Drawing.Size(35, 15);
            this.ngay_lb.TabIndex = 2;
            this.ngay_lb.Text = "Ngày";
            // 
            // banIdVal_lb
            // 
            this.banIdVal_lb.AutoSize = true;
            this.banIdVal_lb.Location = new System.Drawing.Point(552, 12);
            this.banIdVal_lb.Name = "banIdVal_lb";
            this.banIdVal_lb.Size = new System.Drawing.Size(38, 15);
            this.banIdVal_lb.TabIndex = 1;
            this.banIdVal_lb.Text = "label1";
            // 
            // ban_lb
            // 
            this.ban_lb.AutoSize = true;
            this.ban_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ban_lb.Location = new System.Drawing.Point(503, 12);
            this.ban_lb.Name = "ban_lb";
            this.ban_lb.Size = new System.Drawing.Size(43, 15);
            this.ban_lb.TabIndex = 0;
            this.ban_lb.Text = "Bàn số";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tongVal_lb);
            this.panel2.Controls.Add(this.tong_lb);
            this.panel2.Controls.Add(this.order_dgv);
            this.panel2.Location = new System.Drawing.Point(12, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 277);
            this.panel2.TabIndex = 2;
            // 
            // tongVal_lb
            // 
            this.tongVal_lb.AutoSize = true;
            this.tongVal_lb.Location = new System.Drawing.Point(74, 250);
            this.tongVal_lb.Name = "tongVal_lb";
            this.tongVal_lb.Size = new System.Drawing.Size(38, 15);
            this.tongVal_lb.TabIndex = 2;
            this.tongVal_lb.Text = "label1";
            // 
            // tong_lb
            // 
            this.tong_lb.AutoSize = true;
            this.tong_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tong_lb.Location = new System.Drawing.Point(7, 250);
            this.tong_lb.Name = "tong_lb";
            this.tong_lb.Size = new System.Drawing.Size(60, 15);
            this.tong_lb.TabIndex = 1;
            this.tong_lb.Text = "Tổng tiền";
            // 
            // order_dgv
            // 
            this.order_dgv.AllowUserToAddRows = false;
            this.order_dgv.AllowUserToDeleteRows = false;
            this.order_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.order_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.so_luong,
            this.dongia});
            this.order_dgv.Location = new System.Drawing.Point(7, 0);
            this.order_dgv.Name = "order_dgv";
            this.order_dgv.RowTemplate.Height = 25;
            this.order_dgv.Size = new System.Drawing.Size(583, 237);
            this.order_dgv.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Width = 70;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên đồ uống";
            this.ten.Name = "ten";
            this.ten.Width = 200;
            // 
            // so_luong
            // 
            this.so_luong.DataPropertyName = "soluong";
            this.so_luong.HeaderText = "Số lượng";
            this.so_luong.Name = "so_luong";
            this.so_luong.Width = 120;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.Width = 150;
            // 
            // inHD_btn
            // 
            this.inHD_btn.Location = new System.Drawing.Point(536, 388);
            this.inHD_btn.Name = "inHD_btn";
            this.inHD_btn.Size = new System.Drawing.Size(75, 23);
            this.inHD_btn.TabIndex = 3;
            this.inHD_btn.Text = "In hóa đơn";
            this.inHD_btn.UseVisualStyleBackColor = true;
            this.inHD_btn.Click += new System.EventHandler(this.InHD_btn_Click);
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 424);
            this.Controls.Add(this.inHD_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hoaDon_lb);
            this.Name = "HoaDonForm";
            this.Text = "HoaDonForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoaDon_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label orderIdVal_lb;
        private System.Windows.Forms.Label orderId_lb;
        private System.Windows.Forms.Label ngayVal_lb;
        private System.Windows.Forms.Label ngay_lb;
        private System.Windows.Forms.Label banIdVal_lb;
        private System.Windows.Forms.Label ban_lb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView order_dgv;
        private System.Windows.Forms.Label tongVal_lb;
        private System.Windows.Forms.Label tong_lb;
        private System.Windows.Forms.Button inHD_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
    }
}