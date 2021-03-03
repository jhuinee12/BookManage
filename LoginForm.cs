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
    public partial class LoginForm : Form
    {
        public static LoginForm lf;
        public static int root;
        public static string memId;

        DBConnection dbc = new DBConnection();
        public LoginForm()
        {
            InitializeComponent();
            lf = this;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Login() 함수 실행
            Login();
        }

        private void Login()
        {
            bool login = false; // 로그인 상태 false
            //string strName = "";

            // 데이터베이스 연결
            dbc.Connection();

            memId = tbId.Text;
            // tbID에 입력된 값으로 데이터 찾기
            string str = "select * from MemLogin where MemId='" + memId + "'";

            dbc.Command(str);
            dbc.DataReader(ref login);


            // 로그인 상태가 true일 때
            if (login)
            {
                MessageBox.Show(dbc.strName + "님이 로그인합니다.");

                this.Visible = false;
                BookListForm blf = new BookListForm();
                blf.ShowDialog();

                this.Visible = true;
                tbId.Text = "";
                tbPw.Text = "";
                root = 0;
            }
            // 로그인 상태가 false일 때
            else
            {
                MessageBox.Show("아이디와 비밀번호를 확인하여 주세요.");
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            JoinForm jf = new JoinForm();
            jf.ShowDialog();

            this.Visible = true;
        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            ChangePW cpw = new ChangePW();
            this.Visible = false;
            cpw.ShowDialog();

            this.Visible = true;
        }
    }
}
