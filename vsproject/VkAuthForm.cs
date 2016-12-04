using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VkPoster
{
    public partial class VkAuthForm : Form
    {

        private const String AUTH_URL = "http://oauth.vk.com/authorize?client_id=5759618&scope=wall, groups,offline&display=page&response_type=token";
        private String _token = "";
        private String _uid = "";

        public VkAuthForm()
        {
            InitializeComponent();

            start();
        }

        private void start()
        {
            webBrowser1.Navigate(AUTH_URL);
        }

        private void stop()
        {
            this.Close();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            WebBrowser browser = sender as WebBrowser;
            String currUrl = browser.Document.Url.AbsoluteUri;
            String token = getParamValue(currUrl, "access_token");
            if (token == null)
            {
                return;
            }

            _token = token;
            _uid = getParamValue(currUrl, "user_id");
            stop();
        }

        private String getParamValue(String url, String param)
        {
            if (!url.Contains(param))
            {
                return null;
            }

            String value = "";
            int index = url.IndexOf(param) + param.Length + "=".Length;
            while (index < url.Length && url[index] != '&')
            {
                value += url[index];
                index++;
            }

            return value;
        }

    }
}
