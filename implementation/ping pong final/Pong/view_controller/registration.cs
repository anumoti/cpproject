﻿using Pong.database;
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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Validation vd = new Validation();
            bool a = vd.checkemail(txtemail.Text);
            if (a == true)
            {


                string query = "insert into usertbl values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtemail.Text + "','" + txtuname.Text + "','" + txtpass.Text + "')";
                data db = new data(query);
                db.executequery();
                MessageBox.Show("User Registered");
            }
            else
            {
                MessageBox.Show("Incorrect Email");
            }
            txtfname.Text = txtlname.Text = txtemail.Text = txtuname.Text = txtpass.Text = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfname.Text = txtlname.Text = txtemail.Text = txtuname.Text = txtpass.Text = "";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
