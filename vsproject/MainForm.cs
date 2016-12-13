using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VkPoster
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            if (!VKAPI.isReady()) 
            {
                VkAuthForm form = new VkAuthForm();
                form.ShowDialog();
            }

            VkPublicChooser chooser = new VkPublicChooser();
            VkCommunity comm = chooser.chooseCommunity();
        }
    }
}
