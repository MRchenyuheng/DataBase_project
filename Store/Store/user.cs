using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yuhengchen\Documents\easystore.mdf;Integrated Security=True;Connect Timeout=30");


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string acc = userid.Text; string psword = userpsword.Text;
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CustomerInfo where 客户编号 = '" + acc + "' and 客户密码 = '" + psword + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (username.Text != "" && newpsword.Text != "" && usertele.Text != "" && usercity.Text != "")
                {
                    try
                    {
                        //string query = "insert into CustomerInfo values('" + userid.Text + "','" + username.Text + "','" + newpsword.Text + "','" + usergender.Text + "','" + usercity.Text + "','" + usertele.Text + "','" + useremail.Text + "')";
                        string query = "update CustomerInfo set 客户姓名 = '" + username.Text + "', 客户密码 = '" + newpsword.Text + "' ,性别 = '" + usergender.Text + "',所在地址 = '" + usercity.Text + "',联系电话 = '" + usertele.Text + "',邮箱 = '" + useremail.Text + "'  where 客户编号 = '" + acc + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("保存成功！");
                    }
                    catch(Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("信息缺失！");
                }
            }
            else
            {
                MessageBox.Show("账号或密码错误！");
            }
            con.Close();
        }
    }
}
