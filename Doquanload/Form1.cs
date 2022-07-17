using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using MediaToolkit;
using System.IO;
using System.Net;

namespace Doquanload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean format = true;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void download_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Klasör Seçiniz" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    GetTitle();
                    MessageBox.Show("İndirme OK","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    var yt = YouTube.Default;
                    var video = await yt.GetVideoAsync(url.Text);
                    File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());

                    var inputfile = new MediaToolkit.Model.MediaFile { Filename =fbd.SelectedPath + @"\"+video.FullName};
                    var outputfile = new MediaToolkit.Model.MediaFile { Filename = $"{fbd.SelectedPath + @"\" + video.FullName}.mp3" };

                    using ( var enging = new Engine())
                    {
                        enging.GetMetadata(inputfile);
                        enging.Convert(inputfile, outputfile);
                    }
                    if (format == true)
                    {
                        File.Delete(fbd.SelectedPath + @"\" + video.FullName);
                    }
                    else
                    {
                        File.Delete($"{fbd.SelectedPath + @"\" + video.FullName}.mp3");

                    }
                    progressBar1.Value = 100;
                    MessageBox.Show("İndirme Bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Lütfen Dosya Yolu Seçiniz !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mp3_TextChanged(object sender, EventArgs e)
        {
            format = true;
        }

        private void mp4_TextChanged(object sender, EventArgs e)
        {
            format = false;

        }

        void GetTitle()
        {
            WebRequest istek = HttpWebRequest.Create(url.Text);
            WebResponse yanit;
            yanit = istek.GetResponse();
            StreamReader sr = new StreamReader(yanit.GetResponseStream());
            string gelen = sr.ReadToEnd();
            int baslangic = gelen.IndexOf("<title>") + 7;
            int bitis = gelen.Substring(baslangic).IndexOf("</title>");
            string gelenbilgi = gelen.Substring(baslangic, bitis);
            baslik.Text = gelenbilgi;
        }
    }
}
