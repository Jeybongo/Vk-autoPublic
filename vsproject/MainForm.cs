using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VkPoster
{
    public partial class MainForm : Form
    {
        private VkWorker _worker;
        public MainForm()
        {
            InitializeComponent();

            _worker = new VkWorker();
            _worker.onPost += this.photoPosted;
        }

        //some photo were posted
        private void photoPosted()
        {
            updatePhoto();
        }

        //change photo on view with the next one
        private void updatePhoto() 
        {
            FileInfo photo = _worker.getNext();
            if (photo == null)
            {
                DialogResult result = MessageBox.Show("В папке больше нет картинок. Переместите новые картинки в папку и возвращайтесь", "Картинки", MessageBoxButtons.OK);
                Environment.Exit(0);
            }

            nextPictureBox.ImageLocation = photo.FullName;
            nextPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            _worker.postNext();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (randomCheckBox.Checked)
            {
                _worker.setTimer(new RandomTimer());
            }

            if (regularCheckBox.Checked)
            {
                Double timerValue = (double)regularIntervalBox.Value;
                _worker.setTimer(new RegularTimer(timerValue));
            }
        }

        private void regularCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            randomCheckBox.Checked = !regularCheckBox.Checked;
        }

        private void randomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            regularCheckBox.Checked = !randomCheckBox.Checked;
        }

        //called when the form was showed and all data is setted up
        private void MainForm_Shown(object sender, EventArgs e)
        {   
            updatePhoto();

            VkCommunity comm = _worker.getCommunity();
            commLabel.Text = comm.Name;

            String folderPath = _worker.getFolderPath();
            folderLabel.Text = folderPath;
        }

        private void commLabel_Click(object sender, EventArgs e)
        {
            //open community in browser
            VkCommunity comm = _worker.getCommunity();
            System.Diagnostics.Process.Start("https://vk.com/public" + comm.ID);
        }

        private void folderLabel_Click(object sender, EventArgs e)
        {
            //open folder in windows explorer
            Process.Start(folderLabel.Text);
        }
    }
}
