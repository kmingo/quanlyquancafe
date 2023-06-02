
namespace QuanLyQuanCafe.GUI
{
    partial class ThemOrderForm
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
            this.taoOrder_lb = new System.Windows.Forms.Label();
            this.ngay_lb = new System.Windows.Forms.Label();
            this.ngayValue_lb = new System.Windows.Forms.Label();
            this.ban_lb = new System.Windows.Forms.Label();
            this.banValue_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.danhSach_pnl = new System.Windows.Forms.Panel();
            this.themDoUong_pnl_1 = new System.Windows.Forms.Panel();
            this.soLuong_nm_1 = new System.Windows.Forms.NumericUpDown();
            this.id_tBox_1 = new System.Windows.Forms.TextBox();
            this.trash_pb_1 = new System.Windows.Forms.PictureBox();
            this.stt_txtBox_1 = new System.Windows.Forms.TextBox();
            this.dongia_txtBox_1 = new System.Windows.Forms.TextBox();
            this.doUong_cbb_1 = new System.Windows.Forms.ComboBox();
            this.header_pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dongia_lb = new System.Windows.Forms.Label();
            this.stt_lb = new System.Windows.Forms.Label();
            this.soLuong_lb = new System.Windows.Forms.Label();
            this.doUong_lb = new System.Windows.Forms.Label();
            this.taoOk_btn = new System.Windows.Forms.Button();
            this.them_doUong_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.danhSach_pnl.SuspendLayout();
            this.themDoUong_pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soLuong_nm_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trash_pb_1)).BeginInit();
            this.header_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // taoOrder_lb
            // 
            this.taoOrder_lb.AutoSize = true;
            this.taoOrder_lb.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taoOrder_lb.Location = new System.Drawing.Point(251, 3);
            this.taoOrder_lb.Name = "taoOrder_lb";
            this.taoOrder_lb.Size = new System.Drawing.Size(132, 37);
            this.taoOrder_lb.TabIndex = 0;
            this.taoOrder_lb.Text = "Tạo order";
            // 
            // ngay_lb
            // 
            this.ngay_lb.AutoSize = true;
            this.ngay_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ngay_lb.Location = new System.Drawing.Point(11, 6);
            this.ngay_lb.Name = "ngay_lb";
            this.ngay_lb.Size = new System.Drawing.Size(38, 15);
            this.ngay_lb.TabIndex = 1;
            this.ngay_lb.Text = "Ngày:";
            // 
            // ngayValue_lb
            // 
            this.ngayValue_lb.AutoSize = true;
            this.ngayValue_lb.Location = new System.Drawing.Point(52, 6);
            this.ngayValue_lb.Name = "ngayValue_lb";
            this.ngayValue_lb.Size = new System.Drawing.Size(38, 15);
            this.ngayValue_lb.TabIndex = 2;
            this.ngayValue_lb.Text = "label1";
            // 
            // ban_lb
            // 
            this.ban_lb.AutoSize = true;
            this.ban_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ban_lb.Location = new System.Drawing.Point(503, 6);
            this.ban_lb.Name = "ban_lb";
            this.ban_lb.Size = new System.Drawing.Size(46, 15);
            this.ban_lb.TabIndex = 3;
            this.ban_lb.Text = "Bàn số:";
            // 
            // banValue_lb
            // 
            this.banValue_lb.AutoSize = true;
            this.banValue_lb.Location = new System.Drawing.Point(556, 6);
            this.banValue_lb.Name = "banValue_lb";
            this.banValue_lb.Size = new System.Drawing.Size(38, 15);
            this.banValue_lb.TabIndex = 4;
            this.banValue_lb.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ngay_lb);
            this.panel1.Controls.Add(this.banValue_lb);
            this.panel1.Controls.Add(this.ngayValue_lb);
            this.panel1.Controls.Add(this.ban_lb);
            this.panel1.Location = new System.Drawing.Point(21, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 28);
            this.panel1.TabIndex = 5;
            // 
            // danhSach_pnl
            // 
            this.danhSach_pnl.AutoScroll = true;
            this.danhSach_pnl.Controls.Add(this.themDoUong_pnl_1);
            this.danhSach_pnl.Controls.Add(this.header_pnl);
            this.danhSach_pnl.Location = new System.Drawing.Point(21, 77);
            this.danhSach_pnl.Name = "danhSach_pnl";
            this.danhSach_pnl.Size = new System.Drawing.Size(609, 201);
            this.danhSach_pnl.TabIndex = 6;
            // 
            // themDoUong_pnl_1
            // 
            this.themDoUong_pnl_1.Controls.Add(this.soLuong_nm_1);
            this.themDoUong_pnl_1.Controls.Add(this.id_tBox_1);
            this.themDoUong_pnl_1.Controls.Add(this.trash_pb_1);
            this.themDoUong_pnl_1.Controls.Add(this.stt_txtBox_1);
            this.themDoUong_pnl_1.Controls.Add(this.dongia_txtBox_1);
            this.themDoUong_pnl_1.Controls.Add(this.doUong_cbb_1);
            this.themDoUong_pnl_1.Location = new System.Drawing.Point(11, 26);
            this.themDoUong_pnl_1.Name = "themDoUong_pnl_1";
            this.themDoUong_pnl_1.Size = new System.Drawing.Size(583, 32);
            this.themDoUong_pnl_1.TabIndex = 14;
            // 
            // soLuong_nm_1
            // 
            this.soLuong_nm_1.Location = new System.Drawing.Point(380, 4);
            this.soLuong_nm_1.Name = "soLuong_nm_1";
            this.soLuong_nm_1.Size = new System.Drawing.Size(69, 23);
            this.soLuong_nm_1.TabIndex = 15;
            this.soLuong_nm_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // id_tBox_1
            // 
            this.id_tBox_1.Location = new System.Drawing.Point(58, 4);
            this.id_tBox_1.Name = "id_tBox_1";
            this.id_tBox_1.ReadOnly = true;
            this.id_tBox_1.Size = new System.Drawing.Size(82, 23);
            this.id_tBox_1.TabIndex = 15;
            // 
            // trash_pb_1
            // 
            this.trash_pb_1.Location = new System.Drawing.Point(563, 5);
            this.trash_pb_1.Name = "trash_pb_1";
            this.trash_pb_1.Size = new System.Drawing.Size(20, 20);
            this.trash_pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trash_pb_1.TabIndex = 15;
            this.trash_pb_1.TabStop = false;
            // 
            // stt_txtBox_1
            // 
            this.stt_txtBox_1.Location = new System.Drawing.Point(0, 4);
            this.stt_txtBox_1.Name = "stt_txtBox_1";
            this.stt_txtBox_1.ReadOnly = true;
            this.stt_txtBox_1.Size = new System.Drawing.Size(52, 23);
            this.stt_txtBox_1.TabIndex = 11;
            // 
            // dongia_txtBox_1
            // 
            this.dongia_txtBox_1.Location = new System.Drawing.Point(455, 4);
            this.dongia_txtBox_1.Name = "dongia_txtBox_1";
            this.dongia_txtBox_1.ReadOnly = true;
            this.dongia_txtBox_1.Size = new System.Drawing.Size(102, 23);
            this.dongia_txtBox_1.TabIndex = 10;
            // 
            // doUong_cbb_1
            // 
            this.doUong_cbb_1.FormattingEnabled = true;
            this.doUong_cbb_1.Location = new System.Drawing.Point(146, 4);
            this.doUong_cbb_1.Name = "doUong_cbb_1";
            this.doUong_cbb_1.Size = new System.Drawing.Size(226, 23);
            this.doUong_cbb_1.TabIndex = 8;
            // 
            // header_pnl
            // 
            this.header_pnl.Controls.Add(this.label1);
            this.header_pnl.Controls.Add(this.dongia_lb);
            this.header_pnl.Controls.Add(this.stt_lb);
            this.header_pnl.Controls.Add(this.soLuong_lb);
            this.header_pnl.Controls.Add(this.doUong_lb);
            this.header_pnl.Location = new System.Drawing.Point(11, 0);
            this.header_pnl.Name = "header_pnl";
            this.header_pnl.Size = new System.Drawing.Size(583, 26);
            this.header_pnl.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã đồ uống";
            // 
            // dongia_lb
            // 
            this.dongia_lb.AutoSize = true;
            this.dongia_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dongia_lb.Location = new System.Drawing.Point(455, 6);
            this.dongia_lb.Name = "dongia_lb";
            this.dongia_lb.Size = new System.Drawing.Size(50, 15);
            this.dongia_lb.TabIndex = 13;
            this.dongia_lb.Text = "Đơn giá";
            // 
            // stt_lb
            // 
            this.stt_lb.AutoSize = true;
            this.stt_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stt_lb.Location = new System.Drawing.Point(0, 6);
            this.stt_lb.Name = "stt_lb";
            this.stt_lb.Size = new System.Drawing.Size(28, 15);
            this.stt_lb.TabIndex = 10;
            this.stt_lb.Text = "STT";
            // 
            // soLuong_lb
            // 
            this.soLuong_lb.AutoSize = true;
            this.soLuong_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.soLuong_lb.Location = new System.Drawing.Point(378, 6);
            this.soLuong_lb.Name = "soLuong_lb";
            this.soLuong_lb.Size = new System.Drawing.Size(57, 15);
            this.soLuong_lb.TabIndex = 12;
            this.soLuong_lb.Text = "Số lượng";
            // 
            // doUong_lb
            // 
            this.doUong_lb.AutoSize = true;
            this.doUong_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doUong_lb.Location = new System.Drawing.Point(146, 6);
            this.doUong_lb.Name = "doUong_lb";
            this.doUong_lb.Size = new System.Drawing.Size(76, 15);
            this.doUong_lb.TabIndex = 11;
            this.doUong_lb.Text = "Tên đồ uống";
            // 
            // taoOk_btn
            // 
            this.taoOk_btn.Location = new System.Drawing.Point(554, 284);
            this.taoOk_btn.Name = "taoOk_btn";
            this.taoOk_btn.Size = new System.Drawing.Size(75, 23);
            this.taoOk_btn.TabIndex = 7;
            this.taoOk_btn.Text = "OK";
            this.taoOk_btn.UseVisualStyleBackColor = true;
            this.taoOk_btn.Click += new System.EventHandler(this.taoOk_btn_Clicked);
            // 
            // them_doUong_btn
            // 
            this.them_doUong_btn.Location = new System.Drawing.Point(442, 284);
            this.them_doUong_btn.Name = "them_doUong_btn";
            this.them_doUong_btn.Size = new System.Drawing.Size(106, 23);
            this.them_doUong_btn.TabIndex = 8;
            this.them_doUong_btn.Text = "Thêm đồ uống";
            this.them_doUong_btn.UseVisualStyleBackColor = true;
            this.them_doUong_btn.Click += new System.EventHandler(this.them_doUong_btn_Click);
            // 
            // ThemOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 319);
            this.Controls.Add(this.them_doUong_btn);
            this.Controls.Add(this.taoOk_btn);
            this.Controls.Add(this.danhSach_pnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.taoOrder_lb);
            this.Name = "ThemOrderForm";
            this.Text = "ThemOrderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.danhSach_pnl.ResumeLayout(false);
            this.themDoUong_pnl_1.ResumeLayout(false);
            this.themDoUong_pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soLuong_nm_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trash_pb_1)).EndInit();
            this.header_pnl.ResumeLayout(false);
            this.header_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taoOrder_lb;
        private System.Windows.Forms.Label ngay_lb;
        private System.Windows.Forms.Label ngayValue_lb;
        private System.Windows.Forms.Label ban_lb;
        private System.Windows.Forms.Label banValue_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel danhSach_pnl;
        private System.Windows.Forms.Button taoOk_btn;
        private System.Windows.Forms.Label soLuong_lb;
        private System.Windows.Forms.Label doUong_lb;
        private System.Windows.Forms.Label stt_lb;
        private System.Windows.Forms.ComboBox doUong_cbb_1;
        private System.Windows.Forms.Panel themDoUong_pnl_1;
        private System.Windows.Forms.Panel header_pnl;
        private System.Windows.Forms.Label dongia_lb;
        private System.Windows.Forms.TextBox stt_txtBox_1;
        private System.Windows.Forms.TextBox dongia_txtBox_1;
        private System.Windows.Forms.Button them_doUong_btn;
        private System.Windows.Forms.PictureBox trash_pb_1;
        private System.Windows.Forms.TextBox id_tBox_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown soLuong_nm_1;
    }
}