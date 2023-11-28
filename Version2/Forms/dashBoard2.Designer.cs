
namespace Version2
{
    partial class dashBoard2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashBoard2));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnAddHotel = new System.Windows.Forms.Button();
            this.sideUpperPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.upperpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.mainPicture1 = new Version2.mainPicture();
            this.addHotel1 = new Version2.addHotel();
            this.addRoom1 = new Version2.addRoom();
            this.sidePanel.SuspendLayout();
            this.sideUpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.upperpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.sidePanel.Controls.Add(this.btnAddRoom);
            this.sidePanel.Controls.Add(this.btnAddHotel);
            this.sidePanel.Controls.Add(this.sideUpperPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(293, 749);
            this.sidePanel.TabIndex = 0;
            // 
            // btnAddHotel
            // 
            this.btnAddHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddHotel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddHotel.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHotel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddHotel.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHotel.Image")));
            this.btnAddHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddHotel.Location = new System.Drawing.Point(10, 236);
            this.btnAddHotel.Name = "btnAddHotel";
            this.btnAddHotel.Size = new System.Drawing.Size(272, 57);
            this.btnAddHotel.TabIndex = 3;
            this.btnAddHotel.Text = "         Add Hotel";
            this.btnAddHotel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddHotel.UseVisualStyleBackColor = true;
            this.btnAddHotel.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // sideUpperPanel
            // 
            this.sideUpperPanel.Controls.Add(this.label1);
            this.sideUpperPanel.Controls.Add(this.pictureBox2);
            this.sideUpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideUpperPanel.Location = new System.Drawing.Point(0, 0);
            this.sideUpperPanel.Name = "sideUpperPanel";
            this.sideUpperPanel.Size = new System.Drawing.Size(293, 211);
            this.sideUpperPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hotel Management \r\nSystem\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(56, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // upperpanel
            // 
            this.upperpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.upperpanel.Controls.Add(this.label2);
            this.upperpanel.Controls.Add(this.panel1);
            this.upperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperpanel.Location = new System.Drawing.Point(293, 0);
            this.upperpanel.Name = "upperpanel";
            this.upperpanel.Size = new System.Drawing.Size(1379, 211);
            this.upperpanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(79, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 137);
            this.panel1.TabIndex = 1;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaImageButton1.BackColor = System.Drawing.Color.White;
            this.gunaImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(1293, 36);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(64, 55);
            this.gunaImageButton1.TabIndex = 1;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1134, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.addRoom1);
            this.mainPanel.Controls.Add(this.mainPicture1);
            this.mainPanel.Controls.Add(this.addHotel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(293, 211);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1379, 538);
            this.mainPanel.TabIndex = 4;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRoom.Font = new System.Drawing.Font("Calisto MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRoom.Location = new System.Drawing.Point(10, 312);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(272, 57);
            this.btnAddRoom.TabIndex = 4;
            this.btnAddRoom.Text = "         Add Room ";
            this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // mainPicture1
            // 
            this.mainPicture1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPicture1.Location = new System.Drawing.Point(0, 0);
            this.mainPicture1.Name = "mainPicture1";
            this.mainPicture1.Size = new System.Drawing.Size(1379, 538);
            this.mainPicture1.TabIndex = 4;
            // 
            // addHotel1
            // 
            this.addHotel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addHotel1.Location = new System.Drawing.Point(0, 0);
            this.addHotel1.Name = "addHotel1";
            this.addHotel1.Size = new System.Drawing.Size(1379, 538);
            this.addHotel1.TabIndex = 0;
            // 
            // addRoom1
            // 
            this.addRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRoom1.Location = new System.Drawing.Point(0, 0);
            this.addRoom1.Name = "addRoom1";
            this.addRoom1.Size = new System.Drawing.Size(1379, 538);
            this.addRoom1.TabIndex = 5;
            // 
            // dashBoard2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 749);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.upperpanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashBoard2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashBoard2";
            this.Load += new System.EventHandler(this.dashBoard2_Load);
            this.sidePanel.ResumeLayout(false);
            this.sideUpperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.upperpanel.ResumeLayout(false);
            this.upperpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel sideUpperPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel upperpanel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddHotel;
        private System.Windows.Forms.Panel mainPanel;
        private addHotel addHotel1;
        private mainPicture mainPicture1;
        private System.Windows.Forms.Button btnAddRoom;
        private addRoom addRoom1;
    }
}