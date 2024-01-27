namespace thelibrary
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.isbnTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TitleTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AuthorTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CopyNumberCountBox = new System.Windows.Forms.NumericUpDown();
            this.ShowAllBooksButton = new System.Windows.Forms.Button();
            this.SearchBookButton = new System.Windows.Forms.Button();
            this.SearchBarTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BorrowBookButton = new System.Windows.Forms.Button();
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.ShowBorrowedBooksButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ReturnBookTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BorrowReturnTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBook = new System.Windows.Forms.Label();
            this.CopyNumber = new System.Windows.Forms.Label();
            this.ISBNnumber = new System.Windows.Forms.Label();
            this.BookAuthor = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CopyNumberCountBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(868, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Library System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(618, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 478);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 478);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // AddBookButton
            // 
            this.AddBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBookButton.Location = new System.Drawing.Point(274, 63);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(258, 36);
            this.AddBookButton.TabIndex = 2;
            this.AddBookButton.Text = "Add Books";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.isbnTextBox.Location = new System.Drawing.Point(2, 408);
            this.isbnTextBox.Mask = "0000000000000";
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.PromptChar = '-';
            this.isbnTextBox.Size = new System.Drawing.Size(189, 22);
            this.isbnTextBox.TabIndex = 3;
            this.isbnTextBox.ValidatingType = typeof(int);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(1, 316);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(189, 22);
            this.TitleTextBox.TabIndex = 4;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorTextBox.Location = new System.Drawing.Point(2, 358);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(189, 22);
            this.AuthorTextBox.TabIndex = 5;
            // 
            // CopyNumberCountBox
            // 
            this.CopyNumberCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyNumberCountBox.Location = new System.Drawing.Point(2, 453);
            this.CopyNumberCountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CopyNumberCountBox.Name = "CopyNumberCountBox";
            this.CopyNumberCountBox.Size = new System.Drawing.Size(189, 22);
            this.CopyNumberCountBox.TabIndex = 6;
            this.CopyNumberCountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ShowAllBooksButton
            // 
            this.ShowAllBooksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAllBooksButton.Location = new System.Drawing.Point(274, 109);
            this.ShowAllBooksButton.Name = "ShowAllBooksButton";
            this.ShowAllBooksButton.Size = new System.Drawing.Size(258, 36);
            this.ShowAllBooksButton.TabIndex = 7;
            this.ShowAllBooksButton.Text = "Show All Books";
            this.ShowAllBooksButton.UseVisualStyleBackColor = true;
            this.ShowAllBooksButton.Click += new System.EventHandler(this.ShowAllBooksButton_Click);
            // 
            // SearchBookButton
            // 
            this.SearchBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBookButton.Location = new System.Drawing.Point(274, 163);
            this.SearchBookButton.Name = "SearchBookButton";
            this.SearchBookButton.Size = new System.Drawing.Size(258, 36);
            this.SearchBookButton.TabIndex = 8;
            this.SearchBookButton.Text = "Search Book";
            this.SearchBookButton.UseVisualStyleBackColor = true;
            this.SearchBookButton.Click += new System.EventHandler(this.SearchBookButton_Click);
            // 
            // SearchBarTextBox
            // 
            this.SearchBarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBarTextBox.Location = new System.Drawing.Point(0, 77);
            this.SearchBarTextBox.Name = "SearchBarTextBox";
            this.SearchBarTextBox.Size = new System.Drawing.Size(190, 22);
            this.SearchBarTextBox.TabIndex = 9;
            // 
            // BorrowBookButton
            // 
            this.BorrowBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrowBookButton.Location = new System.Drawing.Point(274, 215);
            this.BorrowBookButton.Name = "BorrowBookButton";
            this.BorrowBookButton.Size = new System.Drawing.Size(258, 36);
            this.BorrowBookButton.TabIndex = 10;
            this.BorrowBookButton.Text = "Borrow Book";
            this.BorrowBookButton.UseVisualStyleBackColor = true;
            this.BorrowBookButton.Click += new System.EventHandler(this.BorrowBookButton_Click);
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnBookButton.Location = new System.Drawing.Point(274, 265);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(258, 36);
            this.ReturnBookButton.TabIndex = 11;
            this.ReturnBookButton.Text = "Return Book";
            this.ReturnBookButton.UseVisualStyleBackColor = true;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBookButton_Click);
            // 
            // ShowBorrowedBooksButton
            // 
            this.ShowBorrowedBooksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowBorrowedBooksButton.Location = new System.Drawing.Point(274, 316);
            this.ShowBorrowedBooksButton.Name = "ShowBorrowedBooksButton";
            this.ShowBorrowedBooksButton.Size = new System.Drawing.Size(258, 49);
            this.ShowBorrowedBooksButton.TabIndex = 12;
            this.ShowBorrowedBooksButton.Text = "Show Borrowed Books";
            this.ShowBorrowedBooksButton.UseVisualStyleBackColor = true;
            this.ShowBorrowedBooksButton.Click += new System.EventHandler(this.ShowBorrowedBooksButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ExitButton);
            this.panel3.Controls.Add(this.ShowBorrowedBooksButton);
            this.panel3.Controls.Add(this.AddBookButton);
            this.panel3.Controls.Add(this.ReturnBookButton);
            this.panel3.Controls.Add(this.ShowAllBooksButton);
            this.panel3.Controls.Add(this.BorrowBookButton);
            this.panel3.Controls.Add(this.SearchBookButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 478);
            this.panel3.TabIndex = 13;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(274, 371);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(258, 59);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.ReturnBookTextBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.BorrowReturnTextBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.SearchBook);
            this.panel4.Controls.Add(this.CopyNumber);
            this.panel4.Controls.Add(this.ISBNnumber);
            this.panel4.Controls.Add(this.BookAuthor);
            this.panel4.Controls.Add(this.BookName);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.TitleTextBox);
            this.panel4.Controls.Add(this.isbnTextBox);
            this.panel4.Controls.Add(this.SearchBarTextBox);
            this.panel4.Controls.Add(this.AuthorTextBox);
            this.panel4.Controls.Add(this.CopyNumberCountBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 478);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // ReturnBookTextBox
            // 
            this.ReturnBookTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnBookTextBox.Location = new System.Drawing.Point(0, 229);
            this.ReturnBookTextBox.Name = "ReturnBookTextBox";
            this.ReturnBookTextBox.PromptChar = '-';
            this.ReturnBookTextBox.Size = new System.Drawing.Size(189, 22);
            this.ReturnBookTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(-1, 121);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(189, 50);
            this.label5.TabIndex = 19;
            this.label5.Text = "Borrow/Return Book";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "ISBN for Borrowing:";
            // 
            // BorrowReturnTextBox
            // 
            this.BorrowReturnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BorrowReturnTextBox.Location = new System.Drawing.Point(1, 190);
            this.BorrowReturnTextBox.Mask = "0000000000000";
            this.BorrowReturnTextBox.Name = "BorrowReturnTextBox";
            this.BorrowReturnTextBox.PromptChar = '-';
            this.BorrowReturnTextBox.Size = new System.Drawing.Size(189, 22);
            this.BorrowReturnTextBox.TabIndex = 17;
            this.BorrowReturnTextBox.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(-3, 265);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(189, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Add Book";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBook
            // 
            this.SearchBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBook.Location = new System.Drawing.Point(3, 42);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(131, 32);
            this.SearchBook.TabIndex = 15;
            this.SearchBook.Text = "Search Book By Name or Aurthor:";
            // 
            // CopyNumber
            // 
            this.CopyNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyNumber.AutoSize = true;
            this.CopyNumber.Location = new System.Drawing.Point(4, 439);
            this.CopyNumber.Name = "CopyNumber";
            this.CopyNumber.Size = new System.Drawing.Size(93, 16);
            this.CopyNumber.TabIndex = 14;
            this.CopyNumber.Text = "Copy Number:";
            // 
            // ISBNnumber
            // 
            this.ISBNnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ISBNnumber.AutoSize = true;
            this.ISBNnumber.Location = new System.Drawing.Point(5, 389);
            this.ISBNnumber.Name = "ISBNnumber";
            this.ISBNnumber.Size = new System.Drawing.Size(41, 16);
            this.ISBNnumber.TabIndex = 13;
            this.ISBNnumber.Text = "ISBN:";
            // 
            // BookAuthor
            // 
            this.BookAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BookAuthor.AutoSize = true;
            this.BookAuthor.Location = new System.Drawing.Point(5, 345);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(83, 16);
            this.BookAuthor.TabIndex = 12;
            this.BookAuthor.Text = "Book Author:";
            // 
            // BookName
            // 
            this.BookName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BookName.AutoSize = true;
            this.BookName.Location = new System.Drawing.Point(5, 299);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(82, 16);
            this.BookName.TabIndex = 11;
            this.BookName.Text = "Book Name:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(189, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Book Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Borrow Id for returning:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 523);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CopyNumberCountBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.MaskedTextBox isbnTextBox;
        private System.Windows.Forms.MaskedTextBox TitleTextBox;
        private System.Windows.Forms.MaskedTextBox AuthorTextBox;
        private System.Windows.Forms.NumericUpDown CopyNumberCountBox;
        private System.Windows.Forms.Button ShowAllBooksButton;
        private System.Windows.Forms.Button SearchBookButton;
        private System.Windows.Forms.MaskedTextBox SearchBarTextBox;
        private System.Windows.Forms.Button BorrowBookButton;
        private System.Windows.Forms.Button ReturnBookButton;
        private System.Windows.Forms.Button ShowBorrowedBooksButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BookAuthor;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Label SearchBook;
        private System.Windows.Forms.Label CopyNumber;
        private System.Windows.Forms.Label ISBNnumber;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox BorrowReturnTextBox;
        private System.Windows.Forms.MaskedTextBox ReturnBookTextBox;
        private System.Windows.Forms.Label label6;
    }
}

