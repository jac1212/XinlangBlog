using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XinlangBlog
{
    class ReadTxt
    {
        //使用FileStream类进行文件的读取，并将它转换成char数组，然后输出
        static byte[] byData = new byte[100];
        static char[] charData = new char[1000];
        public static void Read()
        {
            try
            {
                FileStream file = new FileStream("E:\\test.txt", FileMode.Open);
                file.Seek(0, SeekOrigin.Begin);
                file.Read(byData, 0, 100); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
                Decoder d = Encoding.Default.GetDecoder();
                d.GetChars(byData, 0, byData.Length, charData, 0);
                Console.WriteLine(charData);
                file.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        //使用StreamReader读取文件，然后一行一行的输出
        public static JArray Read(string path)
        {
            int n = 1;
            string line;
            JArray list = new JArray();
            try
            {
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                
                while ((line = sr.ReadLine()) != null)
                {
                    if (!line.Equals(""))
                    {
                        int index = line.IndexOf(" ");
                        int leng = line.Length;
                        string v1 = line.Substring(0, index);
                        string v2 = line.Substring(index + 1, leng - index - 1);
                        JObject obj = new JObject();
                        obj["v0"] = n;
                        obj["v1"] = v1;
                        obj["v2"] = v2;
                        list.Add(obj);
                        n++;
                    }
                }
                sr.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
            return list;
        }
    }
}
