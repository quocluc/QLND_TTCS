namespace QLND
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMoFile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDSCu = new System.Windows.Forms.TabPage();
            this.dtgvDanhSachCu = new System.Windows.Forms.DataGridView();
            this.tabDSMoi = new System.Windows.Forms.TabPage();
            this.dtgvDanhSachMoi = new System.Windows.Forms.DataGridView();
            this.tabDSMerge = new System.Windows.Forms.TabPage();
            this.dtgvLoc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTieuChi = new System.Windows.Forms.ComboBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMucDichSD = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChuSoHuuHT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiNha = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabDSCu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachCu)).BeginInit();
            this.tabDSMoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMoi)).BeginInit();
            this.tabDSMerge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMoFile
            // 
            this.btnMoFile.BackColor = System.Drawing.Color.Azure;
            this.btnMoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoFile.Image = ((System.Drawing.Image)(resources.GetObject("btnMoFile.Image")));
            this.btnMoFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMoFile.Location = new System.Drawing.Point(12, 46);
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.Size = new System.Drawing.Size(92, 99);
            this.btnMoFile.TabIndex = 6;
            this.btnMoFile.Text = "Mở file mới";
            this.btnMoFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMoFile.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDSCu);
            this.tabControl1.Controls.Add(this.tabDSMoi);
            this.tabControl1.Controls.Add(this.tabDSMerge);
            this.tabControl1.Location = new System.Drawing.Point(2, 239);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 342);
            this.tabControl1.TabIndex = 16;
            // 
            // tabDSCu
            // 
            this.tabDSCu.Controls.Add(this.dtgvDanhSachCu);
            this.tabDSCu.Location = new System.Drawing.Point(4, 24);
            this.tabDSCu.Name = "tabDSCu";
            this.tabDSCu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSCu.Size = new System.Drawing.Size(1092, 314);
            this.tabDSCu.TabIndex = 0;
            this.tabDSCu.Text = "Danh sach cũ";
            this.tabDSCu.UseVisualStyleBackColor = true;
            this.tabDSCu.Click += new System.EventHandler(this.tabDSCu_Click);
            // 
            // dtgvDanhSachCu
            // 
            this.dtgvDanhSachCu.AllowUserToAddRows = false;
            this.dtgvDanhSachCu.AllowUserToDeleteRows = false;
            this.dtgvDanhSachCu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachCu.Location = new System.Drawing.Point(3, 3);
            this.dtgvDanhSachCu.Name = "dtgvDanhSachCu";
            this.dtgvDanhSachCu.ReadOnly = true;
            this.dtgvDanhSachCu.Size = new System.Drawing.Size(1083, 333);
            this.dtgvDanhSachCu.TabIndex = 7;
            // 
            // tabDSMoi
            // 
            this.tabDSMoi.Controls.Add(this.dtgvDanhSachMoi);
            this.tabDSMoi.Location = new System.Drawing.Point(4, 24);
            this.tabDSMoi.Name = "tabDSMoi";
            this.tabDSMoi.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSMoi.Size = new System.Drawing.Size(1092, 314);
            this.tabDSMoi.TabIndex = 1;
            this.tabDSMoi.Text = "Danh sách mới";
            this.tabDSMoi.UseVisualStyleBackColor = true;
            // 
            // dtgvDanhSachMoi
            // 
            this.dtgvDanhSachMoi.AllowUserToAddRows = false;
            this.dtgvDanhSachMoi.AllowUserToDeleteRows = false;
            this.dtgvDanhSachMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachMoi.Location = new System.Drawing.Point(7, 7);
            this.dtgvDanhSachMoi.Name = "dtgvDanhSachMoi";
            this.dtgvDanhSachMoi.ReadOnly = true;
            this.dtgvDanhSachMoi.Size = new System.Drawing.Size(1115, 342);
            this.dtgvDanhSachMoi.TabIndex = 8;
            // 
            // tabDSMerge
            // 
            this.tabDSMerge.Controls.Add(this.dtgvLoc);
            this.tabDSMerge.Location = new System.Drawing.Point(4, 24);
            this.tabDSMerge.Name = "tabDSMerge";
            this.tabDSMerge.Size = new System.Drawing.Size(1068, 314);
            this.tabDSMerge.TabIndex = 2;
            this.tabDSMerge.Text = "Danh sách sau khi merge";
            this.tabDSMerge.UseVisualStyleBackColor = true;
            // 
            // dtgvLoc
            // 
            this.dtgvLoc.AllowUserToAddRows = false;
            this.dtgvLoc.AllowUserToDeleteRows = false;
            this.dtgvLoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvLoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dtgvLoc.Location = new System.Drawing.Point(6, 3);
            this.dtgvLoc.Name = "dtgvLoc";
            this.dtgvLoc.ReadOnly = true;
            this.dtgvLoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLoc.Size = new System.Drawing.Size(1051, 342);
            this.dtgvLoc.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STT";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Địa chỉ";
            this.dataGridViewTextBoxColumn2.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Diện Tích";
            this.dataGridViewTextBoxColumn3.HeaderText = "Diện Tích";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Chủ sở hữu hiện tại";
            this.dataGridViewTextBoxColumn4.HeaderText = "Chủ sở hữu hiện tại";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Loại nhà";
            this.dataGridViewTextBoxColumn5.HeaderText = "Loại nhà";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Mục đích sử dụng";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mục đích sử dụng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Giá tiền";
            this.dataGridViewTextBoxColumn7.HeaderText = "Giá tiền";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(862, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Merge theo tiêu chí:";
            // 
            // cboTieuChi
            // 
            this.cboTieuChi.FormattingEnabled = true;
            this.cboTieuChi.Items.AddRange(new object[] {
            "Địa chỉ",
            "Diện tích",
            "Chủ sở hữu hiện tại",
            "Loại nhà",
            "Mục đích sử dụng",
            "Giá tiền"});
            this.cboTieuChi.Location = new System.Drawing.Point(865, 60);
            this.cboTieuChi.Name = "cboTieuChi";
            this.cboTieuChi.Size = new System.Drawing.Size(198, 23);
            this.cboTieuChi.TabIndex = 42;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(477, 159);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(198, 21);
            this.txtGiaTien.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Giá tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Mục đích sử dụng:";
            // 
            // cboMucDichSD
            // 
            this.cboMucDichSD.FormattingEnabled = true;
            this.cboMucDichSD.Items.AddRange(new object[] {
            "Nhà ở",
            "Kinh doanh"});
            this.cboMucDichSD.Location = new System.Drawing.Point(477, 65);
            this.cboMucDichSD.Name = "cboMucDichSD";
            this.cboMucDichSD.Size = new System.Drawing.Size(198, 23);
            this.cboMucDichSD.TabIndex = 38;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(85, 23);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(207, 82);
            this.txtDiaChi.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Địa chỉ:";
            // 
            // txtChuSoHuuHT
            // 
            this.txtChuSoHuuHT.Location = new System.Drawing.Point(477, 20);
            this.txtChuSoHuuHT.Name = "txtChuSoHuuHT";
            this.txtChuSoHuuHT.Size = new System.Drawing.Size(198, 21);
            this.txtChuSoHuuHT.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Chủ sở hữu hiện tại:";
            // 
            // btnMerge
            // 
            this.btnMerge.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnMerge.Image = ((System.Drawing.Image)(resources.GetObject("btnMerge.Image")));
            this.btnMerge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMerge.Location = new System.Drawing.Point(865, 103);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(87, 40);
            this.btnMerge.TabIndex = 33;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = false;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(85, 160);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(207, 21);
            this.txtDienTich.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Diện tích:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Loại nhà:";
            // 
            // cboLoaiNha
            // 
            this.cboLoaiNha.FormattingEnabled = true;
            this.cboLoaiNha.Items.AddRange(new object[] {
            "Nhà cấp 1",
            "Nhà cấp 2",
            "Nhà cấp 3",
            "Nhà cấp 4"});
            this.cboLoaiNha.Location = new System.Drawing.Point(477, 113);
            this.cboLoaiNha.Name = "cboLoaiNha";
            this.cboLoaiNha.Size = new System.Drawing.Size(198, 23);
            this.cboLoaiNha.TabIndex = 29;
            this.cboLoaiNha.SelectedIndexChanged += new System.EventHandler(this.cboLoaiNha_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtGiaTien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtChuSoHuuHT);
            this.panel1.Controls.Add(this.txtDienTich);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboLoaiNha);
            this.panel1.Controls.Add(this.cboMucDichSD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(134, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 203);
            this.panel1.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 585);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboTieuChi);
            this.Controls.Add(this.btnMoFile);
            this.Controls.Add(this.btnMerge);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabDSCu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachCu)).EndInit();
            this.tabDSMoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMoi)).EndInit();
            this.tabDSMerge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDSCu;
        private System.Windows.Forms.DataGridView dtgvDanhSachCu;
        private System.Windows.Forms.TabPage tabDSMoi;
        private System.Windows.Forms.DataGridView dtgvDanhSachMoi;
        private System.Windows.Forms.TabPage tabDSMerge;
        private System.Windows.Forms.DataGridView dtgvLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTieuChi;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMucDichSD;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChuSoHuuHT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiNha;
        private System.Windows.Forms.Panel panel1;
    }
}