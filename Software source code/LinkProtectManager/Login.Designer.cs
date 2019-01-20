namespace LinkProtectManager
{
    partial class Login
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
            this.web = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.loginweb = new System.Windows.Forms.Button();
            this.remember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "web api";
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(16, 33);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(318, 26);
            this.web.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(16, 78);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(318, 26);
            this.password.TabIndex = 3;
            // 
            // loginweb
            // 
            this.loginweb.Location = new System.Drawing.Point(259, 106);
            this.loginweb.Name = "loginweb";
            this.loginweb.Size = new System.Drawing.Size(75, 28);
            this.loginweb.TabIndex = 4;
            this.loginweb.Text = "Login";
            this.loginweb.UseVisualStyleBackColor = true;
            this.loginweb.Click += new System.EventHandler(this.loginweb_Click);
            // 
            // remember
            // 
            this.remember.AutoSize = true;
            this.remember.Location = new System.Drawing.Point(16, 109);
            this.remember.Name = "remember";
            this.remember.Size = new System.Drawing.Size(107, 24);
            this.remember.TabIndex = 5;
            this.remember.Text = "remember";
            this.remember.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 140);
            this.Controls.Add(this.remember);
            this.Controls.Add(this.loginweb);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.web);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox web;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginweb;
        private System.Windows.Forms.CheckBox remember;
    }
}

