using PastTheListLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastTheList
{
    public partial class Main : Form
    {
        private ListProcessor list = new ListProcessor();

        public Main()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void SetParameters()
        {
            list.Separator = this.separator_tbx.Text;
            list.ListPrefix = this.listPrefix_tbx.Text;
            list.ListSufix = this.listSufix_tbx.Text;
            list.ItemPrefix = this.itemPrefix_tbx.Text;
            list.ItemSufix = this.itemSufix_tbx.Text;
            list.InNewLine = this.inNewLine.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetParameters();
            preview.Text =list.GetList();
        }
    }
}
