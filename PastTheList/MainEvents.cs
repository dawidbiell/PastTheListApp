using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastTheList
{
    partial class Main
    {
        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(preview.Text);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }

            if (this.WindowState==FormWindowState.Normal)
            {
                notifyIcon1.Visible = true;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;

        }
    }
}
