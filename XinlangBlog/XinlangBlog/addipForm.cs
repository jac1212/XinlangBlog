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
    public partial class addipForm : Form
    {
        public mainForm form = null;
        public addipForm()
        {
            InitializeComponent();
        }
        public void GetForm(mainForm theform)
        {
            form = theform;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            string txt1 = area.Text;
            string txt2 = ip.Text;
            string txt3 = port.Text;
            string txt4 = status.Text;
            int index = form.dataGridView2.Rows.Add();
            form.dataGridView2.Rows[index].Cells[1].Value = index + 1;
            form.dataGridView2.Rows[index].Cells[2].Value = txt1;
            form.dataGridView2.Rows[index].Cells[3].Value = txt2;
            form.dataGridView2.Rows[index].Cells[4].Value = txt3;
            form.dataGridView2.Rows[index].Cells[5].Value = txt4;
        }
    }
}
