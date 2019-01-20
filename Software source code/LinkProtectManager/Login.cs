using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;


namespace LinkProtectManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.AcceptButton = loginweb;
        }

        WebClient wc;

        private void loginweb_Click(object sender, EventArgs e)
        {
            string URI = web.Text + "/", loginContent = "password=" + password.Text;

            using (wc = new WebClient())
            {
                try
                {
                    web.Enabled = false; password.Enabled = false; loginweb.Enabled = false;

                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    string loginResult = wc.UploadString(URI, loginContent);

                    // Decode login json 
                    JObject login = JObject.Parse(loginResult);
                    //MessageBox.Show(login["session"].ToString());

                    if(login["session"].ToString() != "")
                    {
                        if (remember.Checked)
                        {
                            string[] loginRemeber = { "web=" + web.Text, "password=" + password.Text};
                            try
                            {
                                if(File.Exists("login.rm"))
                                {
                                    if(loginRemeber != File.ReadAllLines("login.rm"))
                                    {
                                        File.WriteAllLines("login.rm", loginRemeber);
                                    }
                                }
                            }
                            catch { }
                        }

                        value.webapi = web.Text + "/";
                        value.session = login["session"].ToString();
                        Main main = new Main();
                        main.Show();
                        this.Hide();

                        main.Closed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password or web url not correct!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception o)
                {
                    MessageBox.Show("Response server has crashed!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    web.Enabled = true; password.Enabled = true; loginweb.Enabled = true;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Debug.Write(FileMD5(@"lib.dll"));
            //check internet connection
            if (!LoadInternet())
            {
                MessageBox.Show("No internet connection!", "Network error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            //check lib.dll (NewtonSoft.Json)
            if(File.Exists(@"lib.dll"))
            {
                if(FileMD5(@"lib.dll") != "df237ed846d7f2f0bacdd0035b52cb70")
                {
                    MessageBox.Show("Cant load lib.dll!", "Failed to load file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            else
            {
                MessageBox.Show("Lib.dll is missing!", "Failed to load file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            //load remember
            if (File.Exists("login.rm"))
            {
                string[] loginRemember = File.ReadAllLines("login.rm");
                try
                {
                    web.Text = loginRemember[0].Split(new char[] { '=' })[1].ToString();
                    password.Text = loginRemember[1].Split(new char[] { '=' })[1].ToString();

                    remember.Checked = true;
                }
                catch
                {
                    try
                    {
                        File.Delete("login.rm");
                    }
                    catch { }
                }
            }
        }

        private bool LoadInternet()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private string FileMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}
