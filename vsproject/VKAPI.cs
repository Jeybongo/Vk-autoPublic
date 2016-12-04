using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkPoster
{
    class VKAPI
    {
        static private String _uid;
        static private String _token;

        static public void setUid(String uid)
        {
            VKAPI._uid = uid;
        }

        static public void setToken(String token)
        {
            VKAPI._token = token;
        }

        static String getAdminCommunities(String uid)
        {
            return "";
        }
    }
}
