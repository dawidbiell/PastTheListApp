using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NET_Framework
{
    public partial class mainForm
    {
        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            CopyListToClipboard();
        }

        // Form
        private void mainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }

            if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.Visible = true;
            }
        }
        
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterClipboardViewer();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;

        }

        // Menu strip
        private void commaApostrophToolStripMenuItem_Click(object sender, EventArgs e)
        {
            separator_tbx.Text = @",";
            itemPrefix_tbx.Text = @"'";
            itemSufix_tbx.Text = @"'";
            CopyListToClipboard();
        }
        private void semicolonApostrophToolStripMenuItem_Click(object sender, EventArgs e)
        {
            separator_tbx.Text = @";";
            itemPrefix_tbx.Text = @"'";
            itemSufix_tbx.Text = @"'";
            CopyListToClipboard();
        }

        private void commaQuotationMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            separator_tbx.Text = @",";
            itemPrefix_tbx.Text = "\"";
            itemSufix_tbx.Text = "\"";
            CopyListToClipboard();
        }

        private void semicolonQuotationMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           separator_tbx.Text = @";";
           itemPrefix_tbx.Text = "\"";
           itemSufix_tbx.Text = "\"";
            CopyListToClipboard();
        }

        private void eachItemInNewLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inNewLine_chk.Checked = !_list.InNewLine;
            eachItemInNewLineToolStripMenuItem.Checked = _list.InNewLine;
        }

        private void onlyUniqueItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uniqueItems_chk.Checked = !_list.UniqueItems;
            onlyUniqueItemsToolStripMenuItem.Checked= _list.UniqueItems;
        }
    }
}
