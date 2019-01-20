namespace LinkProtectManager
{
    partial class browser
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
            this.loginForm = new System.Windows.Forms.WebBrowser();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // loginForm
            // 
            this.loginForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginForm.Location = new System.Drawing.Point(0, 0);
            this.loginForm.MinimumSize = new System.Drawing.Size(20, 20);
            this.loginForm.Name = "loginForm";
            this.loginForm.Size = new System.Drawing.Size(974, 529);
            this.loginForm.TabIndex = 0;
            this.loginForm.Url = new System.Uri("", System.UriKind.Relative);
            this.loginForm.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.loginForm_DocumentCompleted);
            // 
            // browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 529);
            this.Controls.Add(this.loginForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.browser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser loginForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}