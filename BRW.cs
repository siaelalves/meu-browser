using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BRW
{
    public partial class BRW : Form
    {
        public BRW()
        {
            InitializeComponent();
        }

        string mecpes;
        string mecpesfile = "MecPes.brw";
        string homepagefile = "home.brw";

        private void cmdAv_Click(object sender, EventArgs e)
        {
            web.GoForward();
        }

        private void cmdIn_Click(object sender, EventArgs e)
        {            
            web.GoHome();
        }

        private void cmdParar_Click(object sender, EventArgs e)
        {
            web.Stop();
        }

        private void cmdRec_Click(object sender, EventArgs e)
        {
            web.Refresh();
        }

        private void cmdVl_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            lblSit.Text = "Pronto!";
            //            
            this.Text = "Web Browser :: "+ web.DocumentTitle;
            txtURL.Text = web.Url.AbsoluteUri;
            //
            cmdAv.Enabled = web.CanGoForward;
            cmdVl.Enabled = web.CanGoBack;
        }

        private void BRW_Load(object sender, EventArgs e)
        {            
            web.AllowWebBrowserDrop = true;            
            web.ScriptErrorsSuppressed = true;
            //            
            cmdAv.Enabled = web.CanGoForward;
            cmdVl.Enabled = web.CanGoBack;

            foreach (string p in File.ReadAllLines(@mecpesfile, Encoding.Default))
            {
                // Adicionando mecanismos de pesquisa à lista do navegador
                txtMecPs.Items.Add(p.Split(',')[0]);
            }
            web.Url = new Uri(File.ReadAllText(@homepagefile));
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    web.Url = new Uri("http://" + txtURL.Text);
                }
                catch
                {
                    foreach (string p in File.ReadAllLines(@mecpesfile, Encoding.Default))
                    {
                        if (mecpes == p.Split(',')[0])
                        {
                            web.Url = new Uri(p.Split(',')[1] + txtURL.Text);
                        }
                    }
                }                
            }
        }

        private void web_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            lblSit.Text = "Carregando . . .";
        }

        private void web_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // this.Icon = new System.Drawing.Icon("http://"+web.Url.Host + "//favicon.ico", new Size(16,16));
            lblSit.Text = "Carregado";
        }

        private void txtMecPs_SelectedIndexChanged(object sender, EventArgs e)
        {
            mecpes = txtMecPs.Text;            
        }

        private void BRW_SizeChanged(object sender, EventArgs e)
        {
            txtURL.Size = new Size(
                this.Size.Width - (this.Size.Width - txtURL.Size.Width),
                25);
            mn.Size = new Size(
                this.Size.Width - (this.Size.Width - mn.Size.Width),
                25);
        }
    }
}
