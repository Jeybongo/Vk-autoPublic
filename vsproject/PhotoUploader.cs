using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VkPoster
{
    class PhotoUploader : VKAPI
    {
        //to upload image we should get server url for this, upload image by POST-request and save image by calling correct method.
        private const String IMAGE_GET_UPLOAD_SERVER_METHOD = "photos.getWallUploadServer";
        private const String IMAGE_SAVE_METHOD = "photos.saveWallPhoto";

        private FileInfo _photo;

        public PhotoUploader(FileInfo photo)
        {
            this._photo = photo;
        }

        //uploads photo and returns photo id for posting
        //returns empty string, if failed
        public String upload()
        {
            String servUrl = getServer();
            String uploadResp = uploadPhotoToServer(servUrl);
            String saveResp = save(parseParamsAfterUpload(uploadResp));

            //retrieve photo id
            dynamic json = VKAPI.parseJson(saveResp);
            if (json["response"] != null)
            {
                if (json["response"].Count > 0) 
                {
                    if (json["response"][0]["id"] != null) 
                    {
                        return json["response"][0]["id"];
                    }
                }
            }

            return "";
        }

        //returns server for image upload
        private String getServer()
        {
            string param = "group_id=" + VKAPI._cid;
            String resp = VKAPI.makeRequest(VKAPI.VK_API_URL + IMAGE_GET_UPLOAD_SERVER_METHOD + "?" + param);
            dynamic json = VKAPI.parseJson(resp);

            if (json["response"] != null)
            {
                if (json["response"]["upload_url"] != null)
                {
                    return json["response"]["upload_url"];
                }
            }

            return "";
        }

        //uploads our image to the vk server
        //the way we do it tooked from the internet 
        //(http://www.java2s.com/Tutorials/CSharp/System.Net/WebClient/C_WebClient_UploadFile_String_String_.htm)
        private String uploadPhotoToServer(String serverUrl) {
            WebClient myWebClient = new WebClient();
            byte[] responseArray = myWebClient.UploadFile(serverUrl, _photo.FullName);
            String resp = System.Text.Encoding.ASCII.GetString(responseArray);
            return resp;
        }

        private String parseParamsAfterUpload(String resp)
        {
            String param = "";
            dynamic json = VKAPI.parseJson(resp);
            if (json["server"] != null)
            {
                param += "server=" + json["server"];
            }

            if (json["hash"] != null)
            {
                param += "&hash=" + json["hash"];
            }

            if (json["photo"] != null)
            {
                param += "&photo=" + json["photo"];
            }

            return param;
        }

        //saves uploaded image
        private String save(String param) {
            String resp = VKAPI.makeRequest(VKAPI.VK_API_URL + IMAGE_SAVE_METHOD + "?" + param 
                + "&group_id="+VKAPI._cid);
            dynamic json = VKAPI.parseJson(resp);
            return resp;
        }


    }
}
