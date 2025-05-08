namespace MobileShopManagementSystem
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPhonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(114, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome To Mobile Shop Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ver.1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MobileShopManagementSystem.Properties.Resources.mobile_showroom_interiors_500x500;
            this.pictureBox1.Location = new System.Drawing.Point(42, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::MobileShopManagementSystem.Properties.Resources._5S_6S_pink_color_phone_case_For_iphone_5_6_6_plus_6s_plus_mobile_phone_jpg_350x350;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPhoneToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.viewPhonesToolStripMenuItem,
            this.viewCustomersToolStripMenuItem,
            this.deletePhoneToolStripMenuItem,
            this.searchPhoneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newPhoneToolStripMenuItem
            // 
            this.newPhoneToolStripMenuItem.Font = new System.Drawing.Font("High Tower Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPhoneToolStripMenuItem.Name = "newPhoneToolStripMenuItem";
            this.newPhoneToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.newPhoneToolStripMenuItem.Text = "Add New Phone";
            this.newPhoneToolStripMenuItem.Click += new System.EventHandler(this.newPhoneToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Font = new System.Drawing.Font("High Tower Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // viewPhonesToolStripMenuItem
            // 
            this.viewPhonesToolStripMenuItem.Font = new System.Drawing.Font("High Tower Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPhonesToolStripMenuItem.Name = "viewPhonesToolStripMenuItem";
            this.viewPhonesToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.viewPhonesToolStripMenuItem.Text = "Stock";
            this.viewPhonesToolStripMenuItem.Click += new System.EventHandler(this.viewPhonesToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Font = new System.Drawing.Font("High Tower Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.viewCustomersToolStripMenuItem.Text = "View Customers Record";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // deletePhoneToolStripMenuItem
            // 
            this.deletePhoneToolStripMenuItem.Font = new System.Drawing.Font("High Tower Text", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePhoneToolStripMenuItem.Name = "deletePhoneToolStripMenuItem";
            this.deletePhoneToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.deletePhoneToolStripMenuItem.Text = "Delete Phone Record";
            this.deletePhoneToolStripMenuItem.Click += new System.EventHandler(this.deletePhoneToolStripMenuItem_Click);
            // 
            // searchPhoneToolStripMenuItem
            // 
            this.searchPhoneToolStripMenuItem.Name = "searchPhoneToolStripMenuItem";
            this.searchPhoneToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.searchPhoneToolStripMenuItem.Text = "Search Phone Record";
            this.searchPhoneToolStripMenuItem.Click += new System.EventHandler(this.searchPhoneToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPhonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPhoneToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}