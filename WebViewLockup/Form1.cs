using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebViewLockup
{
    public sealed partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.webView1.NavigateToString("<html><head></head><body><p>Closing this form causes UI lockup</p></body></html>");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            const bool bugWorkaround = false;

            if (bugWorkaround)
            {
                this.webView1.Close(); // this prevents the UI locking up
            }
        }
    }
}
