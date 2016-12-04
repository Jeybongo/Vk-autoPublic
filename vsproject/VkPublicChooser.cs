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
    public partial class VkPublicChooser : Form
    {
        private const String CREATE_PUBLIC_URL = "https://m.vk.com/groups?act=new";

        private List<VkCommunity> _communities;

        public VkPublicChooser()
        {
            InitializeComponent();

            _communities = VkWorker.fetchAdminCommunities();
        }

        private void noPublics()
        {
            DialogResult result = MessageBox.Show("У Вас нет своих сообществ, нужно создать.", "Сообщества", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(CREATE_PUBLIC_URL);
            }

            Environment.Exit(0);
        }
    }
}
