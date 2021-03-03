namespace BookManage
{
    partial class RentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBookCopy = new System.Windows.Forms.RadioButton();
            this.rbBookWr = new System.Windows.Forms.RadioButton();
            this.rbBookName = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.dgvBookList);
            this.panel2.Location = new System.Drawing.Point(12, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 328);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "대여 가능 권수 : 3권";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(698, 279);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 40);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "도서반납";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(3, 3);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowHeadersVisible = false;
            this.dgvBookList.RowHeadersWidth = 51;
            this.dgvBookList.RowTemplate.Height = 27;
            this.dgvBookList.Size = new System.Drawing.Size(770, 270);
            this.dgvBookList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 83);
            this.panel1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(684, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(381, 30);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(288, 25);
            this.tbSearch.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBookCopy);
            this.groupBox1.Controls.Add(this.rbBookWr);
            this.groupBox1.Controls.Add(this.rbBookName);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색구분";
            // 
            // rbBookCopy
            // 
            this.rbBookCopy.AutoSize = true;
            this.rbBookCopy.Location = new System.Drawing.Point(253, 24);
            this.rbBookCopy.Name = "rbBookCopy";
            this.rbBookCopy.Size = new System.Drawing.Size(103, 19);
            this.rbBookCopy.TabIndex = 2;
            this.rbBookCopy.TabStop = true;
            this.rbBookCopy.Text = "출판사검색";
            this.rbBookCopy.UseVisualStyleBackColor = true;
            // 
            // rbBookWr
            // 
            this.rbBookWr.AutoSize = true;
            this.rbBookWr.Location = new System.Drawing.Point(133, 24);
            this.rbBookWr.Name = "rbBookWr";
            this.rbBookWr.Size = new System.Drawing.Size(88, 19);
            this.rbBookWr.TabIndex = 1;
            this.rbBookWr.TabStop = true;
            this.rbBookWr.Text = "저자검색";
            this.rbBookWr.UseVisualStyleBackColor = true;
            // 
            // rbBookName
            // 
            this.rbBookName.AutoSize = true;
            this.rbBookName.Location = new System.Drawing.Point(6, 24);
            this.rbBookName.Name = "rbBookName";
            this.rbBookName.Size = new System.Drawing.Size(88, 19);
            this.rbBookName.TabIndex = 0;
            this.rbBookName.TabStop = true;
            this.rbBookName.Text = "도서검색";
            this.rbBookName.UseVisualStyleBackColor = true;
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RentForm";
            this.Text = "RentForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReturn;
        public System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBookCopy;
        private System.Windows.Forms.RadioButton rbBookWr;
        private System.Windows.Forms.RadioButton rbBookName;
        private System.Windows.Forms.Label label1;
    }
}