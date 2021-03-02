﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    class DBConnection
    {
        public SqlConnection con;
        public DataSet ds;
        public SqlCommand cmd;
        //public bool login = false; // 로그인 상태 false
        public string strName = "";

        public void Connection()
        {
            // 데이터베이스 연결
            con = new SqlConnection(
                //"Server=192.168.1.142; Database=BookManage; user=jhuinee; password=1234");
                "Server=DESKTOP-UQD70L6; Database=BookManage; user=jhuinee; password=1234");
            con.Open();
        }

        public void Command(string str)
        {
            cmd = new SqlCommand(str, con);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void InputCommand(string str)
        {
            cmd = new SqlCommand(str, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("책이름: " + InputBookForm.ibf.tbBookName.Text
                    + "\n저자명: " + InputBookForm.ibf.tbWriteName.Text
                    + "\n출판사: " + InputBookForm.ibf.tbCopyName.Text + "\n 등록완료.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미 등록되어 있는 도서입니다."); ex.ToString();
            }
            cmd.Dispose();
        }

/*        public string countColumn()
        {
            Connection();
            try
            {
                if (cmd != null)
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT COUNT(*) FROM bookList";
                    object scalarValue = cmd.ExecuteScalar();
                    return string.Format("{0:D4}", (int)scalarValue+1);
                }
                else
                {
                    return "0001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "0";
            }
        }*/

        public void Adaptor(string str)
        {
            ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(str, con);

            try
            {
                adapter.Fill(ds, "BookList");
                BookListForm.blf.dgvBookList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Adaptor2(string str)
        {
            ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(str, con);

            try
            {
                adapter.Fill(ds, "RentBook");
                RentForm.rf.dgvBookList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void DataReader(ref bool login)
        {
            SqlDataReader mdr = cmd.ExecuteReader();

            try
            {
                while (mdr.Read())
                {
                    // 찾은 값의 id와 tbID가 일치하고 pw와 tbPW가 일치하면 로그인상태 true
                    if (LoginForm.lf.tbId.Text == (string)mdr["MemId"] && LoginForm.lf.tbPw.Text == (string)mdr["MemPw"])
                    {
                        strName = (string)mdr["MemName"];
                        if ((string)mdr["MemId"] == "root")
                            LoginForm.root = 1;
                        login = true;
                    }
                }
                mdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
