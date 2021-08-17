using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilantalpro
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm sf = new StudentForm();
            sf.ShowDialog();
            this.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            LWelcome.BackColor = Color.Transparent;
        }

        private void BtnBookForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookForm bf = new BookForm();
            bf.ShowDialog();
            this.Show();
        }

        private void BtnOrderForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm of = new OrderForm();
            of.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
