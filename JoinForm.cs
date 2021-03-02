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

namespace BookManage
{
    public partial class JoinForm : Form
    {
        DBConnection dbc = new DBConnection();
        public JoinForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Join();
            }
            catch (Exception)
            {
                MessageBox.Show("해당 아이디가 존재합니다.");
            }
        }

        private void Join()
        {
            // 데이터베이스 연결
            dbc.Connection();

            string sql = "insert into MemLogin values('"
                + tbMemName.Text + "', '" + tbMemBirth.Text + "', '" 
                + tbMemId.Text + "', '" + tbMemPw.Text + "', '" + tbMemPhone.Text + "', '" 
                + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "')";

            dbc.Command(sql);

            MessageBox.Show("<이름: " + tbMemName.Text + ", 아이디: " + tbMemId.Text + ">님이 가입합니다.");

            // this.Visible = false;
            this.Close();
            //Form1 f1 = new Form1(); // Form1의 이름 변경이 안되어있음 (LoginForm)
            //f1.ShowDialog();
        }
    }
}
