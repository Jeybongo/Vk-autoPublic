using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkPoster
{
    class VkWorker
    {
        String _token;
        String _publicId;

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
        public bool post(String path)
        {
            return true;
        }
    }
}
