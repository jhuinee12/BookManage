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
    public partial class InputBookForm : Form
    {
        public static InputBookForm ibf;
        public static int count;
        DBConnection dbc = new DBConnection();

        public InputBookForm()
        {
            InitializeComponent();
            ibf = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Insert()
        {
            string bookNumber = "BK" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string sql = "insert into BookList values('" + bookNumber + "', '"
                + tbBookName.Text + "', '" + tbWriteName.Text + "', '" + tbCopyName.Text + "', '" + tbQuantity.Text + "')";

            dbc.Connection();
            dbc.InputCommand(sql);

/*            this.Visible = false;
            BookListForm blf = new BookListForm();
            blf.ShowDialog();*/

            this.Close();
        }
    }
}
