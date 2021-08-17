using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace ilantalpro
{
    public partial class BookForm : Form
    {
        int k = 0,n;
        OleDbDataReader dr;
        OleDbConnection conn;
        Book[] books = new Book[50];
        public OleDbDataReader connec(string str)
        {
            string strDb = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ilanpro.accdb;" + "Persist Security Info=False";
            conn = new OleDbConnection(strDb);
            conn.Open();
            OleDbDataReader dr;
            OleDbCommand cmd = new OleDbCommand(str, conn); //command sq;
            dr = cmd.ExecuteReader(); // pointer to table
            return dr;
        }
        public bool checkBookID(string Bookid)
        {
            int i = 0;
            if(Bookid.Length!=7)
            {
                return false;
            }
            for (i = 0; i < Bookid.Length; i++)
            {
                if (Bookid[i] < '0' || Bookid[i]>'9')
                {
                    return false;
                }
            }
                return true;

        }
        public bool CheckBookName(string BookName)
        {
            if (BookName.Length < 3 || BookName.Length>25)
            {
                return false;
            }
            return true;
        }
        public bool checkBookStock(string BookStock)
        {
            int i = 0;
            if (BookStock.Length ==0)
            {
                return false;
            }
            for (i = 0; i < BookStock.Length; i++)
            {
                if (BookStock[i] < '0' || BookStock[i] > '9')
                {
                    return false;
                }
            }
            return true;

        }
        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            LIBookPic.BackColor = Color.Transparent;
            LIBookStock.BackColor = Color.Transparent;
            LIBookQty.BackColor = Color.Transparent;
            LBook.BackColor = Color.Transparent;
            LBookID.BackColor = Color.Transparent;
            LBookName.BackColor = Color.Transparent;
            LBookAuthor.BackColor = Color.Transparent;
            LBookPic.BackColor = Color.Transparent;
            LBookQty.BackColor = Color.Transparent;
            LBookStock.BackColor = Color.Transparent;
            LInsertID.BackColor = Color.Transparent;
            LInsertBookName.BackColor = Color.Transparent;
            LIBookAuthor.BackColor = Color.Transparent;
            LError.BackColor = Color.Transparent;
            LIBookPicIn.BackColor = Color.Transparent;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnShowBooks_Click(object sender, EventArgs e)
        {
            try
            {

                k = 0;

                OleDbDataReader dr = connec("Select * from Bookdb");
                string str1 = "Book ID:\n", str2 = "Book Name:\n", str3 = "Book Author:\n", str4 = "Pic:\n", str5 = "Stock\n", str6 = "Qty\n";
                while (dr.Read())
                {
                    str1 += dr["BookID"] + "\n";
                    str2 += dr["BookName"] + "\n";
                    str3 += dr["BookAuthor"] + "\n";
                    str4 += dr["BookPic"] + "\n";
                    str5 += dr["Stock"] + "\n";
                    str6 += dr["Qty"] + "\n";
                    books[k] = new Book(dr["BookID"].ToString(), dr["BookName"].ToString(), dr["BookAuthor"].ToString(), int.Parse(dr["Stock"].ToString()),int.Parse(dr["Qty"].ToString()), dr["BookPic"].ToString());
                    k++;
                }
                n = 0;
                dr.Close();
                conn.Close();
                LBookID.Text = str1;
                LBookName.Text = str2;
                LBookAuthor.Text = str3;
                LBookPic.Text = str4;
                LBookStock.Text = str5;
                LBookQty.Text = str6;
                LError.Text = books[n].PrintBook();
                LError.Text = books[n].PrintBook();
                PBBookPic.Image = Image.FromFile(@"img\" + books[n].GetBookPic());
                TBBookID.Text = books[n].GetBookID();
                TBBookAut.Text = books[n].GetBookAuthor();
                TBBookName.Text = books[n].GetkName();
                TBBookStock.Text = books[n].GetBookStock().ToString();
                TBBookQty.Text = books[n].GetBookqty().ToString();
                LIBookPicIn.Text = books[n].GetBookPic();
            }
            catch
            {
                MessageBox.Show("Book DB is Empty!!", "ERROR");
            }
        }

        private void BtnFindBook_Click(object sender, EventArgs e)
        {
            try
            {
                dr = connec("Select * from Bookdb where BookID='" + TBBookID.Text + "';");
                string str1 = "", str2 = "", str3 = "", str4 = "", str5 = "", str6 = "";
                while (dr.Read())
                {
                    str1 += dr["BookID"];
                    str2 += dr["BookName"];
                    str3 += dr["BookAuthor"];
                    str4 += dr["BookPic"];
                    str5 += dr["Stock"];
                    str6 += dr["Qty"];
                }
                dr.Close();
                conn.Close();
                TBBookID.Text = str1;
                TBBookName.Text = str2;
                TBBookAut.Text = str3;
                LIBookPicIn.Text = str4;
                TBBookStock.Text = str5;
                TBBookQty.Text = str6;
                PBBookPic.Image = Image.FromFile(@"img\" + str4);

            }
            catch
            {
                MessageBox.Show("Cheack Book ID!", "ERROR");
            }
        }

        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!checkBookID(TBBookID.Text))
            {
                LError.Text = "Book ID must have 7 digits";
            }

            else
            {
                if (!CheckBookName(TBBookName.Text))
                {
                    LError.Text = "Book Name must be more then 2 characters";
                }
                else
                {
                    if (!CheckBookName(TBBookAut.Text))
                    {
                        LError.Text = "Book Author must be more then 2 characters";
                    }
                    else
                    {
                        if (!checkBookStock(TBBookStock.Text))
                        {
                            LError.Text = "Book Stock most be bigger then 0";
                        }
                        else
                        {
                            if (LIBookPicIn.Text.Length < 2)
                            {
                                LError.Text = "Choose Pic!";
                            }
                            else
                            {
                                int a = int.Parse(TBBookStock.Text), b = int.Parse(TBBookQty.Text);
                                if (!checkBookStock(TBBookQty.Text) && a < b)
                                {
                                    LError.Text = "Book Qty most be bigger then 0 and less then Stock";
                                }
                                else
                                {
                                    try
                                    {
                                        dr = connec("update BookDB Set BookName='" + TBBookName.Text + "' , BookAuthor='" + TBBookAut.Text + "' , BookPic='" + LIBookPicIn.Text + "' where BookID='" + TBBookID.Text + "'");
                                        dr.Close();
                                        conn.Close();
                                        MessageBox.Show("Book Updated");
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.ToString(), "ERROR");
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void BtnPBook_Click(object sender, EventArgs e)
        {
            try
            {
                n++;
                if (n == k)
                {
                    n = 0;
                }
                LError.Text = books[n].PrintBook();
                PBBookPic.Image = Image.FromFile(@"img\" + books[n].GetBookPic());
                TBBookID.Text = books[n].GetBookID();
                TBBookAut.Text = books[n].GetBookAuthor();
                TBBookName.Text = books[n].GetkName();
                TBBookStock.Text = books[n].GetBookStock().ToString();
                TBBookQty.Text = books[n].GetBookqty().ToString();
                LIBookPicIn.Text = books[n].GetBookPic();
            }
            catch
            {
                MessageBox.Show("WORNG!! Press Show Book First", "ERROR");
            }
        }

        private void BtnmBook_Click(object sender, EventArgs e)
        {
            try
            {
                n--;
                if (n == -1)
                {
                    n = k - 1;
                }
                LError.Text = books[n].PrintBook();
                PBBookPic.Image = Image.FromFile(@"img\" + books[n].GetBookPic());
                TBBookID.Text = books[n].GetBookID();
                TBBookAut.Text = books[n].GetBookAuthor();
                TBBookName.Text = books[n].GetkName();
                TBBookStock.Text = books[n].GetBookStock().ToString();
                TBBookQty.Text = books[n].GetBookqty().ToString();
                LIBookPicIn.Text = books[n].GetBookPic();
            }
            catch
            {
                MessageBox.Show("WORNG!! Press Show Book First", "ERROR");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LIBookPicIn.Text = openFileDialog1.SafeFileName;
                PBBookPic.Image = Image.FromFile(@"img\" + LIBookPicIn.Text);

            }
        }


        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            string pic = LIBookPicIn.Text;
            if (!checkBookID(TBBookID.Text))
            {
                LError.Text = "Book ID must have 7 digits";
            }
            else
            {
                if (!CheckBookName(TBBookName.Text))
                {
                    LError.Text = "Book Name must be more then 2 characters";
                }
                else
                {
                    if (!CheckBookName(TBBookAut.Text))
                    {
                        LError.Text = "Book Author must be more then 2 characters";
                    }
                    else
                    {
                        if (LIBookPicIn.Text.Length < 2)
                        {
                            LError.Text = "Choose Pic!";
                        }
                        else
                        {
                            if (!checkBookStock(TBBookStock.Text))
                            {
                                LError.Text = "Book Stock most be bigger then 0";
                            }
                            else
                            {
                                int a = int.Parse(TBBookStock.Text), b = int.Parse(TBBookQty.Text);
                                if (!checkBookStock(TBBookQty.Text) && a < b)
                                {
                                    LError.Text = "Book Qty most be bigger then 0 and less then Stock";
                                }
                                else
                                {
                                    try
                                    {
                                        dr = connec("insert into Bookdb VALUES ('" + TBBookID.Text + "','" + TBBookName.Text + "','" + TBBookAut.Text + "','" + LIBookPicIn.Text + "','" + TBBookStock.Text + "','" + TBBookQty.Text + "')");
                                        dr.Close();
                                        conn.Close();
                                        MessageBox.Show("Book "+TBBookName.Text+" Added");
                                    }
                                    catch
                                    {
                                        MessageBox.Show("WORNG!! ID EXSIST!", "ERROR");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        
        }
    }
}
