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
        string whereStr;
        string selectedRentNumber;          // 대여번호
        string selectedBookName;            // 선택된 셀의 도서명
        string selectedWriteName;           // 선택된 셀의 저자명
        string selectedCopyName;            // 선택된 셀의 출판사
        string selectedRentDate;            // 선택된 셀의 수량
        string selectedReturnExpectedDate;  // 선택된 셀의 반납 예정일

        public RentForm()
        {
            InitializeComponent();
            Load();

            dgvBookList.CellMouseClick += dgvBookList_CellMouseClick;       // 셀 선택
        }

        private void Load()
        {
            string sql = "select * from RentBook where MemId like '" + LoginForm.memId + "' and rentExpedtedDate is null";

            // 데이터베이스 연결
            dbc.Connection();
            dbc.Adaptor2(sql);
        }

        private void dgvBookList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            selectedBookName = dgvBookList.Rows[rowIndex].Cells[0].Value.ToString();
            selectedWriteName = dgvBookList.Rows[rowIndex].Cells[1].Value.ToString();
            selectedCopyName = dgvBookList.Rows[rowIndex].Cells[2].Value.ToString();
            selectedRentDate = dgvBookList.Rows[rowIndex].Cells[3].Value.ToString();
            selectedReturnExpectedDate = dgvBookList.Rows[rowIndex].Cells[4].Value.ToString();
            selectedRentNumber = dgvBookList.Rows[rowIndex].Cells[5].Value.ToString();

            // 조건절
            whereStr = "where BookNumber='" + selectedRentNumber + "'";
        }
    }
}
