using System;
using System.Collections.Generic;
using System.Text;

///自己写的对sinaApi常用方法的封装。
namespace LeoShi.Soft.OpenSinaAPI
{
    public class SinaApiEncapsulate
    {
        public static List<SinaStatus> returnSinaInfo(string username,string password,string query)
        {
            var httpRequest = HttpRequestFactory.CreateHttpRequest(Method.GET) as HttpGet;
            httpRequest.GetRequestToken();
            string url = httpRequest.GetAuthorizationUrl();
            GlobalInfo.requestToken = httpRequest.Token;
            GlobalInfo.requesTokenSecret = httpRequest.TokenSecret;

            httpRequest.GetVerifier(username,password,0);
            httpRequest.GetAccessToken();
            string basic = "http://api.t.sina.com.cn/";
            string queryUrl = basic + query;
            string recDate = httpRequest.Request(queryUrl, string.Empty);
            List<SinaStatus> getSinaInfoList = returnStatus.get(recDate);
            return getSinaInfoList;
        }
    }
}
