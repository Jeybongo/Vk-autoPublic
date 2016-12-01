using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VkPoster
{
    class FolderWorker
    {
        private List<String> _photos;
        private String _path;

        public FolderWorker(String path)
        {
            _path = path;

            parseAllPhotos();
        }

        //returns next photo for posting
        String getNextPhoto()
        {
            return null;
        }

        //gets all photos from folder
        private void parseAllPhotos()
        {

        }
    }
}
