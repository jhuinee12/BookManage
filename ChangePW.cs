using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    public partial class ChangePW : Form
    {
        String memId;
        String memName;
        String memBirth;
        String memPhone;
        String nowPw;
        String ChangePw;

        DBConnection dbc = new DBConnection();

        public ChangePW()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memId = tbMemId.Text;
            memName = tbMemName.Text;
            memBirth = tbMemBirth.Text;
            memPhone = tbMemPhone.Text;
            nowPw = tbNowPw.Text;
            ChangePw = tbChangePW.Text;

            if (memName == dbc.DataLoad("memLogin", "where memId = '" + memId + "'", "memName")
                && memBirth == dbc.DataLoad("memLogin", "where memId = '" + memId + "'", "memBirth")
                && memPhone == dbc.DataLoad("memLogin", "where memId = '" + memId + "'", "memPhone")
                && nowPw == dbc.DataLoad("memLogin", "where memId = '" + memId + "'", "memPw"))
            {

                string sql = "update memLogin set memPw = '" + ChangePw
                    + "' from memLogin where memId = '" + memId + "'";

                dbc.Connection();
                dbc.Command(sql);

                MessageBox.Show("비밀번호가 성공적으로 변경되었습니다.");

                this.Close();
            }
            else
            {
                MessageBox.Show("회원 정보가 일치하지 않습니다.\n 다시 확인해주시기 바랍니다.");
            }
        }
    }
}
