
namespace QuanLyQuanCafe
{
    partial class TrangChuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuForm));
            this.TableListView = new System.Windows.Forms.ListView();
            this.TableIcon = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ban_order = new System.Windows.Forms.Label();
            this.them_mon_btn = new System.Windows.Forms.Button();
            this.grvOrder = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tao_order_btn = new System.Windows.Forms.Button();
            this.orderId_lb = new System.Windows.Forms.Label();
            this.orderIdVal_lb = new System.Windows.Forms.Label();
            this.ngay_lb = new System.Windows.Forms.Label();
            this.ngayVal_lb = new System.Windows.Forms.Label();
            this.idNgay_pnl = new System.Windows.Forms.Panel();
            this.thanhtoan_btn = new System.Windows.Forms.Button();
            this.baoCao_btn = new System.Windows.Forms.Button();
            this.capNhat_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).BeginInit();
            this.idNgay_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableListView
            // 
            this.TableListView.HideSelection = false;
            this.TableListView.LargeImageList = this.TableIcon;
            this.TableListView.Location = new System.Drawing.Point(12, 12);
            this.TableListView.Name = "TableListView";
            this.TableListView.Size = new System.Drawing.Size(315, 384);
            this.TableListView.TabIndex = 0;
            this.TableListView.UseCompatibleStateImageBehavior = false;
            this.TableListView.SelectedIndexChanged += new System.EventHandler(this.TableListView_SelectedIndexChanged);
            // 
            // TableIcon
            // 
            this.TableIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.TableIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TableIcon.ImageStream")));
            this.TableIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.TableIcon.Images.SetKeyName(0, "empty_table.png");
            this.TableIcon.Images.SetKeyName(1, "ordered_table.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.capNhat_btn);
            this.panel1.Controls.Add(this.ban_order);
            this.panel1.Controls.Add(this.them_mon_btn);
            this.panel1.Controls.Add(this.grvOrder);
            this.panel1.Controls.Add(this.tao_order_btn);
            this.panel1.Location = new System.Drawing.Point(333, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 414);
            this.panel1.TabIndex = 1;
            // 
            // ban_order
            // 
            this.ban_order.AutoSize = true;
            this.ban_order.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ban_order.Location = new System.Drawing.Point(208, 0);
            this.ban_order.Name = "ban_order";
            this.ban_order.Size = new System.Drawing.Size(90, 37);
            this.ban_order.TabIndex = 4;
            this.ban_order.Text = "label1";
            this.ban_order.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // them_mon_btn
            // 
            this.them_mon_btn.Location = new System.Drawing.Point(0, 108);
            this.them_mon_btn.Name = "them_mon_btn";
            this.them_mon_btn.Size = new System.Drawing.Size(103, 23);
            this.them_mon_btn.TabIndex = 3;
            this.them_mon_btn.Text = "Thêm đồ uống";
            this.them_mon_btn.UseVisualStyleBackColor = true;
            this.them_mon_btn.Click += new System.EventHandler(this.ThemDoUongOrder_btn_Click);
            // 
            // grvOrder
            // 
            this.grvOrder.AllowUserToAddRows = false;
            this.grvOrder.AllowUserToDeleteRows = false;
            this.grvOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.soluong,
            this.dongia});
            this.grvOrder.Location = new System.Drawing.Point(0, 134);
            this.grvOrder.Name = "grvOrder";
            this.grvOrder.RowTemplate.Height = 25;
            this.grvOrder.Size = new System.Drawing.Size(528, 250);
            this.grvOrder.TabIndex = 1;
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
            this.ten.HeaderText = "Tên Món";
            this.ten.Name = "ten";
            this.ten.Width = 190;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.Width = 120;
            // 
            // tao_order_btn
            // 
            this.tao_order_btn.Location = new System.Drawing.Point(0, 14);
            this.tao_order_btn.Name = "tao_order_btn";
            this.tao_order_btn.Size = new System.Drawing.Size(75, 23);
            this.tao_order_btn.TabIndex = 0;
            this.tao_order_btn.Text = "Tạo order";
            this.tao_order_btn.UseVisualStyleBackColor = true;
            this.tao_order_btn.Click += new System.EventHandler(this.tao_order_btn_Clicked);
            // 
            // orderId_lb
            // 
            this.orderId_lb.AutoSize = true;
            this.orderId_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderId_lb.Location = new System.Drawing.Point(17, 12);
            this.orderId_lb.Name = "orderId_lb";
            this.orderId_lb.Size = new System.Drawing.Size(58, 15);
            this.orderId_lb.TabIndex = 5;
            this.orderId_lb.Text = "Mã order";
            // 
            // orderIdVal_lb
            // 
            this.orderIdVal_lb.AutoSize = true;
            this.orderIdVal_lb.Location = new System.Drawing.Point(81, 12);
            this.orderIdVal_lb.Name = "orderIdVal_lb";
            this.orderIdVal_lb.Size = new System.Drawing.Size(38, 15);
            this.orderIdVal_lb.TabIndex = 6;
            this.orderIdVal_lb.Text = "label1";
            // 
            // ngay_lb
            // 
            this.ngay_lb.AutoSize = true;
            this.ngay_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ngay_lb.Location = new System.Drawing.Point(362, 12);
            this.ngay_lb.Name = "ngay_lb";
            this.ngay_lb.Size = new System.Drawing.Size(35, 15);
            this.ngay_lb.TabIndex = 7;
            this.ngay_lb.Text = "Ngày";
            // 
            // ngayVal_lb
            // 
            this.ngayVal_lb.AutoSize = true;
            this.ngayVal_lb.Location = new System.Drawing.Point(403, 12);
            this.ngayVal_lb.Name = "ngayVal_lb";
            this.ngayVal_lb.Size = new System.Drawing.Size(38, 15);
            this.ngayVal_lb.TabIndex = 8;
            this.ngayVal_lb.Text = "label1";
            // 
            // idNgay_pnl
            // 
            this.idNgay_pnl.Controls.Add(this.orderId_lb);
            this.idNgay_pnl.Controls.Add(this.ngayVal_lb);
            this.idNgay_pnl.Controls.Add(this.orderIdVal_lb);
            this.idNgay_pnl.Controls.Add(this.ngay_lb);
            this.idNgay_pnl.Location = new System.Drawing.Point(333, 62);
            this.idNgay_pnl.Name = "idNgay_pnl";
            this.idNgay_pnl.Size = new System.Drawing.Size(528, 37);
            this.idNgay_pnl.TabIndex = 9;
            // 
            // thanhtoan_btn
            // 
            this.thanhtoan_btn.Location = new System.Drawing.Point(786, 403);
            this.thanhtoan_btn.Name = "thanhtoan_btn";
            this.thanhtoan_btn.Size = new System.Drawing.Size(75, 23);
            this.thanhtoan_btn.TabIndex = 10;
            this.thanhtoan_btn.Text = "Thanh toán";
            this.thanhtoan_btn.UseVisualStyleBackColor = true;
            this.thanhtoan_btn.Click += new System.EventHandler(this.thanhtoan_btn_Click);
            // 
            // baoCao_btn
            // 
            this.baoCao_btn.Location = new System.Drawing.Point(12, 403);
            this.baoCao_btn.Name = "baoCao_btn";
            this.baoCao_btn.Size = new System.Drawing.Size(121, 23);
            this.baoCao_btn.TabIndex = 11;
            this.baoCao_btn.Text = "Doanh thu tháng";
            this.baoCao_btn.UseVisualStyleBackColor = true;
            this.baoCao_btn.Click += new System.EventHandler(this.baoCao_btn_Click);
            // 
            // capNhat_btn
            // 
            this.capNhat_btn.Location = new System.Drawing.Point(453, 108);
            this.capNhat_btn.Name = "capNhat_btn";
            this.capNhat_btn.Size = new System.Drawing.Size(75, 23);
            this.capNhat_btn.TabIndex = 5;
            this.capNhat_btn.Text = "Cập nhật";
            this.capNhat_btn.UseVisualStyleBackColor = true;
            this.capNhat_btn.Click += new System.EventHandler(this.capNhat_btn_Click);
            // 
            // TrangChuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 459);
            this.Controls.Add(this.baoCao_btn);
            this.Controls.Add(this.thanhtoan_btn);
            this.Controls.Add(this.idNgay_pnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TableListView);
            this.Name = "TrangChuForm";
            this.Text = "Trang chủ";
            this.Activated += new System.EventHandler(this.TrangChuForm_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrder)).EndInit();
            this.idNgay_pnl.ResumeLayout(false);
            this.idNgay_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView TableListView;
        private System.Windows.Forms.ImageList TableIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tao_order_btn;
        private System.Windows.Forms.DataGridView grvOrder;
        private System.Windows.Forms.Button them_mon_btn;
        private System.Windows.Forms.Label ban_order;
        private System.Windows.Forms.Label ngayVal_lb;
        private System.Windows.Forms.Label ngay_lb;
        private System.Windows.Forms.Label orderIdVal_lb;
        private System.Windows.Forms.Label orderId_lb;
        private System.Windows.Forms.Panel idNgay_pnl;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.Button thanhtoan_btn;
        private System.Windows.Forms.Button baoCao_btn;
        private System.Windows.Forms.Button capNhat_btn;
    }
}

