using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XinlangBlog
{
    public partial class adduserForm : Form
    {
        public mainForm form = null;
        public adduserForm()
        {
            InitializeComponent();
        }
        public void GetForm(mainForm theform)
        {
            form = theform;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string txt1 = username.Text;
            string txt2 = password.Text;
            int index = form.dataGridView1.Rows.Add();
            form.dataGridView1.Rows[index].Cells[1].Value = index+1;
            form.dataGridView1.Rows[index].Cells[2].Value = txt1;
            form.dataGridView1.Rows[index].Cells[3].Value = txt2;
        }
    }
}
