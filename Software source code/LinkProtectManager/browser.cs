using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkProtectManager
{
    public partial class browser : Form
    {
        public browser()
        {
            InitializeComponent();
        }

        private void browser_Load(object sender, EventArgs e)
        {
            loginForm.Url = new Uri("https://nghia.org/api/sw/login.php?session=" + value.session);

            this.Text = "Login (Waiting for login...)";
        }

        private void loginForm_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (loginForm.Url.ToString().Contains("https://nghia.org/api/sw/login.php"))
            {
                try
                {
                    if(loginForm.DocumentText != "1")
                    {
                        this.Text = "Login (Detected!)";
                        string doc = new WebClient().DownloadString("https://graph.facebook.com/me/?access_token=" + loginForm.DocumentText);
                        value.accesstoken = loginForm.DocumentText;
                    }
                    else
                    {
                        MessageBox.Show("You're logged to Facebook", "Login details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        value.accesstoken = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Cant not login to Facebook!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    value.accesstoken = "";
                }
                finally
                {
                    loginForm.Stop();
                    this.Close();
                }
            }
        }
    }
}
