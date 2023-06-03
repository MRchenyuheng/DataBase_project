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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Store
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

      
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
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dao dao = new Dao();
            string uid = Data.UID.ToString();
           // string uname = $"{username.Text}";
            string sql = $"select * from CustomerInfo where 客户编号 = 'uid' and 客户密码 = '{userpsword.Text}'";
            //MessageBox.Show(sql);
            IDataReader dc = dao.read(sql);
            if (dc.Read())
            {
                Data.UID = dc["客户编号"].ToString();
                //Data.UNAME = dc["客户姓名"].ToString();
                //this.Hide();
                //goods obj = new goods();
                //obj.Show();
                //this.Show();
                MessageBox.Show("密码修改成功");
            }
            else
            {
                MessageBox.Show("密码修改失败");
            }
            dao.DaoClose();
        }
    }
}
