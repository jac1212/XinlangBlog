using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XinlangBlog
{
    public partial class proxyForm : Form
    {
        public proxyForm()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Start()
        {
            txtResult.Clear();
            var client = new WebClient();
            var uri = new Uri(txtUrl.Text.Trim());
            client.DownloadStringCompleted += client_DownloadStringCompleted;
            client.Encoding = Encoding.UTF8;

            if (checkBox.Checked)
            {
                var proxy = CreateProxy();
                if (proxy == null) return;
                client.Proxy = proxy;
            }
            client.DownloadStringAsync(uri);
        }
        private void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                txtResult.Text = e.Result;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                if (ex.InnerException != null) msg = ex.InnerException.Message;
                MessageBox.Show(msg);
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //gbProxy.Enabled = checkBox.Checked;
        }
        private WebProxy CreateProxy()
        {
            var host = txtHost.Text.Trim();
            if (string.IsNullOrWhiteSpace(host))
            {
                MessageBox.Show("请输入代理地址");
                return null;
            }
            var port = 0;
            try
            {
                port = Convert.ToInt32(txtPort.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的代理端口");
                return null;
            }
            var cre = new NetworkCredential(txtUserName.Text, txtPwd.Text);
            var proxy = new WebProxy(txtHost.Text.Trim(), port) {Credentials = cre};
            return proxy;
        }

        
    }
}
