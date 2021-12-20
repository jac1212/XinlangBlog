using System.Net;
using System.Web;
using System.Collections.Generic;

namespace LeoShi.Soft.OpenSinaAPI
{
    public class HttpGet : BaseHttpRequest
    {
        private const string GET = "GET";
        private const string AccessToken = "http://api.t.sina.com.cn/oauth/access_token";
        private const string AUTHORIZE = "http://api.t.sina.com.cn/oauth/authorize";
        private const string RequestToken = "http://api.t.sina.com.cn/oauth/request_token";
        private const string OauthToken = "oauth_token";
        private const string OauthTokenSecret = "oauth_token_secret";


        public override string Request(string uri, string postData)
        {
            string outUrl;
            var queryString = AppendSignatureString(GET, uri, out outUrl);
            if (queryString.Length > 0)
            {
                outUrl += "?";
            }
            return WebRequest(GET, outUrl + queryString);
        }

        public void GetAccessToken()
        {
            SetTokenAndTokenSecret(AccessToken);
        }
        
        //add by fmn
        public void GetVerifier(string username,string password,int userNum)
        {
            string authUrl = string.Format("http://api.t.sina.com.cn/oauth/authorize?oauth_token={0}&oauth_callback=xml&userId={1}&passwd={2}", GlobalInfo.requestTokens[userNum], username, password);
            string XmlStr = HttpGet.WebRequest("GET", authUrl);
            List<Verifier> listInfo = returnVerifier.get(XmlStr);
            Verifier = listInfo[0].oauth_verifier;
        }

        private void SetTokenAndTokenSecret(string url)
        {
            var response = Request(url, string.Empty);

            if (response.Length <= 0) return;
            var queryString = HttpUtility.ParseQueryString(response);
            if (queryString[OauthToken] != null)
            {
                Token = queryString[OauthToken];
            }
            if (queryString[OauthTokenSecret] != null)
            {
                TokenSecret = queryString[OauthTokenSecret];
            }
        }

        public void GetRequestToken()
        {
            SetTokenAndTokenSecret(RequestToken);
        }

        public string GetAuthorizationUrl()
        {
            var ret = string.Format("{0}?oauth_token={1}", AUTHORIZE, Token);
            return ret;
        }

        private static string WebRequest(string method, string url)
        {
            var httpWebRequest = System.Net.WebRequest.Create(url) as HttpWebRequest;
            httpWebRequest.Method = method;
            httpWebRequest.ServicePoint.Expect100Continue = false;
            return GetHttpWebResponse(httpWebRequest);
        }
    }
}