using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkPoster
{
    class PhotoPoster
    {
        private String _photoPath;
        private String _token;
        private String _public;

        public PhotoPoster(String photo, String token, String publicId)
        {
            _photoPath = photo;
            _token = token;
            _public = publicId;
        }

        public bool post()
        {
            return true;
        }
    }
}
