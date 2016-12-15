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

        public void start() 
        {
            if (!VKAPI.isReady())
            {
                VkAuthForm form = new VkAuthForm();
                form.ShowDialog();
            }

            VkPublicChooser chooser = new VkPublicChooser();
            VkCommunity comm = chooser.chooseCommunity();
        }

        //sets timer for posting
        public void setTimer(ITimer timer)
        {
            //TODO: implement me
        }

        //returns folder path
        public String getFodlerPath()
        {
            //TODO: implement me
            return "";
        }

        //returns community
        public VkCommunity getCommunity()
        {
            //TODO: implement me
            return null;
        }

        //post photo with path to public
        public bool postNext()
        {
            //TODO: implement me
            return true;
        }

        //returns nextPhoto
        public FileInfo getNext()
        {
            //TODO: implement me
            return null;
        }

    }
}
