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

        //for authorization
        public bool auth()
        {
            return true;
        }

        //choose public for posting
        public bool choosePublic()
        {
            return true;
        }

        //post photo with path to public
        public bool post(FileInfo fileInfo)
        {
            return true;
        }
    }
}
