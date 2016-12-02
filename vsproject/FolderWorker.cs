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
        private List<FileInfo> _photos;
        private String _path;

        public FolderWorker(String path)
        {
            _path = path;

            parseAllPhotos();
        }

        //returns next photo for posting
        FileInfo getNextPhoto()
        {
            if (_photos.Count == 0)
            {
                return null;
            }

            FileInfo nextFile = _photos[0];
            _photos.Remove(nextFile);
            return nextFile;
        }

        //gets all photos from folder
        private void parseAllPhotos()
        {
            DirectoryInfo di = new DirectoryInfo(_path);
           _photos = di.GetFiles("*.png", SearchOption.AllDirectories)
                .Union(di.GetFiles("*.jpg"))
                .Union(di.GetFiles("*.jpeg"))
                .ToList();
        }
    }
}
