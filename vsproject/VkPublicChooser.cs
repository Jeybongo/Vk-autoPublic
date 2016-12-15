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
        private VkCommunity _choosen;

        public VkPublicChooser()
        {
            InitializeComponent();
        }

        public VkCommunity chooseCommunity()
        {
            //retrieve admin communities
            getCommunities();

            //show us
            this.ShowDialog();

            //choosen community
            return _choosen;
        }


        //go out
        private void noCommunities()
        {
            DialogResult result = MessageBox.Show("У Вас нет своих сообществ, нужно создать.", "Сообщества", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                //opens link in default browser
                System.Diagnostics.Process.Start(CREATE_PUBLIC_URL);
            }

            //close the programm
            Environment.Exit(0);
        }

        private void getCommunities()
        {
            _communities = VKAPI.getAdminCommunities();

            //has no communities with admin rights
            if (_communities.Count == 0)
            {
                noCommunities();
                return;
            }

            fillData();
        }

        private void fillData()
        {
            communitiesComboBox.DataSource = _communities;
            communitiesComboBox.DisplayMember = "Name";
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            //set community before closing
            _choosen = _communities[communitiesComboBox.SelectedIndex];
            this.Close();
        }
    }
}
