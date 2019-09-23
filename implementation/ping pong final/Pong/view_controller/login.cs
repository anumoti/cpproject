using Pong.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong.view_controller
{
    public partial class login : Form
    {
        Users u = new Users();
        public login()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtuname.Text = txtpass.Text = "";
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            registration r = new registration();
            r.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            u.username = txtuname.Text;
            u.password = txtpass.Text;
            u.id = loginsystem(u.username, u.password);
            if (u.id > 0)
            {
                Form id = new GameForm();
                id.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }
        }

        public int loginsystem(string uname, string pass)
        {
            string name = uname;
            string password = pass;
            string query = "select * from tbl_users where username='" + name + "' and password='" + password + "'";
            data db = new data(query);
            DataTable dt = db.getdatatable();
            if (dt.Rows.Count == 1)
            {
                return Convert.ToInt32(dt.Rows[0]["id"]);
            }
            else
            {
                return 0;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {
            registration r = new registration();
            r.Show();
            this.Hide();
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            txtuname.Text = txtpass.Text = "";
        }
    }
}
