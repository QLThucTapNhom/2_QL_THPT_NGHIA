﻿namespace QL_GV_HS_THPT.GUI
{
    partial class frmGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.drvGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.tkTen = new System.Windows.Forms.ToolStripMenuItem();
            this.tkMa = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.drvGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drvGV
            // 
            this.drvGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.drvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drvGV.Location = new System.Drawing.Point(0, 303);
            this.drvGV.Name = "drvGV";
            this.drvGV.Size = new System.Drawing.Size(695, 159);
            this.drvGV.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trình độ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tkMa,
            this.tkTen});
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimKiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(68, 67);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 67);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 67);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 67);
            this.btnSua.Text = "Thay đổi thông tin";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 67);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnTimKiem,
            this.btnThoat});
            this.menuStrip1.Location = new System.Drawing.Point(9, 216);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(432, 71);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(60, 67);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.Location = new System.Drawing.Point(122, 147);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(146, 24);
            this.txtQueQuan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quê quán";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGV.Location = new System.Drawing.Point(122, 79);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(146, 24);
            this.txtTenGV.TabIndex = 3;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Location = new System.Drawing.Point(122, 38);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(146, 24);
            this.txtMaGV.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(15, 185);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(253, 22);
            this.dtpNgaySinh.TabIndex = 9;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(222, 114);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(46, 21);
            this.rdbNu.TabIndex = 6;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(122, 114);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(56, 21);
            this.rdbNam.TabIndex = 5;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giáo viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTrinhDo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenGV);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giáo viên";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(393, 79);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(142, 24);
            this.txtSDT.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "SĐT";
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrinhDo.Location = new System.Drawing.Point(393, 40);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(142, 24);
            this.txtTrinhDo.TabIndex = 11;
            // 
            // tkTen
            // 
            this.tkTen.Name = "tkTen";
            this.tkTen.Size = new System.Drawing.Size(180, 22);
            this.tkTen.Text = "Tìm kiếm theo tên";
            // 
            // tkMa
            // 
            this.tkMa.Name = "tkMa";
            this.tkMa.Size = new System.Drawing.Size(180, 22);
            this.tkMa.Text = "Tìm kiếm theo mã";
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 462);
            this.Controls.Add(this.drvGV);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaoVien";
            ((System.ComponentModel.ISupportInitialize)(this.drvGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView drvGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem btnTimKiem;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnLuu;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.ToolStripMenuItem btnThoat;
        private System.Windows.Forms.ToolStripMenuItem tkTen;
        private System.Windows.Forms.ToolStripMenuItem tkMa;
    }
}