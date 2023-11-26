
namespace Version2
{
    partial class dashboard1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard1));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnCustomerDetail = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.panelUpper = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.btnSelectHotel = new System.Windows.Forms.Button();
            this.mainPicture1 = new Version2.mainPicture();
            this.customerDetail1 = new Version2.customerDetail();
            this.selectHotel1 = new Version2.selectHotel();
            this.sidePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUpper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.sidePanel.Controls.Add(this.btnSelectHotel);
            this.sidePanel.Controls.Add(this.btnCustomerDetail);
            this.sidePanel.Controls.Add(this.panel2);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(293, 748);
            this.sidePanel.TabIndex = 0;
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerDetail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCustomerDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerDetail.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetail.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCustomerDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDetail.Image")));
            this.btnCustomerDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerDetail.Location = new System.Drawing.Point(10, 225);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(272, 57);
            this.btnCustomerDetail.TabIndex = 2;
            this.btnCustomerDetail.Text = "     Customer Detail";
            this.btnCustomerDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerDetail.UseVisualStyleBackColor = true;
            this.btnCustomerDetail.Click += new System.EventHandler(this.btnCustomerDetail_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 203);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Management \r\nSystem\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(43, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(103, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1105, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaImageButton1.BackColor = System.Drawing.Color.White;
            this.gunaImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(1264, 29);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(64, 55);
            this.gunaImageButton1.TabIndex = 1;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // panelUpper
            // 
            this.panelUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panelUpper.Controls.Add(this.label2);
            this.panelUpper.Controls.Add(this.panel1);
            this.panelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpper.Location = new System.Drawing.Point(293, 0);
            this.panelUpper.Name = "panelUpper";
            this.panelUpper.Size = new System.Drawing.Size(1350, 203);
            this.panelUpper.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 130);
            this.panel1.TabIndex = 0;
            // 
            // panelHolder
            // 
            this.panelHolder.Controls.Add(this.selectHotel1);
            this.panelHolder.Controls.Add(this.mainPicture1);
            this.panelHolder.Controls.Add(this.customerDetail1);
            this.panelHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHolder.Location = new System.Drawing.Point(293, 203);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(1350, 545);
            this.panelHolder.TabIndex = 3;
            // 
            // btnSelectHotel
            // 
            this.btnSelectHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectHotel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelectHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectHotel.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectHotel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSelectHotel.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectHotel.Image")));
            this.btnSelectHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectHotel.Location = new System.Drawing.Point(10, 297);
            this.btnSelectHotel.Name = "btnSelectHotel";
            this.btnSelectHotel.Size = new System.Drawing.Size(272, 57);
            this.btnSelectHotel.TabIndex = 3;
            this.btnSelectHotel.Text = "     Select Hotel";
            this.btnSelectHotel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectHotel.UseVisualStyleBackColor = true;
            this.btnSelectHotel.Click += new System.EventHandler(this.btnSelectHotel_Click);
            // 
            // mainPicture1
            // 
            this.mainPicture1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPicture1.Location = new System.Drawing.Point(0, 0);
            this.mainPicture1.Name = "mainPicture1";
            this.mainPicture1.Size = new System.Drawing.Size(1350, 545);
            this.mainPicture1.TabIndex = 3;
            // 
            // customerDetail1
            // 
            this.customerDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDetail1.Location = new System.Drawing.Point(0, 0);
            this.customerDetail1.Name = "customerDetail1";
            this.customerDetail1.Size = new System.Drawing.Size(1350, 545);
            this.customerDetail1.TabIndex = 0;
            // 
            // selectHotel1
            // 
            this.selectHotel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectHotel1.Location = new System.Drawing.Point(0, 0);
            this.selectHotel1.Name = "selectHotel1";
            this.selectHotel1.Size = new System.Drawing.Size(1350, 545);
            this.selectHotel1.TabIndex = 4;
            // 
            // dashboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 748);
            this.Controls.Add(this.panelHolder);
            this.Controls.Add(this.panelUpper);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard1";
            this.Load += new System.EventHandler(this.dashboard1_Load);
            this.sidePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUpper.ResumeLayout(false);
            this.panelUpper.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelUpper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomerDetail;
        private System.Windows.Forms.Panel panelHolder;
        private customerDetail customerDetail1;
        private mainPicture mainPicture1;
        private System.Windows.Forms.Button btnSelectHotel;
        private selectHotel selectHotel1;
    }
}