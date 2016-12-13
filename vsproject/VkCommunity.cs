using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkPoster
{
    public class VkCommunity
    {
        private String _name;
        private String _id;

        public String Name
        {
            get
            {
                return _name;
            }
        }

        public String ID
        {
            get
            {
                return _id;
            }
        }

        public VkCommunity(String name, String id)
        {
            this._name = name;
            this._id = id;
        }
    }
}