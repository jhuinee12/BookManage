﻿using System;
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
        string selectedBookName;
        string selectedWriteName;
        string selectedCopyName;
        string selectedRentDate;
        string selectedReturnExpectedDate;
        string selectedBookNumber;

        public RentForm(string selectedBookNumber)
        {
            InitializeComponent();
            dgvLoad();

            dgvBookList.CellMouseClick += dgvBookList_CellMouseClick;       // 셀 선택
            this.selectedBookNumber = selectedBookNumber;
        }

        private void dgvLoad()
        {
            string sql = "";
            string where0 = "where MemId like '" + LoginForm.memId + "' and returnDate = ''";
            string where1 = "where MemId like '" + LoginForm.memId + "' and not returnDate = ''";
            //sql = "select * from RentBook";
            if (BookListForm.btnClick == 0)
            {
                sql = "SELECT RentBook.RentNumber, bookList.bookName, bookList.writeName, bookList.copyName, RentBook.RentDate, RentBook.ReturnExpectDate " +
                        "FROM bookList JOIN RentBook ON rentbook.bookNumber = bookList.bookNumber " + where0;
            }
            else if (BookListForm.btnClick == 1)
            {
                sql = "SELECT RentBook.RentNumber, bookList.bookName, bookList.writeName, bookList.copyName, RentBook.RentDate, RentBook.ReturnExpectDate " +
                        "FROM bookList JOIN RentBook ON rentbook.bookNumber = bookList.bookNumber " + where1;
            }


            // 데이터베이스 연결
            dbc.Connection();
            dbc.Adaptor2(sql);
            dgvBookList.DataSource = DBConnection.ds.Tables[0];

            if (BookListForm.btnClick == 0 && int.Parse(dbc.count("rentBook", where0)) != 0)
            {
                selectedRentNumber = dgvBookList.Rows[0].Cells[0].Value.ToString();
                selectedBookName = dgvBookList.Rows[0].Cells[1].Value.ToString();
                selectedWriteName = dgvBookList.Rows[0].Cells[2].Value.ToString();
                selectedCopyName = dgvBookList.Rows[0].Cells[3].Value.ToString();
                selectedRentDate = dgvBookList.Rows[0].Cells[4].Value.ToString();
                selectedReturnExpectedDate = dgvBookList.Rows[0].Cells[5].Value.ToString();
            }
            else if (BookListForm.btnClick == 1 && int.Parse(dbc.count("rentBook", where1)) != 0)
            {
                selectedRentNumber = dgvBookList.Rows[0].Cells[0].Value.ToString();
                selectedBookName = dgvBookList.Rows[0].Cells[1].Value.ToString();
                selectedWriteName = dgvBookList.Rows[0].Cells[2].Value.ToString();
                selectedCopyName = dgvBookList.Rows[0].Cells[3].Value.ToString();
                selectedRentDate = dgvBookList.Rows[0].Cells[4].Value.ToString();

            }
        }

        private void dgvBookList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            selectedRentNumber = dgvBookList.Rows[rowIndex].Cells[0].Value.ToString();
            selectedBookName = dgvBookList.Rows[rowIndex].Cells[1].Value.ToString();
            selectedWriteName = dgvBookList.Rows[rowIndex].Cells[2].Value.ToString();
            selectedCopyName = dgvBookList.Rows[rowIndex].Cells[3].Value.ToString();
            selectedRentDate = dgvBookList.Rows[rowIndex].Cells[4].Value.ToString();
            selectedReturnExpectedDate = dgvBookList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string sql = "update rentbook set returndate = '" + DateTime.Now.ToString("yyyy-MM-dd") 
                + "' from rentbook where RentNumber = '" + selectedRentNumber + "'";

            dbc.Connection();
            dbc.Command(sql);

            int quantity = int.Parse(dbc.DataLoad("bookList", "where bookNumber = '" + selectedBookNumber + "'", "quantity")) +1;

            sql = "update BookList set quantity = " + quantity + " from BookList where bookNumber = '" + selectedBookNumber + "'";
            dbc.Connection();
            dbc.Command(sql);

            MessageBox.Show(selectedBookNumber + "도서를 반납합니다.");
            dgvLoad();
        }
    }
}
