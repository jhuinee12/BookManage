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
    public partial class BookListForm : Form
    {
        public static BookListForm blf;

        DBConnection dbc = new DBConnection();
        string sql = "";

        #region 변수선언부
        // 선택된 데이터
        string whereStr;
        string selectedBookNumber;      // 선택된 셀의 도서번호
        string selectedBookName;        // 선택된 셀의 도서명
        string selectedWriteName;       // 선택된 셀의 저자명
        string selectedCopyName;        // 선택된 셀의 출판사
        int selectedQuantity;           // 선택된 셀의 수량

        // 수정된 데이터
        string changeStr;
        string changeBookNumber;        // 수정된 셀의 도서번호
        string changeBookName;          // 수정된 셀의 도서명
        string changeWriteName;         // 수정된 셀의 저자명
        string ChangeCopyName;          // 수정된 셀의 출판사
        int ChangeQuantity;             // 수정된 셀의 개수

        #endregion

        public BookListForm()
        {
            InitializeComponent();
            blf = this;
            Search();

            dgvBookList.CellMouseClick += dgvBookList_CellMouseClick;       // 셀 선택
            dgvBookList.CellValueChanged += dgvBookList_CellValueChanged;   // 셀 변경

            if (LoginForm.root == 1)
            {
                btnDel.Visible = true;
                btnInput.Visible = true;
                btnSave.Visible = true;
            }
            else
            {
                btnDel.Visible = false;
                btnInput.Visible = false;
                btnSave.Visible = false;
            }
        }

        private void dgvBookList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            selectedBookNumber = dgvBookList.Rows[rowIndex].Cells[0].Value.ToString();
            selectedBookName = dgvBookList.Rows[rowIndex].Cells[1].Value.ToString();
            selectedWriteName = dgvBookList.Rows[rowIndex].Cells[2].Value.ToString();
            selectedCopyName = dgvBookList.Rows[rowIndex].Cells[3].Value.ToString();
            selectedQuantity = Int32.Parse(dgvBookList.Rows[rowIndex].Cells[4].Value.ToString());

            // 조건절
            whereStr = "where BookNumber='" + selectedBookNumber + "'";
        }
        private void dgvBookList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            changeBookNumber = dgvBookList.Rows[rowIndex].Cells[0].Value.ToString();
            changeBookName = dgvBookList.Rows[rowIndex].Cells[1].Value.ToString();
            changeWriteName = dgvBookList.Rows[rowIndex].Cells[2].Value.ToString();
            ChangeCopyName = dgvBookList.Rows[rowIndex].Cells[2].Value.ToString();
            ChangeQuantity = Int32.Parse(dgvBookList.Rows[rowIndex].Cells[5].Value.ToString());

            // 업데이트 구문 입력
            changeStr = "BookNumber='" + changeBookNumber + ", BookName='" + changeBookName + "', WriteName='" + changeWriteName + "', "
                + "CopyName='" + ChangeCopyName + "', Quantity=" + ChangeQuantity;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Search()
        {
            if (rbBookName.Checked)
            {
                sql = "select * from BookList where bookName like '%" + tbSearch.Text + "%'";
            }
            else if (rbBookWr.Checked)
            {
                sql = "select * from BookList where WriteName like '%" + tbSearch.Text + "%'";
            }
            else
            {
                sql = "select * from BookList where CopyName like '%" + tbSearch.Text + "%'";
            }

            // 데이터베이스 연결
            dbc.Connection();
            dbc.Adaptor(sql);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InputBookForm ibf = new InputBookForm();
            ibf.ShowDialog();

            this.Visible = true;
            Search();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string str = "delete from BookList " + whereStr;

            // 접속하기
            dbc.Connection();
            dbc.Command(str);
            Search();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string str = "update BookList set " + changeStr + " " + whereStr;

            // 접속하기
            dbc.Connection();
            dbc.Command(str);
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (LoginForm.root == 1)
            {
                RentForm rf = new RentForm();
                rf.ShowDialog();
            }
            else
            {
                sql = "update BookList set quantity = " + (selectedQuantity - 1) + " from BookList " + whereStr;
                dbc.Connection();
                dbc.Command(sql);

                MessageBox.Show(selectedBookName + " 도서를 대출합니다.");

                sql = "select * from BookList";
                dbc.Connection();
                dbc.Adaptor(sql);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RentForm rf = new RentForm();
            rf.ShowDialog();

            this.Visible = true;
            Search();
        }
    }
}
