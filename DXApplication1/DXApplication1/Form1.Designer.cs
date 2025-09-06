namespace DXApplication1
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.menuInfomation = new DevExpress.XtraTab.XtraTabPage();
            this.menuThongSo = new DevExpress.XtraTab.XtraTabPage();
            this.menuKichThuoc = new DevExpress.XtraTab.XtraTabPage();
            this.menuCabin = new DevExpress.XtraTab.XtraTabPage();
            this.menuCua = new DevExpress.XtraTab.XtraTabPage();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.menuDien = new DevExpress.XtraTab.XtraTabPage();
            this.menuTrangBi = new DevExpress.XtraTab.XtraTabPage();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewPDF = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.menuCua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.menuInfomation;
            this.xtraTabControl1.Size = new System.Drawing.Size(923, 614);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.menuInfomation,
            this.menuThongSo,
            this.menuKichThuoc,
            this.menuCabin,
            this.menuCua,
            this.menuDien,
            this.menuTrangBi});
            // 
            // menuInfomation
            // 
            this.menuInfomation.Name = "menuInfomation";
            this.menuInfomation.Size = new System.Drawing.Size(921, 589);
            this.menuInfomation.Text = "Thông tin chung";
            // 
            // menuThongSo
            // 
            this.menuThongSo.Name = "menuThongSo";
            this.menuThongSo.Size = new System.Drawing.Size(921, 589);
            this.menuThongSo.Text = "Thông số cơ bản";
            // 
            // menuKichThuoc
            // 
            this.menuKichThuoc.Name = "menuKichThuoc";
            this.menuKichThuoc.Size = new System.Drawing.Size(921, 589);
            this.menuKichThuoc.Text = "Kích thước & Kết cấu";
            // 
            // menuCabin
            // 
            this.menuCabin.Name = "menuCabin";
            this.menuCabin.Size = new System.Drawing.Size(921, 589);
            this.menuCabin.Text = "Cabin";
            // 
            // menuCua
            // 
            this.menuCua.Controls.Add(this.textEdit1);
            this.menuCua.Name = "menuCua";
            this.menuCua.Size = new System.Drawing.Size(921, 589);
            this.menuCua.Text = "Cửa & Khung bao";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(130, 98);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // menuDien
            // 
            this.menuDien.Name = "menuDien";
            this.menuDien.Size = new System.Drawing.Size(921, 589);
            this.menuDien.Text = "Điều khiển & Điện";
            // 
            // menuTrangBi
            // 
            this.menuTrangBi.Name = "menuTrangBi";
            this.menuTrangBi.Size = new System.Drawing.Size(921, 589);
            this.menuTrangBi.Text = "Trang bị phụ trợ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(941, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 46);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnViewPDF
            // 
            this.btnViewPDF.Location = new System.Drawing.Point(941, 179);
            this.btnViewPDF.Name = "btnViewPDF";
            this.btnViewPDF.Size = new System.Drawing.Size(42, 46);
            this.btnViewPDF.TabIndex = 3;
            this.btnViewPDF.Text = "PDF";
            this.btnViewPDF.Click += new System.EventHandler(this.btnViewPDF_Click);
            // 
            // btnViewExcel
            // 
            this.btnViewExcel.Location = new System.Drawing.Point(940, 231);
            this.btnViewExcel.Name = "btnViewExcel";
            this.btnViewExcel.Size = new System.Drawing.Size(42, 46);
            this.btnViewExcel.TabIndex = 4;
            this.btnViewExcel.Text = "Excel";
            this.btnViewExcel.Click += new System.EventHandler(this.btnViewExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 638);
            this.Controls.Add(this.btnViewExcel);
            this.Controls.Add(this.btnViewPDF);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.menuCua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage menuInfomation;
        private DevExpress.XtraTab.XtraTabPage menuThongSo;
        private DevExpress.XtraTab.XtraTabPage menuKichThuoc;
        private DevExpress.XtraTab.XtraTabPage menuCabin;
        private DevExpress.XtraTab.XtraTabPage menuCua;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraTab.XtraTabPage menuDien;
        private DevExpress.XtraTab.XtraTabPage menuTrangBi;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnViewPDF;
        private DevExpress.XtraEditors.SimpleButton btnViewExcel;
    }
}

