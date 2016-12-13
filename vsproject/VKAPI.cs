using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace VkPoster
{
    class VKAPI
    {
        //user id
        static protected String _uid = "";
        
        //token for API
        static protected String _token = "";
        
        //group id for uploading
        static protected String _cid = "";
        
        //main domain
        static protected String VK_API_URL = "https://api.vk.com/method/";
        
        //method for retrieve admin coomunities
        static protected String GET_ADMIN_COMMUNITIES_METHOD = "groups.get?filter=admin&extended=1";
        
        //method for posting to the wall
        static protected String WALL_POST_METHOD = "wall.post?from_group=1";

        static public void setUid(String uid)
        {
            VKAPI._uid = uid;
        }

        static public void setToken(String token)
        {
            VKAPI._token = token;
        }

        static public void setCommunityId(String id)
        {
            VKAPI._cid = id;
        }

        static public bool isReady()
        {
            return VKAPI._token.Length > 0 && VKAPI._uid.Length > 0;
        }

        static public List<VkCommunity> getAdminCommunities()
        {
            String url = VK_API_URL + GET_ADMIN_COMMUNITIES_METHOD + "&user_id=" + VKAPI._uid + "&access_token=" + VKAPI._token;
            String resp = VKAPI.makeRequest(url);
            dynamic json = parseJson(resp);

            List<VkCommunity> res = new List<VkCommunity>();

            if (json["response"] != null) {
                if (json["response"].Count >= 2)
                {
                    for (int i = 1; i < json["response"].Count; i++)
                    {
                        VkCommunity comm = new VkCommunity(json["response"][i]["name"].ToString(), json["response"][i]["gid"].ToString());
                        res.Add(comm);
                    }
                }

            }


            return res;
        }

        static public bool postPhoto(FileInfo photo) 
        {
            String photoId = new PhotoUploader(photo).upload();
            if (photoId.Length == 0)
            {
                return false;
            }

            String url = VK_API_URL + WALL_POST_METHOD + "&owner_id=-" + _cid + "&attachments=" + photoId;
            String resp = VKAPI.makeRequest(url);
            return true;
        }

        static protected String makeRequest(String url)
        {
            url += "&access_token=" + _token;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string strResponse = reader.ReadToEnd();
                response.Close();
                return strResponse;
            }

            return "{}";
        }

        static protected dynamic parseJson(String jsonString)
        {
            try
            {
                dynamic stuff = JsonConvert.DeserializeObject(jsonString);
                return stuff;
            }
            catch
            {
                return null;
            }
        }
    }
}
