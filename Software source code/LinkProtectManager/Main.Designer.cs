namespace LinkProtectManager
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.login_alert = new System.Windows.Forms.Label();
            this.loginfb = new System.Windows.Forms.Button();
            this.CreateLinkProtect = new System.Windows.Forms.Button();
            this.LinkPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LinkProtect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkProtectList = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HashUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.login_type = new System.Windows.Forms.Label();
            this.profile_picture = new System.Windows.Forms.PictureBox();
            this.user_name = new System.Windows.Forms.Label();
            this.DeleteLinkProtectBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinkProtectList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.login_alert);
            this.groupBox1.Controls.Add(this.loginfb);
            this.groupBox1.Controls.Add(this.CreateLinkProtect);
            this.groupBox1.Controls.Add(this.LinkPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LinkProtect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Link Protect";
            // 
            // login_alert
            // 
            this.login_alert.AutoSize = true;
            this.login_alert.Location = new System.Drawing.Point(7, 124);
            this.login_alert.Name = "login_alert";
            this.login_alert.Size = new System.Drawing.Size(240, 16);
            this.login_alert.TabIndex = 5;
            this.login_alert.Text = "Please login with Facebook to continue";
            // 
            // loginfb
            // 
            this.loginfb.Location = new System.Drawing.Point(326, 119);
            this.loginfb.Name = "loginfb";
            this.loginfb.Size = new System.Drawing.Size(76, 28);
            this.loginfb.TabIndex = 3;
            this.loginfb.Text = "Login";
            this.loginfb.UseVisualStyleBackColor = true;
            this.loginfb.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateLinkProtect
            // 
            this.CreateLinkProtect.Enabled = false;
            this.CreateLinkProtect.Location = new System.Drawing.Point(408, 119);
            this.CreateLinkProtect.Name = "CreateLinkProtect";
            this.CreateLinkProtect.Size = new System.Drawing.Size(75, 28);
            this.CreateLinkProtect.TabIndex = 4;
            this.CreateLinkProtect.Text = "Create";
            this.CreateLinkProtect.UseVisualStyleBackColor = true;
            this.CreateLinkProtect.Click += new System.EventHandler(this.CreateLinkProtect_Click);
            // 
            // LinkPassword
            // 
            this.LinkPassword.Enabled = false;
            this.LinkPassword.Location = new System.Drawing.Point(10, 90);
            this.LinkPassword.Name = "LinkPassword";
            this.LinkPassword.Size = new System.Drawing.Size(474, 22);
            this.LinkPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // LinkProtect
            // 
            this.LinkProtect.Enabled = false;
            this.LinkProtect.Location = new System.Drawing.Point(10, 42);
            this.LinkProtect.Name = "LinkProtect";
            this.LinkProtect.Size = new System.Drawing.Size(474, 22);
            this.LinkProtect.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link";
            // 
            // LinkProtectList
            // 
            this.LinkProtectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LinkProtectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.ID,
            this.TargetID,
            this.PostID,
            this.HashUrl,
            this.Password,
            this.ShortLink,
            this.Url});
            this.LinkProtectList.Location = new System.Drawing.Point(12, 174);
            this.LinkProtectList.Name = "LinkProtectList";
            this.LinkProtectList.Size = new System.Drawing.Size(972, 262);
            this.LinkProtectList.TabIndex = 1;
            // 
            // Select
            // 
            this.Select.HeaderText = "X";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Width = 30;
            // 
            // ID
            // 
            this.ID.HeaderText = "LinkID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // TargetID
            // 
            this.TargetID.HeaderText = "Target ID";
            this.TargetID.Name = "TargetID";
            this.TargetID.ReadOnly = true;
            this.TargetID.Width = 130;
            // 
            // PostID
            // 
            this.PostID.HeaderText = "Post ID";
            this.PostID.Name = "PostID";
            this.PostID.ReadOnly = true;
            this.PostID.Width = 130;
            // 
            // HashUrl
            // 
            this.HashUrl.HeaderText = "HashUrl";
            this.HashUrl.Name = "HashUrl";
            this.HashUrl.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "PasswordUrl";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // ShortLink
            // 
            this.ShortLink.HeaderText = "ShortLink";
            this.ShortLink.Name = "ShortLink";
            this.ShortLink.Width = 150;
            // 
            // Url
            // 
            this.Url.HeaderText = "Url";
            this.Url.Name = "Url";
            this.Url.Width = 220;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.login_type);
            this.groupBox2.Controls.Add(this.profile_picture);
            this.groupBox2.Controls.Add(this.user_name);
            this.groupBox2.Location = new System.Drawing.Point(510, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // login_type
            // 
            this.login_type.AutoSize = true;
            this.login_type.Location = new System.Drawing.Point(60, 36);
            this.login_type.Name = "login_type";
            this.login_type.Size = new System.Drawing.Size(106, 16);
            this.login_type.TabIndex = 2;
            this.login_type.Text = "Facebook Login";
            this.login_type.Visible = false;
            // 
            // profile_picture
            // 
            this.profile_picture.ImageLocation = "";
            this.profile_picture.Location = new System.Drawing.Point(6, 16);
            this.profile_picture.Name = "profile_picture";
            this.profile_picture.Size = new System.Drawing.Size(48, 48);
            this.profile_picture.TabIndex = 1;
            this.profile_picture.TabStop = false;
            this.profile_picture.Visible = false;
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(59, 16);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(98, 20);
            this.user_name.TabIndex = 0;
            this.user_name.Text = "user_name";
            this.user_name.Visible = false;
            // 
            // DeleteLinkProtectBtn
            // 
            this.DeleteLinkProtectBtn.Location = new System.Drawing.Point(909, 442);
            this.DeleteLinkProtectBtn.Name = "DeleteLinkProtectBtn";
            this.DeleteLinkProtectBtn.Size = new System.Drawing.Size(75, 35);
            this.DeleteLinkProtectBtn.TabIndex = 3;
            this.DeleteLinkProtectBtn.Text = "Delete";
            this.DeleteLinkProtectBtn.UseVisualStyleBackColor = true;
            this.DeleteLinkProtectBtn.Click += new System.EventHandler(this.DeleteLinkProtectBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 481);
            this.Controls.Add(this.DeleteLinkProtectBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LinkProtectList);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Link Protect Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinkProtectList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LinkProtect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LinkPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView LinkProtectList;
        private System.Windows.Forms.Button CreateLinkProtect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button loginfb;
        private System.Windows.Forms.PictureBox profile_picture;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label login_type;
        private System.Windows.Forms.Label login_alert;
        private System.Windows.Forms.Button DeleteLinkProtectBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HashUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
    }
}