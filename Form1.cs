using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDownload
{
    public partial class Form1 : Form
    {
        string defaultPath = "D:\\";


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            if (TxtUrl.Text == "")
            {
                MessageBox.Show("Please enter a URL");
            }
            else if (!CheckValidURL(TxtUrl.Text)){
                MessageBox.Show("Invalid URL. Please enter again");
                TxtUrl.Text = "";
            }
            else
            {
                var serverResponse = CheckURLDownloadable(TxtUrl.Text);
                if (serverResponse.Item1)
                {
                    string filename = String.Concat(defaultPath + "\\", Path.GetFileName(TxtUrl.Text));
                    try
                    {
                        WebClient client = new WebClient();
                        LblProgress.Visible = true;
                        ProgressBar1.Visible = true;
                        client.DownloadProgressChanged += Client_DownloadProgressChanged;
                        client.DownloadFileCompleted += Client_DownloadFileCompleted;
                        client.DownloadFileAsync(new Uri(TxtPath.Text), filename);
                    }
                    catch (WebException weX)
                    {
                        MessageBox.Show(weX.Message);
                    }
                }
                else
                {
                    MessageBox.Show("The URL is not downloadable");
                }
            }
        }

        void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            lblDownload.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
            ProgressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            ProgressBar1.Value = ProgressBar1.Maximum;
            MessageBox.Show("Download Completed");
            ProgressBar1.Visible = false;
            LblProgress.Visible = false;
        }

        public static bool CheckValidURL(string url)
        {
            bool tryCreateResult = Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult);
            if (tryCreateResult == true && uriResult != null)
                return true;
            else
                return false;
        }

        public static Tuple<bool, string> CheckURLDownloadable(string url)
        {
            bool isValidURL = true;
            string data = string.Empty;
            using (WebClient client = new WebClient())
            {
                try
                {
                    data = client.DownloadString(url);

                }
                catch (WebException weX)
                {
                    isValidURL = !isValidURL;
                    data = weX.Message;
                }
            }
            return Tuple.Create<bool, string>(isValidURL, data);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                defaultPath = folderBrowserDialog1.SelectedPath;
                TxtPath.Text = defaultPath;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtPath.Text = defaultPath;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FolderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
