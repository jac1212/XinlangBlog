using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XinlangBlog
{
    class WriteTxt
    {
        //简洁版
        public static void AddLgoToTXT(System.Data.DataTable dt, string FileName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "save\\" + FileName;
            if (!File.Exists(path))
            {
                FileStream stream = File.Create(path);
                stream.Close();
                stream.Dispose();
            }
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                int rowCount = dt.Rows.Count;//行数
                int columnCount = dt.Columns.Count;//列数
                
                //设置每行每列的单元格,  
                for (int i = 0; i < rowCount; i++)
                {
                    string str = "";
                    for (int j = 0; j < columnCount; j++)
                    {
                        if(str=="")
                            str = dt.Rows[i][j].ToString();
                        else
                            str +=" "+ dt.Rows[i][j].ToString();
                    }
                    writer.WriteLine(str);
                }
            }
        }
    }
}
