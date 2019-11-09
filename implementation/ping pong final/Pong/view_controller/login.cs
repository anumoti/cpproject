using Pong.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pong.Module;

namespace Pong.view_controller
{
    public partial class login : Form
    {
        Validation vd = new Validation();
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
           bool a= vd.checkcredentials(txtuname.Text,txtpass.Text);
            if (a==true)
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
