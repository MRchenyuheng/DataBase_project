﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Store
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(id.Text != "" && password.Text != "")
            {
                loginfun(1);
            }
            else
            {
                MessageBox.Show("输入项有空!");
            }
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        public Boolean loginfun(int x)
        {
            if(x == 1)
            {
                Dao dao = new Dao();
                //string sql = "select * from CustomerInfo where 客户编号 = '" + id.Text + "' and 客户密码 = '" + password.Text + "'";
                string sql = $"select * from CustomerInfo where 客户编号 = '{id.Text}' and 客户密码 = '{password.Text}'";
                //MessageBox.Show(sql);
                IDataReader dc = dao.read(sql);
                if(dc.Read())
                {
                    Data.UID = dc["客户编号"].ToString();
                    Data.UNAME = dc["客户姓名"].ToString();
                    this.Hide();
                    goods obj = new goods();  
                    obj.Show();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
                dao.DaoClose();
            }

            if (x == 2)
            {
                Dao dao = new Dao();
                //string sql = "select * from CustomerInfo where 客户编号 = '" + id.Text + "' and 客户密码 = '" + password.Text + "'";
                string sql = $"select * from adminInfo where uid = '{id.Text}' and password = '{password.Text}'";
                //MessageBox.Show(sql);
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    this.Hide();
                    goods obj = new goods();
                    obj.Show();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
                dao.DaoClose();
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && password.Text != "")
            {
                loginfun(2);
            }
            else
            {
                MessageBox.Show("输入项有空!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
