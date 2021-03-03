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
    public partial class RentForm : Form
    {
        public static RentForm rf;
        DBConnection dbc = new DBConnection();
        // 선택된 데이터
        string selectedRentNumber;
        string selectedMemId;
        string selectedBookNumber;
        string selectedRentDate;
        string selectedReturnExpectedDate;

        public RentForm()
        {
            InitializeComponent();
            dgvLoad();

            dgvBookList.CellMouseClick += dgvBookList_CellMouseClick;       // 셀 선택

            if (LoginForm.root == 1) btnReturn.Visible = false;
        }

        private void dgvLoad()
        {
            string sql = "";
            //sql = "select * from RentBook";
            if (BookListForm.btnClick == 0)
            {
                if (LoginForm.root == 1)
                {
                    sql = "select rentNumber, memId, bookNumber, RentDate, ReturnExpectDate from RentBook where returnDate = ''";
                }
                else
                {
                    sql = "select rentNumber, memId, bookNumber, RentDate, ReturnExpectDate from RentBook where MemId like '" + LoginForm.memId + "' and returnDate = ''";
                }
            }
            else if (BookListForm.btnClick == 1)
            {
                if (LoginForm.root == 1)
                {
                    sql = "select * from RentBook where not returnDate = ''";
                }
                else
                {
                    sql = "select * from RentBook where MemId like '" + LoginForm.memId + "' and not returnDate = ''";
                }
            }


            // 데이터베이스 연결
            dbc.Connection();
            dbc.Adaptor2(sql);
            dgvBookList.DataSource = DBConnection.ds.Tables[0];
        }

        private void dgvBookList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            selectedRentNumber = dgvBookList.Rows[rowIndex].Cells[0].Value.ToString();
            selectedMemId = dgvBookList.Rows[rowIndex].Cells[1].Value.ToString();
            selectedBookNumber = dgvBookList.Rows[rowIndex].Cells[2].Value.ToString();
            selectedRentDate = dgvBookList.Rows[rowIndex].Cells[3].Value.ToString();
            selectedReturnExpectedDate = dgvBookList.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string sql = "update rentbook set returndate = '" + DateTime.Now.ToString("yyyy-MM-dd") 
                + "' from rentbook where RentNumber = '" + selectedRentNumber + "'";

            dbc.Connection();
            dbc.Command(sql);

            MessageBox.Show(selectedBookNumber + "도서를 반납합니다.");
            dgvLoad();
        }
    }
}
