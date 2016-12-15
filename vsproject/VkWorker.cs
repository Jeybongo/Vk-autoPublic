using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkPoster
{
    //delegate for vk post event
    delegate void PhotoPosted();

    class VkWorker
    {
        public event PhotoPosted onPost;

        private FolderWorker _fbdWorker;
        private VkCommunity _community;
        private ITimer _timer;

        public VkWorker()
        {

            if (!VKAPI.isReady())
            {
                VkAuthForm form = new VkAuthForm();
                form.ShowDialog();

                //user doesn't want to continue (close app or no auth)
                if (!VKAPI.isReady())
                {
                    //close the app
                    Environment.Exit(0);
                }
            }

            VkPublicChooser chooser = new VkPublicChooser();
            _community = chooser.chooseCommunity();
            
            //user closed the window
            if (_community == null)
            {
                //close the app
                Environment.Exit(0);
            }


            VKAPI.setCommunityId(_community.ID);

            _fbdWorker = new FolderWorker();
        }

        //sets timer for posting
        public void setTimer(ITimer timer)
        {
            //remove this from prev timer
            if (_timer != null)
            {
                _timer.onTimer -= this.postNext;
                _timer.stop();
            }

            //set new timer
            _timer = timer;
            _timer.onTimer += this.postNext;
            _timer.start();
        }

        //returns folder path
        public String getFolderPath()
        {
            return _fbdWorker.getPath();
        }

        //returns community
        public VkCommunity getCommunity()
        {
            return _community;
        }

        //post photo with path to public
        public void postNext()
        {
            FileInfo nextPhoto = _fbdWorker.getNextPhoto(true);
            if (nextPhoto != null && VKAPI.postPhoto(nextPhoto))
            {
                onPost();
            }
        }

        //returns nextPhoto
        public FileInfo getNext()
        {
            return _fbdWorker.getNextPhoto();
        }

    }
}
