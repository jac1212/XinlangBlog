using mshtml;
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
    public partial class publishForm : Form
    {
        DataTable dt1, dt2;
        string userName = "";
        string passWord = "";
        string ip = "";
        int port;
        public publishForm(DataTable d1,DataTable d2)
        {
            InitializeComponent();
            dt1 = d1;
            dt2 = d2;
        }

        private void publish_Click(object sender, EventArgs e)
        {

            int rowCount1 = dt1.Rows.Count;//行数
            int rowCount2 = dt2.Rows.Count;//列数

            //设置每行每列的单元格,  
            for (int i = 0; i < rowCount1; i++)
            {
                userName = dt1.Rows[i][0].ToString();
                passWord = dt1.Rows[i][1].ToString();
                if (rowCount2 == 0)
                {
                    MessageBox.Show("IP为空!");
                }
                else {

                    tipForm tipform = new tipForm(userName);
                    tipform.Show();
                    try
                    {
                        ip = dt2.Rows[i][0].ToString();
                        port = int.Parse(dt2.Rows[i][1].ToString());
                        if (Send.send(userName, passWord, ip, port, content.Text))
                        {
                            tipform.Close();
                        }
                        
                    }
                    catch
                    {
                        tipform.Close();
                        MessageBox.Show("发送失败!");
                    }
                } 

            }
            if (rowCount1 == 0)
            {
                MessageBox.Show("用户为空!");
            }
            else {
                MessageBox.Show("发送完成!");
            }
        }
    }
}
