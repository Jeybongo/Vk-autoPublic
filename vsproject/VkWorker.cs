using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkPoster
{
    //delegate for vk post event
    delegate void PhotoPosted(FileInfo photo);

    class VkWorker
    {
        public event PhotoPosted onPost;

        private String _token;
        private String _publicId;

        //post photo with path to public
        public bool post(FileInfo fileInfo)
        {
            return true;
        }

        static public List<VkCommunity> fetchAdminCommunities()
        {
            List<VkCommunity> comm = new List<VkCommunity>();

            return comm;
        }
    }
}
