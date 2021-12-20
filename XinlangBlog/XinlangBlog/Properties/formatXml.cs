using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace LeoShi.Soft.OpenSinaAPI
{
    public class Verifier
    {
        public string oauth_token;
        public string oauth_verifier;
    }

    //返回Verifier的list<>形式。
    public static class returnVerifier
    {
        public static List<Verifier> get(string xmlStr)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlStr);
            List<Verifier> listInfo = new List<Verifier>();
            Verifier tmpVer = new Verifier();
            XmlNode xmlNode = doc.SelectSingleNode("oauth");
            tmpVer.oauth_token = xmlNode.SelectSingleNode("oauth_token").InnerText;
            tmpVer.oauth_verifier = xmlNode.SelectSingleNode("oauth_verifier").InnerText;
            listInfo.Add(tmpVer);
            return listInfo;
        }
    }

    public class SinaStatus
    {
        public string created_at;
        public string source;
        public string id;
        public string text;
        public bool favorited;
        public bool truncated;
        public string in_reply_to_status_id;
        public string in_reply_to_user_id;
        public string in_reply_to_screen_name;
        public string thumbnail_pic;
        public string bmiddle_pic;
        public string original_pic;
        public string mid;
        public SinaUser user;
        //public string ;
    }

    public class SinaUser
    { 
        public string id;
        public string screen_name;
        public string name;
        public string province;
        public string city;
        public string location;
        public string description;
        public string url;
        public string profile_image_url;
        public string domain;
        public string gender;
        public string followers_count;
        public string friends_count;
        public string statuses_count;
        public string favourites_count;
        public string created_at;
        public string following;
        public string verified;
        public string allow_all_act_msg;
        public bool geo_enabled;
    }

    public static class returnStatus
    {
        public static List<SinaStatus> get(string xmlStr)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlStr);
            List<SinaStatus> listInfo = new List<SinaStatus>();
            XmlNodeList xmlList = doc.SelectNodes("/statuses/status");
            foreach(XmlNode node in xmlList)
            {
                SinaStatus tmpStatus = new SinaStatus();
                tmpStatus.created_at = node.SelectSingleNode("created_at").InnerText;
                tmpStatus.source = node.SelectSingleNode("source").InnerText;
                tmpStatus.id = node.SelectSingleNode("id").InnerText;
                tmpStatus.text = node.SelectSingleNode("text").InnerText;
                tmpStatus.favorited = bool.Parse(node.SelectSingleNode("favorited").InnerText);
                tmpStatus.truncated = bool.Parse(node.SelectSingleNode("truncated").InnerText);
                tmpStatus.in_reply_to_status_id = node.SelectSingleNode("in_reply_to_status_id").InnerText;
                tmpStatus.in_reply_to_user_id = node.SelectSingleNode("in_reply_to_user_id").InnerText;
                tmpStatus.in_reply_to_screen_name = node.SelectSingleNode("in_reply_to_screen_name").InnerText;
                tmpStatus.mid = node.SelectSingleNode("mid").InnerText;
                if (node.SelectSingleNode("thumbnail_pic") != null)
                {
                    tmpStatus.thumbnail_pic = node.SelectSingleNode("thumbnail_pic").InnerText;
                    tmpStatus.bmiddle_pic = node.SelectSingleNode("bmiddle_pic").InnerText;
                    tmpStatus.original_pic = node.SelectSingleNode("original_pic").InnerText;
                }
                else
                {
                    tmpStatus.thumbnail_pic = "";
                    tmpStatus.bmiddle_pic = "";
                    tmpStatus.original_pic = "";
                }
                SinaUser tmpUser = new SinaUser();
                tmpUser.id=node.SelectSingleNode("user/id").InnerText;
                tmpUser.screen_name = node.SelectSingleNode("user/screen_name").InnerText;
                tmpUser.name = node.SelectSingleNode("user/name").InnerText;
                tmpUser.province = node.SelectSingleNode("user/province").InnerText;
                tmpUser.city = node.SelectSingleNode("user/city").InnerText;
                tmpUser.location = node.SelectSingleNode("user/location").InnerText;
                tmpUser.description = node.SelectSingleNode("user/description").InnerText;
                tmpUser.url = node.SelectSingleNode("user/url").InnerText;
                tmpUser.profile_image_url = node.SelectSingleNode("user/profile_image_url").InnerText;
                tmpUser.domain = node.SelectSingleNode("user/domain").InnerText;
                tmpUser.gender = node.SelectSingleNode("user/gender").InnerText;
                tmpUser.followers_count = node.SelectSingleNode("user/followers_count").InnerText;
                tmpUser.friends_count = node.SelectSingleNode("user/friends_count").InnerText;
                tmpUser.statuses_count = node.SelectSingleNode("user/statuses_count").InnerText;
                tmpUser.favourites_count = node.SelectSingleNode("user/favourites_count").InnerText;
                tmpUser.created_at = node.SelectSingleNode("user/created_at").InnerText;
                tmpUser.following = node.SelectSingleNode("user/following").InnerText;
                tmpUser.verified = node.SelectSingleNode("user/verified").InnerText;
                tmpUser.allow_all_act_msg = node.SelectSingleNode("user/allow_all_act_msg").InnerText;
                tmpUser.geo_enabled = bool.Parse(node.SelectSingleNode("user/geo_enabled").InnerText);
                tmpStatus.user = tmpUser;
                listInfo.Add(tmpStatus);
                //tmpStatus. = node.SelectSingleNode("").InnerText;
            }
            return listInfo;
        }

    }
}
