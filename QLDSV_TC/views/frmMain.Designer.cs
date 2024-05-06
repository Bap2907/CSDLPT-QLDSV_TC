namespace QLDSV_TC.views
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonDANGKYLTC = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonXEMDIEM = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripMa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTen = new System.Windows.Forms.ToolStripLabel();
            this.toolStripKhoa = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonDANGKYLTC,
            this.barButtonXEMDIEM});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonSinhVien});
            this.ribbonControl1.Size = new System.Drawing.Size(878, 209);
            //this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // barButtonDANGKYLTC
            // 
            this.barButtonDANGKYLTC.Caption = "Đăng Ký Lớp Tín Chỉ";
            this.barButtonDANGKYLTC.Id = 1;
            this.barButtonDANGKYLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonDANGKYLTC.ImageOptions.Image")));
            this.barButtonDANGKYLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonDANGKYLTC.ImageOptions.LargeImage")));
            this.barButtonDANGKYLTC.Name = "barButtonDANGKYLTC";
            //this.barButtonDANGKYLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDANGKYLTC_ItemClick);
            // 
            // barButtonXEMDIEM
            // 
            this.barButtonXEMDIEM.Caption = "Xem Điểm";
            this.barButtonXEMDIEM.Id = 2;
            this.barButtonXEMDIEM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonXEMDIEM.ImageOptions.Image")));
            this.barButtonXEMDIEM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonXEMDIEM.ImageOptions.LargeImage")));
            this.barButtonXEMDIEM.Name = "barButtonXEMDIEM";
            this.barButtonXEMDIEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonXEMDIEM_ItemClick);
            // 
            // ribbonSinhVien
            // 
            this.ribbonSinhVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonSinhVien.ImageOptions.Image")));
            this.ribbonSinhVien.Name = "ribbonSinhVien";
            this.ribbonSinhVien.Text = "Sinh viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonDANGKYLTC);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonXEMDIEM);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMa,
            this.toolStripTen,
            this.toolStripKhoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 477);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(878, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripMa
            // 
            this.toolStripMa.Name = "toolStripMa";
            this.toolStripMa.Size = new System.Drawing.Size(33, 22);
            this.toolStripMa.Text = "Mã:";
            // 
            // toolStripTen
            // 
            this.toolStripTen.Name = "toolStripTen";
            this.toolStripTen.Size = new System.Drawing.Size(35, 22);
            this.toolStripTen.Text = "Tên:";
            // 
            // toolStripKhoa
            // 
            this.toolStripKhoa.Name = "toolStripKhoa";
            this.toolStripKhoa.Size = new System.Drawing.Size(46, 22);
            this.toolStripKhoa.Text = "Khoa:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 502);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonDANGKYLTC;
        private DevExpress.XtraBars.BarButtonItem barButtonXEMDIEM;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel toolStripMa;
        public System.Windows.Forms.ToolStripLabel toolStripTen;
        public System.Windows.Forms.ToolStripLabel toolStripKhoa;
    }
}

