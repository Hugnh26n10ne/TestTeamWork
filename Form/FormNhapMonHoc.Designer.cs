namespace PhanMemQuanLyDiemSinhVien
{
    partial class FormNhapMonHoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtgrv_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_TongKetHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrv_DiemChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_XuatFile = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrv_STT,
            this.dtgrv_MaMon,
            this.dtgrv_TenMon,
            this.dtgrv_SoTinChi,
            this.dtgrv_SoTiet,
            this.dtgrv_TenGiaoVien,
            this.dtgrv_TongKetHP,
            this.dtgrv_DiemChu});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 370);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtgrv_STT
            // 
            this.dtgrv_STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_STT.HeaderText = "STT";
            this.dtgrv_STT.MinimumWidth = 6;
            this.dtgrv_STT.Name = "dtgrv_STT";
            // 
            // dtgrv_MaMon
            // 
            this.dtgrv_MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_MaMon.HeaderText = "Mã Môn";
            this.dtgrv_MaMon.MinimumWidth = 6;
            this.dtgrv_MaMon.Name = "dtgrv_MaMon";
            // 
            // dtgrv_TenMon
            // 
            this.dtgrv_TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_TenMon.HeaderText = "Tên Môn";
            this.dtgrv_TenMon.MinimumWidth = 6;
            this.dtgrv_TenMon.Name = "dtgrv_TenMon";
            // 
            // dtgrv_SoTinChi
            // 
            this.dtgrv_SoTinChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_SoTinChi.HeaderText = "Số Tín Chỉ";
            this.dtgrv_SoTinChi.MinimumWidth = 6;
            this.dtgrv_SoTinChi.Name = "dtgrv_SoTinChi";
            // 
            // dtgrv_SoTiet
            // 
            this.dtgrv_SoTiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_SoTiet.HeaderText = "Số Tiết";
            this.dtgrv_SoTiet.MinimumWidth = 6;
            this.dtgrv_SoTiet.Name = "dtgrv_SoTiet";
            // 
            // dtgrv_TenGiaoVien
            // 
            this.dtgrv_TenGiaoVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_TenGiaoVien.HeaderText = "Tên Giáo Viên";
            this.dtgrv_TenGiaoVien.MinimumWidth = 6;
            this.dtgrv_TenGiaoVien.Name = "dtgrv_TenGiaoVien";
            // 
            // dtgrv_TongKetHP
            // 
            this.dtgrv_TongKetHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_TongKetHP.HeaderText = "Tổng Kết HP";
            this.dtgrv_TongKetHP.MinimumWidth = 6;
            this.dtgrv_TongKetHP.Name = "dtgrv_TongKetHP";
            // 
            // dtgrv_DiemChu
            // 
            this.dtgrv_DiemChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtgrv_DiemChu.HeaderText = "Điểm Chữ";
            this.dtgrv_DiemChu.MinimumWidth = 6;
            this.dtgrv_DiemChu.Name = "dtgrv_DiemChu";
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Them.Location = new System.Drawing.Point(43, 109);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(103, 35);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Sua.Location = new System.Drawing.Point(183, 109);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(103, 35);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.Location = new System.Drawing.Point(323, 109);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(103, 35);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_XuatFile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_XuatFile.Location = new System.Drawing.Point(473, 109);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(103, 35);
            this.btn_XuatFile.TabIndex = 20;
            this.btn_XuatFile.Text = "Xuất file";
            this.btn_XuatFile.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(623, 109);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(103, 35);
            this.btn_Thoat.TabIndex = 21;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UTM Alexander", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(492, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 50);
            this.label8.TabIndex = 22;
            this.label8.Text = "MÔN HỌC";
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_TimKiem.Location = new System.Drawing.Point(132, 24);
            this.tbx_TimKiem.MaximumSize = new System.Drawing.Size(507, 38);
            this.tbx_TimKiem.MinimumSize = new System.Drawing.Size(507, 38);
            this.tbx_TimKiem.Multiline = true;
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.Size = new System.Drawing.Size(507, 38);
            this.tbx_TimKiem.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.MaximumSize = new System.Drawing.Size(88, 25);
            this.label1.MinimumSize = new System.Drawing.Size(88, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tìm kiếm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PhanMemQuanLyDiemSinhVien.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(645, 24);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(38, 38);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(38, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tbx_TimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_XuatFile);
            this.panel1.Location = new System.Drawing.Point(191, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 161);
            this.panel1.TabIndex = 26;
            // 
            // FormNhapMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 719);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormNhapMonHoc";
            this.Text = "FormNhapMonHoc";
            this.Load += new System.EventHandler(this.FormNhapMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_XuatFile;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_SoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TenGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_TongKetHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrv_DiemChu;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}