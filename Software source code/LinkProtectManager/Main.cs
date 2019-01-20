using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using System.Threading;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace LinkProtectManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Thread ss;

        private void Main_Load(object sender, EventArgs e)
        {
            string URI = value.webapi + "settings.php", content = "session=" + value.session;

            using (WebClient wc = new WebClient())
            {
                try
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    string settingsContent = wc.UploadString(URI, content);

                    JObject setting = JObject.Parse(settingsContent);

                    value.pageid = setting["page_id"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            ss = new Thread(new ThreadStart(session_check));
            ss.IsBackground = true;
            ss.Start();

            get_list_url();
        }

        private void session_check()
        {
            while (true)
            {
                try
                {
                    string s = new WebClient().DownloadString("https://nghia.org/api/sw/?session=" + value.session);

                    if (s == "false")
                    {
                        this.Controls.Clear();

                        alertSession ses = new alertSession();
                        ses.ShowDialog();
                        ss.Abort(); break;
                    }

                    Thread.Sleep(1000);
                }
                catch { }
            }
        }

        private void get_list_url()
        {
            LinkProtectList.Rows.Clear();
            LinkProtectList.Refresh();

            string URI = value.webapi + "link.php?list=view", loginContent = "session=" + value.session;

            using (WebClient wc = new WebClient())
            {
                try
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    string loginResult = wc.UploadString(URI, loginContent);

                    // Decode login json 


                    JArray data = JArray.Parse(loginResult);

                    foreach (JObject d in data)
                    {
                        string email = (Convert.ToString(d["email"]) != "") ? Convert.ToString(d["email"]) : "no public";
                        string gender = (Convert.ToString(d["gender"]) != "") ? Convert.ToString(d["gender"]) : "no public";

                        LinkProtectList.Rows.Add(false, d["id"], d["TargetID"], d["PostID"], d["Hash"], d["Password"], d["SUrl"], d["Url"]);
                    }

                }
                catch (Exception o)
                {
                    MessageBox.Show("Cant get url list!" + o, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateLinkProtect_Click(object sender, EventArgs e)
        {
            if (LinkProtect.Text != "")
            {
                try
                {
                    LinkProtect.Enabled = false; LinkPassword.Enabled = false; CreateLinkProtect.Enabled = false;

                    string URI = value.webapi + "link.php?do=create", content = "link=" + LinkProtect.Text + "&pass=" + LinkPassword.Text + "&userid=" + value.userid + "&target=" + value.pageid + "&session=" + value.session;

                    using (WebClient wc = new WebClient())
                    {
                        try
                        {
                            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                            string linkContent = wc.UploadString(URI, content);

                            if (linkContent != "")
                            {
                                LinkProtect.Text = linkContent;
                                get_list_url();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch { }
                finally
                {
                    LinkProtect.Enabled = true; LinkPassword.Enabled = true; CreateLinkProtect.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser brw = new browser();
            brw.ShowDialog();

            if (value.accesstoken != "")
            {
                try
                {
                    string jsonProfile = new WebClient().DownloadString("https://graph.facebook.com/me/?access_token=" + value.accesstoken);

                    JObject user = JObject.Parse(jsonProfile);

                    value.userid = user["id"].ToString();

                    user_name.Text = user["name"].ToString();
                    profile_picture.ImageLocation = "https://graph.facebook.com/" + user["id"].ToString() + "/picture?type=large&redirect=true&width=48&height=48";

                    user_name.Visible = true;
                    profile_picture.Visible = true;
                    login_type.Visible = true;

                    login_alert.Visible = false;
                    loginfb.Visible = false;

                    LinkProtect.Enabled = true;
                    LinkPassword.Enabled = true;
                    CreateLinkProtect.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Cant parse information!", "Parse Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteLinkProtectBtn_Click(object sender, EventArgs e)
        {
            var checkedRows = from DataGridViewRow r in LinkProtectList.Rows
                              where Convert.ToBoolean(r.Cells[0].Value) == true
                              select r;

            if (checkedRows.Count() > 0)
            {
                try
                {
                    foreach (var row in checkedRows)
                    {
                        string URI = "https://nghia.org/api/sw/action.php?do=delete", content = "linkid=" + row.Cells["ID"].Value.ToString() + "&session=" + value.session;

                        using (WebClient wc = new WebClient())
                        {
                            try
                            {
                                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                                wc.UploadString(URI, content);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        //.Show(row.Cells["ID"].Value.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { get_list_url(); }
            }
        }
    }
}
