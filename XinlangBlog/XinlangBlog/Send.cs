using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHtmlUnit;
using NHtmlUnit.Html;
using System.Threading;

namespace XinlangBlog
{
    class Send
    {
        public static bool send(string username, string password, string ip, int port, string text)
        {
            //新浪微博登录页面
            string baseUrl = "https://passport.weibo.cn/signin/login?entry=mweibo&res=wel&wm=3349&r=http%3A%2F%2Fm.weibo.cn%2F";
            //WebClient client = new WebClient(BrowserVersion.CHROME);

            //代理服务器的配置
            WebClient client = new WebClient(BrowserVersion.CHROME, ip, port);
            //DefaultCredentialsProvider credentialsProvider = client.CredentialsProvider();
            //credentialsProvider.addCredentials("username", "password");


            client.Options.JavaScriptEnabled = true;
            client.Options.CssEnabled = false;
            client.Options.RedirectEnabled = true;
            client.Options.ThrowExceptionOnScriptError = false;
            client.Options.ThrowExceptionOnFailingStatusCode = false;
            client.Options.ActiveXNative = false;
            client.AjaxController = new NicelyResynchronizingAjaxController();

            client.Options.Timeout = 5000;
            client.WaitForBackgroundJavaScript(5000);
            client.AddRequestHeader("User-Agent", "Mozilla/5.0 (iPad; CPU OS 7_0_2 like Mac OS X) AppleWebKit/537.51.1 (KHTML, like Gecko) Version/7.0 Mobile/11A501 Safari/9537.53");


            HtmlPage page = client.GetHtmlPage(baseUrl);
            //client.WaitForBackgroundJavaScript(5000);

            //等待页面加载
            Thread.Sleep(3000);
           

            HtmlInput user = (HtmlInput)page.GetElementById("loginName");
            user.Focus();
            user.SetValueAttribute(username);
            HtmlInput pwd = (HtmlInput)page.GetElementById("loginPassword");
            pwd.Focus();
            pwd.SetValueAttribute(password);

            //点击登录
            DomElement button = (DomElement)page.GetElementById("loginAction");
            button.Focus();
            page = (HtmlPage)button.Click();

            //等待页面加载
            Thread.Sleep(3000);

            ////跳转到发送微博页面    
            page = client.GetHtmlPage("https://weibo.com/");
            //等待页面加载
            Thread.Sleep(3000);
            //发送按钮
            DomElement fasong = (DomElement)page.GetElementByClassName("W_btn_a");
            //获取文本框
            HtmlTextArea content = (HtmlTextArea)page.GetElementByClassName("input").FirstElementChild;
            content.Focus();
            DateTime date = DateTime.Now;

            //填写你要发送的内容
            content.Text = text;
            Thread.Sleep(3000);

            //设置按钮为可用
            fasong.SetAttribute("class", "W_btn_a btn_30px");
            Thread.Sleep(3000);
            //发送！！！
            page = (HtmlPage)fasong.Click();
            Thread.Sleep(5000);

            Console.Out.WriteLine(page.AsText());
            client.Close();
            return true;
        }
    }
}
