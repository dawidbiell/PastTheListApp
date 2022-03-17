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

//METHODS
        private void GetClipboardData()
        {
            preview.Text = _list.Preview;
        }

        private void CopyListToClipboard()
        {
            Clipboard.SetText(_list.Preview);
        }

        private void ClearInputs()
        {
            separator_tbx.Text = "";
            listPrefix_tbx.Text = "";
            itemPrefix_tbx.Text = "";
            itemSufix_tbx.Text = "";
            listSufix_tbx.Text = "";
        }

// EVENTS
        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            CopyListToClipboard();
            ClearInputs();
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
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAppBox aboutAppBox = new AboutAppBox();
            aboutAppBox.ShowDialog();
        }

        private void commaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            separator_tbx.Text = @",";
            itemPrefix_tbx.Text = @"";
            itemSufix_tbx.Text = @"";
            if (this.WindowState == FormWindowState.Minimized) CopyListToClipboard();
        }

        private void semicolonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            separator_tbx.Text = @";";
            itemPrefix_tbx.Text = @"";
            itemSufix_tbx.Text = @"";
            if (this.WindowState == FormWindowState.Minimized) CopyListToClipboard();
        }
        private void commaApostrophToolStripMenuItem_Click(object sender, EventArgs e)
        {
            separator_tbx.Text = @",";
            itemPrefix_tbx.Text = @"'";
            itemSufix_tbx.Text = @"'";
            if (this.WindowState == FormWindowState.Minimized) CopyListToClipboard();
        }
        private void semicolonApostrophToolStripMenuItem_Click(object sender, EventArgs e)
        {
            separator_tbx.Text = @";";
            itemPrefix_tbx.Text = @"'";
            itemSufix_tbx.Text = @"'";
            if (this.WindowState == FormWindowState.Minimized) CopyListToClipboard();
        }

        private void commaQuotationMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            separator_tbx.Text = @",";
            itemPrefix_tbx.Text = "\"";
            itemSufix_tbx.Text = "\"";
            if (this.WindowState == FormWindowState.Minimized) CopyListToClipboard();
        }

        private void semicolonQuotationMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
           separator_tbx.Text = @";";
           itemPrefix_tbx.Text = "\"";
           itemSufix_tbx.Text = "\"";
           if (this.WindowState == FormWindowState.Minimized) CopyListToClipboard();
        }

        private void commaSqareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            separator_tbx.Text = @",";
            itemPrefix_tbx.Text = "[";
            itemSufix_tbx.Text = "]";
            if (this.WindowState == FormWindowState.Minimized) CopyListToClipboard();
        }

        private void semicolonSquareBracketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            separator_tbx.Text = @";";
            itemPrefix_tbx.Text = "[";
            itemSufix_tbx.Text = "]";
            if (this.WindowState == FormWindowState.Minimized) CopyListToClipboard();
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
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

    }
}
