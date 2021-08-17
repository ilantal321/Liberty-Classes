namespace ilantalpro
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.LBook = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnShowBooks = new System.Windows.Forms.Button();
            this.LBookID = new System.Windows.Forms.Label();
            this.LBookName = new System.Windows.Forms.Label();
            this.LBookAuthor = new System.Windows.Forms.Label();
            this.LBookPic = new System.Windows.Forms.Label();
            this.LBookQty = new System.Windows.Forms.Label();
            this.LBookStock = new System.Windows.Forms.Label();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.LInsertID = new System.Windows.Forms.Label();
            this.TBBookID = new System.Windows.Forms.TextBox();
            this.TBBookName = new System.Windows.Forms.TextBox();
            this.LInsertBookName = new System.Windows.Forms.Label();
            this.TBBookAut = new System.Windows.Forms.TextBox();
            this.LIBookAuthor = new System.Windows.Forms.Label();
            this.LIBookPic = new System.Windows.Forms.Label();
            this.TBBookQty = new System.Windows.Forms.TextBox();
            this.LIBookQty = new System.Windows.Forms.Label();
            this.TBBookStock = new System.Windows.Forms.TextBox();
            this.LIBookStock = new System.Windows.Forms.Label();
            this.LError = new System.Windows.Forms.Label();
            this.BtnFindBook = new System.Windows.Forms.Button();
            this.BtnUpdateBook = new System.Windows.Forms.Button();
            this.BtnPBook = new System.Windows.Forms.Button();
            this.BtnmBook = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnAddBookPic = new System.Windows.Forms.Button();
            this.PBBookPic = new System.Windows.Forms.PictureBox();
            this.LIBookPicIn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBBookPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LBook
            // 
            this.LBook.AutoSize = true;
            this.LBook.BackColor = System.Drawing.SystemColors.Menu;
            this.LBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBook.Location = new System.Drawing.Point(12, 9);
            this.LBook.Name = "LBook";
            this.LBook.Size = new System.Drawing.Size(158, 55);
            this.LBook.TabIndex = 5;
            this.LBook.Text = "Books";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(12, 476);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(65, 65);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.Text = "<<";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnShowBooks
            // 
            this.BtnShowBooks.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnShowBooks.Location = new System.Drawing.Point(234, 476);
            this.BtnShowBooks.Name = "BtnShowBooks";
            this.BtnShowBooks.Size = new System.Drawing.Size(156, 65);
            this.BtnShowBooks.TabIndex = 9;
            this.BtnShowBooks.Text = "Show Books";
            this.BtnShowBooks.UseVisualStyleBackColor = false;
            this.BtnShowBooks.Click += new System.EventHandler(this.BtnShowBooks_Click);
            // 
            // LBookID
            // 
            this.LBookID.AutoSize = true;
            this.LBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBookID.Location = new System.Drawing.Point(280, 9);
            this.LBookID.Name = "LBookID";
            this.LBookID.Size = new System.Drawing.Size(0, 20);
            this.LBookID.TabIndex = 10;
            // 
            // LBookName
            // 
            this.LBookName.AutoSize = true;
            this.LBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBookName.Location = new System.Drawing.Point(367, 9);
            this.LBookName.Name = "LBookName";
            this.LBookName.Size = new System.Drawing.Size(0, 20);
            this.LBookName.TabIndex = 11;
            // 
            // LBookAuthor
            // 
            this.LBookAuthor.AutoSize = true;
            this.LBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBookAuthor.Location = new System.Drawing.Point(613, 9);
            this.LBookAuthor.Name = "LBookAuthor";
            this.LBookAuthor.Size = new System.Drawing.Size(0, 20);
            this.LBookAuthor.TabIndex = 12;
            // 
            // LBookPic
            // 
            this.LBookPic.AutoSize = true;
            this.LBookPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBookPic.Location = new System.Drawing.Point(870, 9);
            this.LBookPic.Name = "LBookPic";
            this.LBookPic.Size = new System.Drawing.Size(0, 20);
            this.LBookPic.TabIndex = 13;
            // 
            // LBookQty
            // 
            this.LBookQty.AutoSize = true;
            this.LBookQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBookQty.Location = new System.Drawing.Point(1098, 9);
            this.LBookQty.Name = "LBookQty";
            this.LBookQty.Size = new System.Drawing.Size(0, 20);
            this.LBookQty.TabIndex = 14;
            // 
            // LBookStock
            // 
            this.LBookStock.AutoSize = true;
            this.LBookStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBookStock.Location = new System.Drawing.Point(1011, 9);
            this.LBookStock.Name = "LBookStock";
            this.LBookStock.Size = new System.Drawing.Size(0, 20);
            this.LBookStock.TabIndex = 15;
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddBook.Location = new System.Drawing.Point(445, 476);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(156, 65);
            this.BtnAddBook.TabIndex = 16;
            this.BtnAddBook.Text = "Add Book";
            this.BtnAddBook.UseVisualStyleBackColor = false;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // LInsertID
            // 
            this.LInsertID.AutoSize = true;
            this.LInsertID.Location = new System.Drawing.Point(7, 125);
            this.LInsertID.Name = "LInsertID";
            this.LInsertID.Size = new System.Drawing.Size(57, 17);
            this.LInsertID.TabIndex = 17;
            this.LInsertID.Text = "Book ID";
            // 
            // TBBookID
            // 
            this.TBBookID.Location = new System.Drawing.Point(94, 120);
            this.TBBookID.MaxLength = 7;
            this.TBBookID.Name = "TBBookID";
            this.TBBookID.Size = new System.Drawing.Size(186, 22);
            this.TBBookID.TabIndex = 18;
            // 
            // TBBookName
            // 
            this.TBBookName.Location = new System.Drawing.Point(94, 149);
            this.TBBookName.MaxLength = 25;
            this.TBBookName.Name = "TBBookName";
            this.TBBookName.Size = new System.Drawing.Size(186, 22);
            this.TBBookName.TabIndex = 20;
            // 
            // LInsertBookName
            // 
            this.LInsertBookName.AutoSize = true;
            this.LInsertBookName.Location = new System.Drawing.Point(7, 152);
            this.LInsertBookName.Name = "LInsertBookName";
            this.LInsertBookName.Size = new System.Drawing.Size(81, 17);
            this.LInsertBookName.TabIndex = 19;
            this.LInsertBookName.Text = "Book Name";
            // 
            // TBBookAut
            // 
            this.TBBookAut.Location = new System.Drawing.Point(94, 180);
            this.TBBookAut.MaxLength = 25;
            this.TBBookAut.Name = "TBBookAut";
            this.TBBookAut.Size = new System.Drawing.Size(186, 22);
            this.TBBookAut.TabIndex = 22;
            // 
            // LIBookAuthor
            // 
            this.LIBookAuthor.AutoSize = true;
            this.LIBookAuthor.Location = new System.Drawing.Point(7, 183);
            this.LIBookAuthor.Name = "LIBookAuthor";
            this.LIBookAuthor.Size = new System.Drawing.Size(86, 17);
            this.LIBookAuthor.TabIndex = 21;
            this.LIBookAuthor.Text = "Book Author";
            // 
            // LIBookPic
            // 
            this.LIBookPic.AutoSize = true;
            this.LIBookPic.Location = new System.Drawing.Point(7, 211);
            this.LIBookPic.Name = "LIBookPic";
            this.LIBookPic.Size = new System.Drawing.Size(63, 17);
            this.LIBookPic.TabIndex = 23;
            this.LIBookPic.Text = "Book Pic";
            // 
            // TBBookQty
            // 
            this.TBBookQty.Location = new System.Drawing.Point(94, 264);
            this.TBBookQty.Name = "TBBookQty";
            this.TBBookQty.Size = new System.Drawing.Size(186, 22);
            this.TBBookQty.TabIndex = 28;
            // 
            // LIBookQty
            // 
            this.LIBookQty.AutoSize = true;
            this.LIBookQty.Location = new System.Drawing.Point(7, 267);
            this.LIBookQty.Name = "LIBookQty";
            this.LIBookQty.Size = new System.Drawing.Size(66, 17);
            this.LIBookQty.TabIndex = 27;
            this.LIBookQty.Text = "Book Qty";
            // 
            // TBBookStock
            // 
            this.TBBookStock.Location = new System.Drawing.Point(94, 236);
            this.TBBookStock.Name = "TBBookStock";
            this.TBBookStock.Size = new System.Drawing.Size(186, 22);
            this.TBBookStock.TabIndex = 26;
            // 
            // LIBookStock
            // 
            this.LIBookStock.AutoSize = true;
            this.LIBookStock.Location = new System.Drawing.Point(7, 239);
            this.LIBookStock.Name = "LIBookStock";
            this.LIBookStock.Size = new System.Drawing.Size(54, 17);
            this.LIBookStock.TabIndex = 25;
            this.LIBookStock.Text = "LIStock";
            // 
            // LError
            // 
            this.LError.AutoSize = true;
            this.LError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LError.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LError.Location = new System.Drawing.Point(30, 316);
            this.LError.Name = "LError";
            this.LError.Size = new System.Drawing.Size(0, 20);
            this.LError.TabIndex = 29;
            // 
            // BtnFindBook
            // 
            this.BtnFindBook.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnFindBook.Location = new System.Drawing.Point(651, 476);
            this.BtnFindBook.Name = "BtnFindBook";
            this.BtnFindBook.Size = new System.Drawing.Size(156, 65);
            this.BtnFindBook.TabIndex = 30;
            this.BtnFindBook.Text = "Find Book";
            this.BtnFindBook.UseVisualStyleBackColor = false;
            this.BtnFindBook.Click += new System.EventHandler(this.BtnFindBook_Click);
            // 
            // BtnUpdateBook
            // 
            this.BtnUpdateBook.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnUpdateBook.Location = new System.Drawing.Point(843, 476);
            this.BtnUpdateBook.Name = "BtnUpdateBook";
            this.BtnUpdateBook.Size = new System.Drawing.Size(156, 65);
            this.BtnUpdateBook.TabIndex = 31;
            this.BtnUpdateBook.Text = "Update Book";
            this.BtnUpdateBook.UseVisualStyleBackColor = false;
            this.BtnUpdateBook.Click += new System.EventHandler(this.BtnUpdateBook_Click);
            // 
            // BtnPBook
            // 
            this.BtnPBook.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnPBook.Location = new System.Drawing.Point(94, 376);
            this.BtnPBook.Name = "BtnPBook";
            this.BtnPBook.Size = new System.Drawing.Size(41, 44);
            this.BtnPBook.TabIndex = 32;
            this.BtnPBook.Text = "+";
            this.BtnPBook.UseVisualStyleBackColor = false;
            this.BtnPBook.Click += new System.EventHandler(this.BtnPBook_Click);
            // 
            // BtnmBook
            // 
            this.BtnmBook.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnmBook.Location = new System.Drawing.Point(35, 376);
            this.BtnmBook.Name = "BtnmBook";
            this.BtnmBook.Size = new System.Drawing.Size(41, 44);
            this.BtnmBook.TabIndex = 33;
            this.BtnmBook.Text = "-";
            this.BtnmBook.UseVisualStyleBackColor = false;
            this.BtnmBook.Click += new System.EventHandler(this.BtnmBook_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnAddBookPic
            // 
            this.BtnAddBookPic.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddBookPic.Location = new System.Drawing.Point(163, 376);
            this.BtnAddBookPic.Name = "BtnAddBookPic";
            this.BtnAddBookPic.Size = new System.Drawing.Size(83, 44);
            this.BtnAddBookPic.TabIndex = 34;
            this.BtnAddBookPic.Text = "Add Pic";
            this.BtnAddBookPic.UseVisualStyleBackColor = false;
            this.BtnAddBookPic.Click += new System.EventHandler(this.button1_Click);
            // 
            // PBBookPic
            // 
            this.PBBookPic.Location = new System.Drawing.Point(1015, 376);
            this.PBBookPic.Name = "PBBookPic";
            this.PBBookPic.Size = new System.Drawing.Size(134, 155);
            this.PBBookPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBBookPic.TabIndex = 35;
            this.PBBookPic.TabStop = false;
            // 
            // LIBookPicIn
            // 
            this.LIBookPicIn.AutoSize = true;
            this.LIBookPicIn.Location = new System.Drawing.Point(93, 211);
            this.LIBookPicIn.Name = "LIBookPicIn";
            this.LIBookPicIn.Size = new System.Drawing.Size(0, 17);
            this.LIBookPicIn.TabIndex = 36;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.LIBookPicIn);
            this.Controls.Add(this.PBBookPic);
            this.Controls.Add(this.BtnAddBookPic);
            this.Controls.Add(this.BtnmBook);
            this.Controls.Add(this.BtnPBook);
            this.Controls.Add(this.BtnUpdateBook);
            this.Controls.Add(this.BtnFindBook);
            this.Controls.Add(this.LError);
            this.Controls.Add(this.TBBookQty);
            this.Controls.Add(this.LIBookQty);
            this.Controls.Add(this.TBBookStock);
            this.Controls.Add(this.LIBookStock);
            this.Controls.Add(this.LIBookPic);
            this.Controls.Add(this.TBBookAut);
            this.Controls.Add(this.LIBookAuthor);
            this.Controls.Add(this.TBBookName);
            this.Controls.Add(this.LInsertBookName);
            this.Controls.Add(this.TBBookID);
            this.Controls.Add(this.LInsertID);
            this.Controls.Add(this.BtnAddBook);
            this.Controls.Add(this.LBookStock);
            this.Controls.Add(this.LBookQty);
            this.Controls.Add(this.LBookPic);
            this.Controls.Add(this.LBookAuthor);
            this.Controls.Add(this.LBookName);
            this.Controls.Add(this.LBookID);
            this.Controls.Add(this.BtnShowBooks);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LBook);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookForm";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBBookPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBook;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnShowBooks;
        private System.Windows.Forms.Label LBookID;
        private System.Windows.Forms.Label LBookName;
        private System.Windows.Forms.Label LBookAuthor;
        private System.Windows.Forms.Label LBookPic;
        private System.Windows.Forms.Label LBookQty;
        private System.Windows.Forms.Label LBookStock;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.Label LInsertID;
        private System.Windows.Forms.TextBox TBBookID;
        private System.Windows.Forms.TextBox TBBookName;
        private System.Windows.Forms.Label LInsertBookName;
        private System.Windows.Forms.TextBox TBBookAut;
        private System.Windows.Forms.Label LIBookAuthor;
        private System.Windows.Forms.Label LIBookPic;
        private System.Windows.Forms.TextBox TBBookQty;
        private System.Windows.Forms.Label LIBookQty;
        private System.Windows.Forms.TextBox TBBookStock;
        private System.Windows.Forms.Label LIBookStock;
        private System.Windows.Forms.Label LError;
        private System.Windows.Forms.Button BtnFindBook;
        private System.Windows.Forms.Button BtnUpdateBook;
        private System.Windows.Forms.Button BtnPBook;
        private System.Windows.Forms.Button BtnmBook;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnAddBookPic;
        private System.Windows.Forms.PictureBox PBBookPic;
        private System.Windows.Forms.Label LIBookPicIn;
    }
}