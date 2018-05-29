using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLND
{
    public partial class fQUANLY : Form
    {
        public List<Thuadat> danhsachthuadat;
        private Button button2;
        private Button btnMerge;
        private DataGridView dtgvTimKiem;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        public DataTable data;
        public fQUANLY()
        {
            InitializeComponent();
        }
        private void LoadComboBox()
        {
            //Lựa chọn Loại nhà
            cboLoaiNha.Items.Add("--Chọn--");
            cboLoaiNha.Items.Add("Nhà cấp 1");
            cboLoaiNha.Items.Add("Nhà cấp 2");
            cboLoaiNha.Items.Add("Nhà cấp 3");
            cboLoaiNha.Items.Add("Nhà cấp 4");
            cboLoaiNha.SelectedIndex = 0;

            //Lựa chọn Mục đích sử đụng
            cboMucDich.Items.Add("--Chọn--");
            cboMucDich.Items.Add("Nhà ở");
            cboMucDich.Items.Add("Kinh doanh");
            cboMucDich.SelectedIndex = 0;
        }
        private void fQuanLy_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }
       
        private Button btnLoadExcel;
        private Button btnExport;
        private Button button1;
        private Button btnXoaTatCa;
        private Button btnTimKiem;
        private Panel panel1;
        private TextBox txtTimKiem;
        private Label lbTimKiem;
        private Button btnSua;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnThem;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtViTri;
        private Label label2;
        private Panel panel4;
        private TextBox txtDiaChi;
        private Label label1;
        private Panel panel9;
        private TextBox txtGiaTien;
        private Label lbGia;
        private Panel panel8;
        private ComboBox cboMucDich;
        private Label lbMucDich;
        private Panel panel7;
        private ComboBox cboLoaiNha;
        private Label lbLoaiNha;
        private Panel panel6;
        private TextBox txtDienTich;
        private Label lbDienTich;
        private Panel panel5;
        private TextBox txtChuSoHuu;
        private Label lbChu;
        private DataGridViewTextBoxColumn ST;

       

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQUANLY));
            this.btnLoadExcel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cboMucDich = new System.Windows.Forms.ComboBox();
            this.lbMucDich = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cboLoaiNha = new System.Windows.Forms.ComboBox();
            this.lbLoaiNha = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.lbDienTich = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtChuSoHuu = new System.Windows.Forms.TextBox();
            this.lbChu = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.dtgvTimKiem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.BackColor = System.Drawing.Color.Snow;
            this.btnLoadExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadExcel.Image")));
            this.btnLoadExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadExcel.Location = new System.Drawing.Point(12, 30);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(84, 87);
            this.btnLoadExcel.TabIndex = 8;
            this.btnLoadExcel.Text = "Chọn file";
            this.btnLoadExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadExcel.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Snow;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExport.Location = new System.Drawing.Point(12, 146);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(84, 87);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Xuất file ";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1213, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sắp xếp danh sách";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnXoaTatCa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTatCa.Image")));
            this.btnXoaTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTatCa.Location = new System.Drawing.Point(117, 252);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(107, 36);
            this.btnXoaTatCa.TabIndex = 16;
            this.btnXoaTatCa.Text = "Xóa tất cả";
            this.btnXoaTatCa.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(513, 254);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 35);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.lbTimKiem);
            this.panel1.Location = new System.Drawing.Point(630, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 36);
            this.panel1.TabIndex = 13;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(84, 9);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(202, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.Location = new System.Drawing.Point(-3, 10);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(75, 16);
            this.lbTimKiem.TabIndex = 0;
            this.lbTimKiem.Text = "Tìm kiếm:";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(818, 87);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 34);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(818, 199);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(86, 34);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Reset";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(818, 146);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 34);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(818, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(354, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "QUẢN LÝ NHÀ ĐẤT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(117, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 203);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtViTri);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 47);
            this.panel3.TabIndex = 3;
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(91, 9);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.ReadOnly = true;
            this.txtViTri.Size = new System.Drawing.Size(197, 20);
            this.txtViTri.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ tự:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDiaChi);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(2, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 85);
            this.panel4.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(91, 10);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(196, 67);
            this.txtDiaChi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtGiaTien);
            this.panel9.Controls.Add(this.lbGia);
            this.panel9.Location = new System.Drawing.Point(325, 160);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(353, 36);
            this.panel9.TabIndex = 5;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(145, 5);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(197, 20);
            this.txtGiaTien.TabIndex = 1;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.Location = new System.Drawing.Point(11, 9);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(56, 16);
            this.lbGia.TabIndex = 0;
            this.lbGia.Text = "Giá tiền:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cboMucDich);
            this.panel8.Controls.Add(this.lbMucDich);
            this.panel8.Location = new System.Drawing.Point(325, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(353, 36);
            this.panel8.TabIndex = 4;
            // 
            // cboMucDich
            // 
            this.cboMucDich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMucDich.FormattingEnabled = true;
            this.cboMucDich.Location = new System.Drawing.Point(145, 8);
            this.cboMucDich.Name = "cboMucDich";
            this.cboMucDich.Size = new System.Drawing.Size(197, 21);
            this.cboMucDich.TabIndex = 2;
            // 
            // lbMucDich
            // 
            this.lbMucDich.AutoSize = true;
            this.lbMucDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMucDich.Location = new System.Drawing.Point(11, 9);
            this.lbMucDich.Name = "lbMucDich";
            this.lbMucDich.Size = new System.Drawing.Size(114, 16);
            this.lbMucDich.TabIndex = 0;
            this.lbMucDich.Text = "Mục đích sử dụng:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cboLoaiNha);
            this.panel7.Controls.Add(this.lbLoaiNha);
            this.panel7.Location = new System.Drawing.Point(325, 107);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(353, 36);
            this.panel7.TabIndex = 4;
            // 
            // cboLoaiNha
            // 
            this.cboLoaiNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNha.FormattingEnabled = true;
            this.cboLoaiNha.Location = new System.Drawing.Point(145, 4);
            this.cboLoaiNha.Name = "cboLoaiNha";
            this.cboLoaiNha.Size = new System.Drawing.Size(197, 21);
            this.cboLoaiNha.TabIndex = 1;
            // 
            // lbLoaiNha
            // 
            this.lbLoaiNha.AutoSize = true;
            this.lbLoaiNha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiNha.Location = new System.Drawing.Point(11, 9);
            this.lbLoaiNha.Name = "lbLoaiNha";
            this.lbLoaiNha.Size = new System.Drawing.Size(62, 16);
            this.lbLoaiNha.TabIndex = 0;
            this.lbLoaiNha.Text = "Loại nhà:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtDienTich);
            this.panel6.Controls.Add(this.lbDienTich);
            this.panel6.Location = new System.Drawing.Point(2, 160);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 36);
            this.panel6.TabIndex = 2;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(91, 8);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(197, 20);
            this.txtDienTich.TabIndex = 1;
            // 
            // lbDienTich
            // 
            this.lbDienTich.AutoSize = true;
            this.lbDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDienTich.Location = new System.Drawing.Point(10, 9);
            this.lbDienTich.Name = "lbDienTich";
            this.lbDienTich.Size = new System.Drawing.Size(62, 16);
            this.lbDienTich.TabIndex = 0;
            this.lbDienTich.Text = "Diện tích:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtChuSoHuu);
            this.panel5.Controls.Add(this.lbChu);
            this.panel5.Location = new System.Drawing.Point(325, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(353, 36);
            this.panel5.TabIndex = 3;
            // 
            // txtChuSoHuu
            // 
            this.txtChuSoHuu.Location = new System.Drawing.Point(145, 10);
            this.txtChuSoHuu.Name = "txtChuSoHuu";
            this.txtChuSoHuu.Size = new System.Drawing.Size(197, 20);
            this.txtChuSoHuu.TabIndex = 1;
            this.txtChuSoHuu.TextChanged += new System.EventHandler(this.txtChuSoHuu_TextChanged);
            // 
            // lbChu
            // 
            this.lbChu.AutoSize = true;
            this.lbChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChu.Location = new System.Drawing.Point(10, 11);
            this.lbChu.Name = "lbChu";
            this.lbChu.Size = new System.Drawing.Size(76, 16);
            this.lbChu.TabIndex = 0;
            this.lbChu.Text = "Chủ sở hữu:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(359, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 36);
            this.button2.TabIndex = 25;
            this.button2.Text = "Sắp xếp danh sách";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnMerge
            // 
            this.btnMerge.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnMerge.Image = ((System.Drawing.Image)(resources.GetObject("btnMerge.Image")));
            this.btnMerge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMerge.Location = new System.Drawing.Point(241, 252);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(101, 36);
            this.btnMerge.TabIndex = 26;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = false;
            // 
            // dtgvTimKiem
            // 
            this.dtgvTimKiem.AllowUserToAddRows = false;
            this.dtgvTimKiem.AllowUserToDeleteRows = false;
            this.dtgvTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvTimKiem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dtgvTimKiem.Location = new System.Drawing.Point(12, 295);
            this.dtgvTimKiem.Name = "dtgvTimKiem";
            this.dtgvTimKiem.ReadOnly = true;
            this.dtgvTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTimKiem.Size = new System.Drawing.Size(911, 290);
            this.dtgvTimKiem.TabIndex = 27;
            this.dtgvTimKiem.Visible = false;
            this.dtgvTimKiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTimKiem_CellContentClick);
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
            // fQUANLY
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 591);
            this.Controls.Add(this.dtgvTimKiem);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnLoadExcel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "fQUANLY";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtChuSoHuu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvTimKiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
