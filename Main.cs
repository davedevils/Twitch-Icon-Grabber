using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitch_Icon_Grabber
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            size1.Items.Add("28x28");
            size1.Items.Add("56x56");
            size1.Items.Add("112x112");
            size1.SelectedIndex = 0;

            size2.Items.Add("28x28");
            size2.Items.Add("56x56");
            size2.Items.Add("112x112");
            size2.SelectedIndex = 0;
        }


        private bool downloadfile(string inputFileName, string outputFileName, int current, int max, long fileOriginalSize)
        {
            int bytesReceived = 0;

            HttpWebRequest httpRequest = (HttpWebRequest)
            WebRequest.Create(inputFileName);
            httpRequest.Method = WebRequestMethods.Http.Get;
            HttpWebResponse httpResponse;
            try
            {
                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            }
            catch (Exception exp)
            {
                if (exp.ToString().Contains("(404)"))
                {
                    string[] split = inputFileName.Split("/".ToCharArray());
                    //MessageBox.Show("Impossible de trouver le fichier " + split[split.Length - 1] + " !", "Fatal erreur");
                }
                else
                {
                    MessageBox.Show("Impossible de ce connecter au site web, verifier votre connection internet!", "Fatal Error");
                }

                return false;
            }
            using (Stream httpResponseStream = httpResponse.GetResponseStream())
            {

                int bufferSize = 1024;
                byte[] buffer = new byte[bufferSize];
                int bytesRead = 0;
                long length = httpResponse.ContentLength;
                long totalbytesread = 0;

                using (FileStream fileStreamCompressed = File.Create(outputFileName ))
                {
                    while ((bytesRead = httpResponseStream.Read(buffer, 0, bufferSize)) != 0)
                    {
                        bytesReceived += bytesRead;

                        totalbytesread += bytesRead;
                        fileStreamCompressed.Write(buffer, 0, bytesRead);

                    }
                }

            }

            return true;
        }

        private void needselected_Click(object sender, EventArgs e)
        {
            if(Regex.IsMatch(iconnumber.Text, @"^\d+$") && iconnumber.Text != "")
            {
                int SelectedSize = 1;

                if (size1.Text == "56x56")
                    SelectedSize = 2;
                else if(size1.Text == "112x112")
                    SelectedSize = 3;


                bool exists = System.IO.Directory.Exists(size1.Text);

                if (!exists)
                    System.IO.Directory.CreateDirectory(size1.Text);

                string filename = size1.Text + "\\" + iconnumber.Text + ".png";
                string remoteUri = "https://static-cdn.jtvnw.net/emoticons/v1/" + iconnumber.Text + "/"+ SelectedSize + ".0";


                if (!downloadfile(remoteUri, filename, 0, 1, 0))
                {
                        MessageBox.Show("This icon not existe !", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                        MessageBox.Show("File have been download :)", "It's ok !", MessageBoxButtons.OK);
                }



            }
            else
            {
                MessageBox.Show("You have forggeten to set number !", "Error !",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void needall_Click(object sender, EventArgs e)
        {

           
            int SelectedSize = 1;

            if (size2.Text == "56x56")
                SelectedSize = 2;
            else if (size2.Text == "112x112")
                SelectedSize = 3;


            bool exists = System.IO.Directory.Exists(size2.Text);

            if (!exists)
                System.IO.Directory.CreateDirectory(size2.Text);

            for (int iconnum = 1; iconnum < 300000; iconnum++)
            {
                string filename = size2.Text + "\\" + iconnum + ".png";
                string remoteUri = "https://static-cdn.jtvnw.net/emoticons/v1/" + iconnum + "/" + SelectedSize + ".0";

                   if (!downloadfile(remoteUri, filename, 0, 1, 0))
                   {
                        if (iconnum > 300000)
                        {
                            MessageBox.Show("All File have been download :)", "It's ok !", MessageBoxButtons.OK);
                            break;
                        }
                   }

            }
        }

    }
}
