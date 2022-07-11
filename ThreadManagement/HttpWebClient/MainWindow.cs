
using System.ComponentModel;
using System.Net;

namespace HttpWebClient
{
    public partial class MainWindow : Form
    {
        Uri uri;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
           try
            {
                uri = new Uri(txtUrl.Text);
                Thread thread = new Thread(Download);
                thread.Start(uri);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur de téléchargement: " + ex.Message);
            }
        }

        public async static void Download(object? uri)
        {
            HttpResponseMessage response = await Download((Uri)uri);

            string json = await response.Content.ReadAsStringAsync();
        }

        public async static Task<HttpResponseMessage> Download(Uri uri)
        {            
            HttpClient httpClient = new HttpClient();
            //httpClient.
            HttpResponseMessage response = await httpClient.GetAsync(uri);

            return response;
        }


        private void Download_Progress(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(() =>
            {
                progressBar1.Value = e.ProgressPercentage;
            });
            
        }

        private void Download_Done(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Téléchargement terminé !");
        }
    }
}
