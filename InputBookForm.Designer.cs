namespace BookManage
{
    partial class InputBookForm
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
            this.btnBookInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbCopyName = new System.Windows.Forms.TextBox();
            this.tbWriteName = new System.Windows.Forms.TextBox();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBookInsert);
            this.panel2.Location = new System.Drawing.Point(12, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 117);
            this.panel2.TabIndex = 8;
            // 
            // btnBookInsert
            // 
            this.btnBookInsert.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBookInsert.Location = new System.Drawing.Point(56, 27);
            this.btnBookInsert.Name = "btnBookInsert";
            this.btnBookInsert.Size = new System.Drawing.Size(290, 67);
            this.btnBookInsert.TabIndex = 0;
            this.btnBookInsert.Text = "도 서 등 록";
            this.btnBookInsert.UseVisualStyleBackColor = true;
            this.btnBookInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbQuantity);
            this.panel1.Controls.Add(this.tbCopyName);
            this.panel1.Controls.Add(this.tbWriteName);
            this.panel1.Controls.Add(this.tbBookName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 415);
            this.panel1.TabIndex = 7;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(130, 304);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(216, 25);
            this.tbQuantity.TabIndex = 9;
            // 
            // tbCopyName
            // 
            this.tbCopyName.Location = new System.Drawing.Point(130, 229);
            this.tbCopyName.Name = "tbCopyName";
            this.tbCopyName.Size = new System.Drawing.Size(216, 25);
            this.tbCopyName.TabIndex = 7;
            // 
            // tbWriteName
            // 
            this.tbWriteName.Location = new System.Drawing.Point(130, 154);
            this.tbWriteName.Name = "tbWriteName";
            this.tbWriteName.Size = new System.Drawing.Size(216, 25);
            this.tbWriteName.TabIndex = 6;
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(130, 79);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(216, 25);
            this.tbBookName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(52, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "수     량";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(52, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "출 판 사";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(52, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "저 자 명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(52, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "도 서 명";
            // 
            // InputBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InputBookForm";
            this.Text = "InputBookForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBookInsert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbQuantity;
        public System.Windows.Forms.TextBox tbCopyName;
        public System.Windows.Forms.TextBox tbWriteName;
        public System.Windows.Forms.TextBox tbBookName;
    }
}