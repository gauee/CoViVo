namespace WindowsFormsApplication1
{
    partial class CoViVo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoViVo));
            this.Send_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Options = new System.Windows.Forms.ToolStripMenuItem();
            this.connectTool = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.ToolStripMenuItem();
            this.AvailableTool = new System.Windows.Forms.ToolStripMenuItem();
            this.BeBackTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DisturbTool = new System.Windows.Forms.ToolStripMenuItem();
            this.UnavailableTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutTool = new System.Windows.Forms.ToolStripMenuItem();
            this.conv_box = new System.Windows.Forms.TextBox();
            this.YourBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Send_button
            // 
            this.Send_button.BackColor = System.Drawing.SystemColors.Window;
            this.Send_button.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Send_button.ForeColor = System.Drawing.Color.DimGray;
            this.Send_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Send_button.Location = new System.Drawing.Point(338, 373);
            this.Send_button.Margin = new System.Windows.Forms.Padding(10);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(80, 29);
            this.Send_button.TabIndex = 1;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = false;
            this.Send_button.Click += new System.EventHandler(this.button_send);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Options,
            this.Status,
            this.Settings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 442);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_Clicked);
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectTool,
            this.disconnectTool});
            this.Options.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Options.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(61, 20);
            this.Options.Text = "Options";
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // connectTool
            // 
            this.connectTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.connectTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.connectTool.Image = ((System.Drawing.Image)(resources.GetObject("connectTool.Image")));
            this.connectTool.Name = "connectTool";
            this.connectTool.Size = new System.Drawing.Size(152, 22);
            this.connectTool.Text = "Connect";
            this.connectTool.Click += new System.EventHandler(this.connectTool_Click);
            // 
            // disconnectTool
            // 
            this.disconnectTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.disconnectTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.disconnectTool.Image = ((System.Drawing.Image)(resources.GetObject("disconnectTool.Image")));
            this.disconnectTool.Name = "disconnectTool";
            this.disconnectTool.Size = new System.Drawing.Size(152, 22);
            this.disconnectTool.Text = "Disconnect";
            this.disconnectTool.Click += new System.EventHandler(this.disconnectTool_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Status.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AvailableTool,
            this.BeBackTool,
            this.DisturbTool,
            this.UnavailableTool});
            this.Status.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Status.ImageTransparentColor = System.Drawing.Color.White;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(51, 20);
            this.Status.Text = "Status";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // AvailableTool
            // 
            this.AvailableTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AvailableTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AvailableTool.Image = ((System.Drawing.Image)(resources.GetObject("AvailableTool.Image")));
            this.AvailableTool.Name = "AvailableTool";
            this.AvailableTool.Size = new System.Drawing.Size(152, 22);
            this.AvailableTool.Text = "Available";
            this.AvailableTool.Click += new System.EventHandler(this.Available_Click);
            // 
            // BeBackTool
            // 
            this.BeBackTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BeBackTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BeBackTool.Image = ((System.Drawing.Image)(resources.GetObject("BeBackTool.Image")));
            this.BeBackTool.Name = "BeBackTool";
            this.BeBackTool.Size = new System.Drawing.Size(152, 22);
            this.BeBackTool.Text = "Be right back";
            this.BeBackTool.Click += new System.EventHandler(this.BeBack_Click);
            // 
            // DisturbTool
            // 
            this.DisturbTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DisturbTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DisturbTool.Image = ((System.Drawing.Image)(resources.GetObject("DisturbTool.Image")));
            this.DisturbTool.Name = "DisturbTool";
            this.DisturbTool.Size = new System.Drawing.Size(152, 22);
            this.DisturbTool.Text = "Don\'t disturb";
            this.DisturbTool.Click += new System.EventHandler(this.Disturb_Click);
            // 
            // UnavailableTool
            // 
            this.UnavailableTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.UnavailableTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UnavailableTool.Image = ((System.Drawing.Image)(resources.GetObject("UnavailableTool.Image")));
            this.UnavailableTool.Name = "UnavailableTool";
            this.UnavailableTool.Size = new System.Drawing.Size(152, 22);
            this.UnavailableTool.Text = "Unavailable";
            this.UnavailableTool.Click += new System.EventHandler(this.Unavailable_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutTool});
            this.Settings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(61, 20);
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // LogoutTool
            // 
            this.LogoutTool.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LogoutTool.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogoutTool.Name = "LogoutTool";
            this.LogoutTool.Size = new System.Drawing.Size(152, 22);
            this.LogoutTool.Text = "Log out";
            this.LogoutTool.Click += new System.EventHandler(this.logout_Click);
            // 
            // conv_box
            // 
            this.conv_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.conv_box.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.conv_box.ForeColor = System.Drawing.SystemColors.MenuText;
            this.conv_box.Location = new System.Drawing.Point(12, 12);
            this.conv_box.Multiline = true;
            this.conv_box.Name = "conv_box";
            this.conv_box.Size = new System.Drawing.Size(406, 167);
            this.conv_box.TabIndex = 5;
            this.conv_box.Text = "Conversation box";
            this.conv_box.TextChanged += new System.EventHandler(this.Conv_box);
            // 
            // YourBox
            // 
            this.YourBox.BackColor = System.Drawing.SystemColors.Control;
            this.YourBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YourBox.Location = new System.Drawing.Point(179, 294);
            this.YourBox.Margin = new System.Windows.Forms.Padding(1);
            this.YourBox.Multiline = true;
            this.YourBox.Name = "YourBox";
            this.YourBox.Size = new System.Drawing.Size(239, 68);
            this.YourBox.TabIndex = 6;
            this.YourBox.Text = "Your message...\r\n\r\n";
            this.YourBox.TextChanged += new System.EventHandler(this.Your_box);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(338, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Voice";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Voice_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox2.Location = new System.Drawing.Point(338, 230);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 19);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Video";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.Video_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 373);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 29);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // CoViVo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.YourBox);
            this.Controls.Add(this.conv_box);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoViVo";
            this.Text = "CoViVo";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.form_load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Options;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripMenuItem Status;
        private System.Windows.Forms.TextBox conv_box;
        private System.Windows.Forms.ToolStripMenuItem LogoutTool;
        private System.Windows.Forms.ToolStripMenuItem AvailableTool;
        private System.Windows.Forms.ToolStripMenuItem BeBackTool;
        private System.Windows.Forms.ToolStripMenuItem DisturbTool;
        private System.Windows.Forms.ToolStripMenuItem UnavailableTool;
        private System.Windows.Forms.TextBox YourBox;
        private System.Windows.Forms.ToolStripMenuItem connectTool;
        private System.Windows.Forms.ToolStripMenuItem disconnectTool;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

