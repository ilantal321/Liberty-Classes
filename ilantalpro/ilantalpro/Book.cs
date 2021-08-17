using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilantalpro
{
    class Book
    {
        private string BookID;
        private string BookName;
        private string BookAuthor;
        private string BookPic;
        private int BookStock;
        private int BookQty;


            public Book(string ID, string name, string author, int s, int q, string pic)
            {
                BookID = ID;
                BookName = name;
                BookAuthor = author;
                BookStock = s;
                BookQty = q;
                BookPic = pic;
            }
            public void SetPic(string pic)
            {
                BookPic = pic;
            }
            public void SetBookID(string ID)
            {
                BookID = ID;
            }
            public void SetBookName(string name)
            {
                BookName = name;
            }
            public void SetBookAuthor(string author)
            {
                BookAuthor = author;
            }
            public void SetBookStock(int s)
            {
                BookStock = s;
            }
            public void SetBookQty(int q)
            {
                BookQty = q;
            }
            public string GetBookID()
            {
                return BookID;
            }
            public string GetBookPic()
            {
                return BookPic;
            }
            public string GetkName()
            {
                return BookName;
            }
            public string GetBookAuthor()
            {
                return BookAuthor;
            }
            public int GetBookStock()
            {
                return BookStock;
            }
            public int GetBookqty()
            {
                return BookQty;
            }
            public string PrintBook()
            {
                string str = "";
                str = "Book ID is: " + BookID + " Name: " + BookName + " Author: " + BookAuthor + " stock: " + BookStock + " Quantity: " + BookQty + " Pic:" + BookPic;
                return str;
            }
        public string PrintBookData()
        {
            string str = "";
            str = " Name: " + BookName + " Author: " + BookAuthor + " stock: " + BookStock + " Quantity: " + BookQty;
            return str;
        }
    }
}
