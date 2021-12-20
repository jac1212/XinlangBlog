using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XinlangBlog
{
    public partial class mainForm : Form
    {
        string path1 = "";
        string path2 = "";
        public mainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 导入用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importuser_Click(object sender, EventArgs e)
        {
            importuserDialog.InitialDirectory = "C:\\";//初始加载路径为C盘;
            importuserDialog.Filter = "文本文件 (*.txt)|*.txt";//过滤你想设置的文本文件类型（这是xml型）
            // openFileDialog1.Filter = "文本文件 (*.txt)|*.txt|All files (*.*)|*.*";（这是全部类型文件）
            if (this.importuserDialog.ShowDialog() == DialogResult.OK)
            {
                path1 = importuserDialog.FileName;
                //读取txt文件
                JArray userlist=ReadTxt.Read(path1);
                //显示读取数据
                for (int i = 0; i < userlist.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    int n = 1;
                    foreach (string key in userlist[i])
                    {
                        if (n > 4)
                        {
                            break;
                        }
                        dataGridView1.Rows[i].Cells[n].Value = key;
                        n++;
                    }
                }
            }
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adduser_Click(object sender, EventArgs e)
        {
            adduserForm adduserform = new adduserForm();
            adduserform.GetForm(this);
            adduserform.Show();
        }
        /// <summary>
        /// 保存用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveuser_Click(object sender, EventArgs e)
        {
            //保存
            DataTable dt = DataGridViewToTable.GetDgvToTable(dataGridView1);
            dt.Columns.RemoveAt(0);
            dt.Columns.RemoveAt(0);
            WriteTxt.AddLgoToTXT(dt,"user.txt");
        }
        /// <summary>
        /// 导入IP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importip_Click(object sender, EventArgs e)
        {
            importipDialog.InitialDirectory = "C:\\";//初始加载路径为C盘;
            importipDialog.Filter = "文本文件 (*.txt)|*.txt";//过滤你想设置的文本文件类型（这是xml型）
            // openFileDialog1.Filter = "文本文件 (*.txt)|*.txt|All files (*.*)|*.*";（这是全部类型文件）
            if (this.importipDialog.ShowDialog() == DialogResult.OK)
            {
                path2 = importipDialog.FileName;
                //读取txt文件
                JArray iplist = ReadTxt.Read(path2);
                //显示读取数据
                for (int i = 0; i < iplist.Count; i++)
                {
                    dataGridView2.Rows.Add();
                    int n = 1;
                    foreach (string key in iplist[i])
                    {
                        if (n > 6)
                        {
                            break;
                        }
                        dataGridView2.Rows[i].Cells[n].Value = key;
                        n++;
                    }
                }
            }
        }
        /// <summary>
        /// 添加IP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addip_Click(object sender, EventArgs e)
        {
            addipForm addipform = new addipForm();
            addipform.GetForm(this);
            addipform.Show();
        }

        private void saveip_Click(object sender, EventArgs e)
        {
            //保存
            DataTable dt = DataGridViewToTable.GetDgvToTable(dataGridView2);
            dt.Columns.RemoveAt(0);
            dt.Columns.RemoveAt(0);
            WriteTxt.AddLgoToTXT(dt, "ip.txt");
        }
        /// <summary>
        /// 账号列表右击菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            string str = dataGridView1.SelectedCells.ToString();
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this.dataGridView1, e.Location);
            }
        }

        private void dataGridView2_MouseUp(object sender, MouseEventArgs e)
        {
            string str = dataGridView1.SelectedCells.ToString();
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show(this.dataGridView2, e.Location);
            }
        }

        private void right_refresh_Click(object sender, EventArgs e)
        {

        }

        private void right_importuser_Click(object sender, EventArgs e)
        {
            importuserDialog.InitialDirectory = "C:\\";//初始加载路径为C盘;
            importuserDialog.Filter = "文本文件 (*.txt)|*.txt";//过滤你想设置的文本文件类型（这是xml型）
            // openFileDialog1.Filter = "文本文件 (*.txt)|*.txt|All files (*.*)|*.*";（这是全部类型文件）
            if (this.importuserDialog.ShowDialog() == DialogResult.OK)
            {
                path1 = importuserDialog.FileName;
                //读取txt文件
                JArray userlist = ReadTxt.Read(path1);
                //显示读取数据
                for (int i = 0; i < userlist.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    int n = 1;
                    foreach (string key in userlist[i])
                    {
                        if (n > 4)
                        {
                            break;
                        }
                        dataGridView1.Rows[i].Cells[n].Value = key;
                        n++;
                    }
                }
            }
        }

        private void right_adduser_Click(object sender, EventArgs e)
        {
            adduserForm adduserform = new adduserForm();
            adduserform.GetForm(this);
            adduserform.Show();
        }

        private void right_saveuser_Click(object sender, EventArgs e)
        {
            //保存
            DataTable dt = DataGridViewToTable.GetDgvToTable(dataGridView1);
            dt.Columns.RemoveAt(0);
            dt.Columns.RemoveAt(0);
            WriteTxt.AddLgoToTXT(dt, "user.txt");
        }

        private void right_selall_Click(object sender, EventArgs e)
        {
            //循环dataGridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //设置每一行的选择框为选中
                dataGridView1.Rows[i].Cells[0].Value = true;
            }
        }

        private void right_invertsel_Click(object sender, EventArgs e)
        {
            //循环dataGridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //判断当前行是否被选中
                if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue == true)
                    //设置每一行的选择框为未选中
                    dataGridView1.Rows[i].Cells[0].Value = false;
                else
                    //设置每一行的选择框为选中
                    dataGridView1.Rows[i].Cells[0].Value = true;
            }
        }

        private void right_cancel_Click(object sender, EventArgs e)
        {
            //循环dataGridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //设置每一行的选择框为未选中
                dataGridView1.Rows[i].Cells[0].Value = false;
            }
        }

        private void right_delete_Click(object sender, EventArgs e)
        {
            //循环dataGridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //判断当前行是否被选中
                if ((bool)dataGridView1.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    try
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                    catch { }
                }
            }
        }

        private void right_clean_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void left_refresh_Click(object sender, EventArgs e)
        {

        }

        private void left_importip_Click(object sender, EventArgs e)
        {
            importipDialog.InitialDirectory = "C:\\";//初始加载路径为C盘;
            importipDialog.Filter = "文本文件 (*.txt)|*.txt";//过滤你想设置的文本文件类型（这是xml型）
            // openFileDialog1.Filter = "文本文件 (*.txt)|*.txt|All files (*.*)|*.*";（这是全部类型文件）
            if (this.importipDialog.ShowDialog() == DialogResult.OK)
            {
                path2 = importipDialog.FileName;
                //读取txt文件
                JArray iplist = ReadTxt.Read(path2);
                //显示读取数据
                for (int i = 0; i < iplist.Count; i++)
                {
                    dataGridView2.Rows.Add();
                    int n = 1;
                    foreach (string key in iplist[i])
                    {
                        if (n > 6)
                        {
                            break;
                        }
                        dataGridView2.Rows[i].Cells[n].Value = key;
                        n++;
                    }
                }
            }
        }

        private void left_addip_Click(object sender, EventArgs e)
        {
            addipForm addipform = new addipForm();
            addipform.GetForm(this);
            addipform.Show();
        }

        private void left_saveip_Click(object sender, EventArgs e)
        {
            //保存
            DataTable dt = DataGridViewToTable.GetDgvToTable(dataGridView2);
            dt.Columns.RemoveAt(0);
            dt.Columns.RemoveAt(0);
            WriteTxt.AddLgoToTXT(dt, "ip.txt");
        }

        private void left_selall_Click(object sender, EventArgs e)
        {
            //循环dataGridView
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                //设置每一行的选择框为选中
                dataGridView2.Rows[i].Cells[0].Value = true;
            }
        }

        private void left_invertsel_Click(object sender, EventArgs e)
        {
            //循环dataGridView
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                //判断当前行是否被选中
                if ((bool)dataGridView2.Rows[i].Cells[0].EditedFormattedValue == true)
                    //设置每一行的选择框为未选中
                    dataGridView2.Rows[i].Cells[0].Value = false;
                else
                    //设置每一行的选择框为选中
                    dataGridView2.Rows[i].Cells[0].Value = true;
            }
        }

        private void left_cancel_Click(object sender, EventArgs e)
        {
            //循环dataGridView
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                //设置每一行的选择框为未选中
                dataGridView2.Rows[i].Cells[0].Value = false;
            }
        }

        private void left_delete_Click(object sender, EventArgs e)
        {
            //循环dataGridView
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                //判断当前行是否被选中
                if ((bool)dataGridView2.Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    try
                    {
                        dataGridView2.Rows.RemoveAt(i);
                        i--;
                    }
                    catch { }
                }
            }
        }

        private void left_clean_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }
        /// <summary>
        /// 一键发布
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            DataTable dt1 = DataGridViewToTable.GetDgvToTable(dataGridView1);
            dt1.Columns.RemoveAt(0);
            dt1.Columns.RemoveAt(0);
            dt1.Rows.RemoveAt(dt1.Rows.Count-1);
            DataTable dt2 = DataGridViewToTable.GetDgvToTable(dataGridView2);
            dt2.Columns.RemoveAt(0);
            dt2.Columns.RemoveAt(0);
            dt2.Columns.RemoveAt(0);
            dt2.Rows.RemoveAt(dt2.Rows.Count-1);

            //处理新浪动态发布
            publishForm publishform = new publishForm(dt1,dt2);
            publishform.Show();
        }
        /// <summary>
        /// 清除所有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }
        /// <summary>
        /// 清除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
        /// <summary>
        /// 清除IP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }
    }
}
