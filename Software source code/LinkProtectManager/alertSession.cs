using System;
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
    public partial class alertSession : Form
    {
        public alertSession()
        {
            InitializeComponent();
        }

        private void session_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Login session expired!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            Application.Exit();
        }
    }
}
