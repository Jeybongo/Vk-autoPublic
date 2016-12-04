using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VkPoster
{
    class FolderChooser
    {
        String chooseFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            while (true)
            {
                DialogResult result = fbd.ShowDialog();

                if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }
            }
        }
    }
}
